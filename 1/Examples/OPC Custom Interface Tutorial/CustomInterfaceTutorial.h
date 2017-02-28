// CustomInterfaceTutorial.h : main header file for the CUSTOMINTERFACETUTORIAL application
//

#if !defined(AFX_CUSTOMINTERFACETUTORIAL_H__63A3CD26_BA15_4B6E_A86C_497AED5AD93E__INCLUDED_)
#define AFX_CUSTOMINTERFACETUTORIAL_H__63A3CD26_BA15_4B6E_A86C_497AED5AD93E__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CCustomInterfaceTutorialApp:
// See CustomInterfaceTutorial.cpp for the implementation of this class
//

class CCustomInterfaceTutorialApp : public CWinApp
{
public:
	CCustomInterfaceTutorialApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CCustomInterfaceTutorialApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CCustomInterfaceTutorialApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_CUSTOMINTERFACETUTORIAL_H__63A3CD26_BA15_4B6E_A86C_497AED5AD93E__INCLUDED_)
