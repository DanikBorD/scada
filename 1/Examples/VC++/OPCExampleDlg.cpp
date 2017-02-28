// This is a CX-Server OPC example in Visual C++ 
// using an Automation interface.
// Copyright © 2002 OMRON Corporation
//
// This source code is intended to initialize the 
// About Dialog and the OPC Example Dialog
// as well as show how to implement GetData, StopData,
// OnData, Read and Write Asyncronous and Read 
// and Write Syncronous commands with the use of a OPC component.
// 
// For more details, read OPC Example.doc file, enclosed 
// with this example.	
//
// OPCExampleDlg.cpp 
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
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// COPCExampleDlg dialog

COPCExampleDlg::COPCExampleDlg(CWnd* pParent /*=NULL*/)
	: CDialog(COPCExampleDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(COPCExampleDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void COPCExampleDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(COPCExampleDlg)
	DDX_Control(pDX, IDC_CXOPCCLIENTCOMMUNICATIONSCTRL1, m_OPCCtrl);
	DDX_Control(pDX, IDC_GROUP_COMBO, m_cbGroupList);
	DDX_Control(pDX, IDC_ITEM_COMBO, m_cbItemList);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(COPCExampleDlg, CDialog)
	//{{AFX_MSG_MAP(COPCExampleDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_GETDATA, OnGetData)
	ON_BN_CLICKED(IDC_STOPDATA, OnStopData)
	ON_BN_CLICKED(IDC_READ_ASYNC, OnReadAsync)
	ON_BN_CLICKED(IDC_READ_SYNC, OnReadSync)
	ON_BN_CLICKED(IDC_WRITE_ASYNC, OnWriteAsync)
	ON_BN_CLICKED(IDC_WRITE_SYNC, OnWriteSync)
	ON_BN_CLICKED(IDEXIT, OnExit)
	ON_CBN_SELCHANGE(IDC_GROUP_COMBO, OnSelchangeGroupCombo)
	ON_BN_CLICKED(IDC_BUTTON_PROJECT, OnButtonProject)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// COPCExampleDlg message handlers

BOOL COPCExampleDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog. The framework does this automatically
	// when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// Get the name of the server and the name of the Project (the opc file)
	SetDlgItemText(IDC_SERVER_NAME_TEXT,m_OPCCtrl.GetServerName());
	SetDlgItemText(IDC_PROJECT_NAME_TEXT, m_OPCCtrl.GetProjectName());
		
	//Add the Groups to the Combo control
	m_cbGroupList.AddString("CQM1H");
	m_cbGroupList.AddString("CS1H");
	m_cbGroupList.SetCurSel(0);

	//Add the Items to the Combo control for CQM1H which is the one selected by default
	m_cbItemList.AddString("boolPoint1");
	m_cbItemList.AddString("dblPoint1");
	m_cbItemList.AddString("intPoint1");
	m_cbItemList.SetCurSel(0);

	//Connect to OPC server
	m_OPCCtrl.ConnectToServer(TRUE);
	return TRUE;  // return TRUE  unless you set the focus to a control
}


void COPCExampleDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}


// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void COPCExampleDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}


// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR COPCExampleDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

//OPC commands
void COPCExampleDlg::OnGetData()
{
	m_OPCCtrl.GetData(GetGroupSelected(),GetItemSelected(),1);
}


void COPCExampleDlg::OnStopData()
{
	m_OPCCtrl.StopData(GetGroupSelected(),GetItemSelected());
}


void COPCExampleDlg::OnReadAsync()
{
	m_OPCCtrl.Read(GetGroupSelected(),GetItemSelected(),1);
}


void COPCExampleDlg::OnWriteAsync()
{
	CString csValue;
	GetDlgItemText(IDC_WRITE_ASYNC_TEXT,csValue);
	m_OPCCtrl.Write(GetGroupSelected(),GetItemSelected(),ProcessInput(csValue),1);
}


void COPCExampleDlg::OnReadSync()
{
	COleVariant vaData;
	vaData = m_OPCCtrl.GetValue(GetGroupSelected(),GetItemSelected());
	SetDlgItemText(IDC_READ_SYNC_TEXT,ProcessOutput(vaData));
}


void COPCExampleDlg::OnWriteSync()
{
	CString csValue;
	GetDlgItemText(IDC_WRITE_SYNC_TEXT,csValue);
	m_OPCCtrl.SetValue(GetGroupSelected(),GetItemSelected(),ProcessInput(csValue));

}

