// stdafx.cpp : source file that includes just the standard includes
//	CustomInterfaceTutorial.pch will be the pre-compiled header
//	stdafx.obj will contain the pre-compiled type information

#include "stdafx.h"

bool MessagePump()
{
  MSG msg;

  //
  // Pump messages till we receive WM_RELEASE_HOLD.
  //
  do
  {
    if (!::GetMessage (&msg,NULL,NULL,NULL))
    {
      //
      // Received WM_QUIT.
      //
      ::PostMessage (msg.hwnd,msg.message,msg.wParam,msg.lParam);

      return false;
    }
    else
    {
      ::TranslateMessage (&msg);
      ::DispatchMessage (&msg);
    }
  }
  while (::PeekMessage (&msg,NULL,NULL,NULL,PM_NOREMOVE));

  return true;
}
