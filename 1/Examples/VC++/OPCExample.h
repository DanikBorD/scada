// This is a CX-Server OPC example in Visual C++ 
// using an Automation interface.
// Copyright © 2002 OMRON Corporation
//
// OPCExample.h : main header file for the OPCEXAMPLE application
//
// For more details, read OPC Example.doc file, enclosed 
// with this example.	
//

#if !defined(AFX_OPCEXAMPLE_H__E8C786BA_D429_4789_96AC_4590F4372598__INCLUDED_)
#define AFX_OPCEXAMPLE_H__E8C786BA_D429_4789_96AC_4590F4372598__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// COPCExampleApp:
// See OPCExample.cpp for the implementation of this class
//

class COPCExampleApp : public CWinApp
{
public:
	COPCExampleApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(COPCExampleApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(COPCExampleApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_OPCEXAMPLE_H__E8C786BA_D429_4789_96AC_4590F4372598__INCLUDED_)