// Process data to pass as a parameter to the functions defined
// in the wrapper class
COleVariant COPCExampleDlg::ProcessInput(CString csValue)
{
	csValue.MakeUpper();
	COleVariant var(csValue);
	if(csValue.Find(".") != -1)
		var.ChangeType(VT_R4);
	else if(csValue == "TRUE")
	{
		var.vt = VT_BOOL;
		var = (short)1;
	}
	else if (csValue == "FALSE")
	{
		var.vt = VT_BOOL;
		var = (short)0;
	}
	else
		var.ChangeType(VT_I2);
	return var;
}

// Process data retrieved from the functions defined
// in the wrapper class
CString COPCExampleDlg::ProcessOutput(COleVariant vaData)
{
	COleVariant vaTemp;
	CString strTextData;
	if (vaData.vt == VT_BOOL) 
	{
		vaTemp.ChangeType(VT_BSTR, &vaData); 
		strTextData = vaTemp.bstrVal;
		if (strTextData != "0")
			strTextData = "true";
		else
			strTextData = "false";
	}
	else
	{
		vaTemp.ChangeType(VT_BSTR, &vaData); 
		strTextData = vaTemp.bstrVal;
	}
	return strTextData;
}


void COPCExampleDlg::OnExit()
{
	// disconnect from opc server and end dialog
	m_OPCCtrl.Disconnect();
	EndDialog(TRUE);
}


void COPCExampleDlg::OnSelchangeGroupCombo()
{
    // On selection and change of the Group Combo Box
    // the corresponding list of items is added 
	// to the Item Combo Box
	m_cbItemList.ResetContent();
	CString csGroupName = GetGroupSelected();
	if (csGroupName == "CS1H")
	{
		m_cbItemList.AddString("boolPoint2");
		m_cbItemList.AddString("dblPoint2");
		m_cbItemList.AddString("intPoint2");
		m_cbItemList.SetCurSel(0);
	}
	else if (csGroupName == "CQM1H")
	{
		m_cbItemList.AddString("boolPoint1");
		m_cbItemList.AddString("dblPoint1");
		m_cbItemList.AddString("intPoint1");
		m_cbItemList.SetCurSel(0);
	}	
	else 
		AfxMessageBox("No group name has been selected");
		
}


CString COPCExampleDlg::GetGroupSelected()
{
	//Return Group Name selected in the combo box
	CString csSelection;
	int nSel = m_cbGroupList.GetCurSel();
	if (nSel != CB_ERR)
	{
		m_cbGroupList.GetLBText(nSel,csSelection);
		return csSelection;
	}
	else
		return " ";
}


CString COPCExampleDlg::GetItemSelected()
{
	//Return Item Name selected in the combo box
	CString csSelection;
	int nSel = m_cbItemList.GetCurSel();
	if (nSel != CB_ERR)
	{
		m_cbItemList.GetLBText(nSel,csSelection);
		return csSelection;
	}
	else
		return " ";
}

// On Data event, generated by Visual C++
// For more details of how was generated, read
// OPC Example.doc file, enclosed with this example.	

BEGIN_EVENTSINK_MAP(COPCExampleDlg, CDialog)
    //{{AFX_EVENTSINK_MAP(COPCExampleDlg)
	ON_EVENT(COPCExampleDlg, IDC_CXOPCCLIENTCOMMUNICATIONSCTRL1, 1 /* OnData */, OnOnDataCxopcclientcommunicationsctrl1, VTS_BSTR VTS_BSTR VTS_VARIANT VTS_BOOL)
	//}}AFX_EVENTSINK_MAP
END_EVENTSINK_MAP()

void COPCExampleDlg::OnOnDataCxopcclientcommunicationsctrl1(LPCTSTR Group, LPCTSTR Item, const VARIANT FAR& Value, BOOL BadQuality) 
{
	SetDlgItemText(IDC_GETDATA_TEXT, ProcessOutput(Value));
	SetDlgItemText(IDC_READ_ASYNC_TEXT, ProcessOutput(Value));
}

void COPCExampleDlg::OnButtonProject() 
{
	CFileDialog fd(
		TRUE,
		"*.opc",
		"*.opc",
		OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT,
		"OPC Files (*.opc)|*.opc||");

	if (fd.DoModal() == IDOK)
	{
		m_OPCCtrl.Disconnect();

		m_OPCCtrl.SetProjectName(fd.GetPathName());
		SetDlgItemText(IDC_PROJECT_NAME_TEXT, m_OPCCtrl.GetProjectName());

		m_OPCCtrl.ConnectToServer(TRUE);
	}
}
