// This is a CX-Server OPC example in Visual C++ 
// using an Automation interface.
// Copyright © 2002 OMRON Corporation
//
// OPCExample.cpp : Defines the class behaviors for the application.
//
// For more details, read OPC Example.doc file, enclosed 
// with this example.	
//

#include "stdafx.h"
#include "OPCExample.h"
#include "OPCExampleDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// COPCExampleApp

BEGIN_MESSAGE_MAP(COPCExampleApp, CWinApp)
	//{{AFX_MSG_MAP(COPCExampleApp)
		// NOTE - the ClassWizard will add and remove mapping macros here.
		//    DO NOT EDIT what you see in these blocks of generated code!
	//}}AFX_MSG
	ON_COMMAND(ID_HELP, CWinApp::OnHelp)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// COPCExampleApp construction

COPCExampleApp::COPCExampleApp()
{
	// TODO: add construction code here,
	// Place all significant initialization in InitInstance
}

/////////////////////////////////////////////////////////////////////////////
// The one and only COPCExampleApp object

COPCExampleApp theApp;

/////////////////////////////////////////////////////////////////////////////
// COPCExampleApp initialization

BOOL COPCExampleApp::InitInstance()
{
	// Initialize OLE in the MFC
	if (!AfxOleInit())
	{
		AfxMessageBox("OLE initialization failed.Make sure that the OLE libraries are the correct version.");
		return FALSE;
	}

	//Enable ActiveX control support
	AfxEnableControlContainer();

#ifdef _AFXDLL
	Enable3dControls();			// Call this when using MFC in a shared DLL
#else
	Enable3dControlsStatic();	// Call this when linking to MFC statically
#endif

	// display OPC Example dialog
	COPCExampleDlg dlg;
	m_pMainWnd = &dlg;
	return (dlg.DoModal());
}
