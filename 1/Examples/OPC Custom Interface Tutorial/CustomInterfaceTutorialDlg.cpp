// CustomInterfaceTutorialDlg.cpp : implementation file
//

#include "stdafx.h"
#include "CustomInterfaceTutorial.h"
#include "CustomInterfaceTutorialDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CCustomInterfaceTutorialDlg dialog

BEGIN_CONNECTION_MAP(CCustomInterfaceTutorialDlg, CCmdTarget)
    CONNECTION_PART(CCustomInterfaceTutorialDlg, IID_IOPCDataCallback, OPCDataCallback)
END_CONNECTION_MAP()

BEGIN_INTERFACE_MAP(CCustomInterfaceTutorialDlg, CCmdTarget)
    INTERFACE_PART(CCustomInterfaceTutorialDlg, IID_IOPCDataCallback, OnDataCallback)
END_INTERFACE_MAP()

CCustomInterfaceTutorialDlg::CCustomInterfaceTutorialDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CCustomInterfaceTutorialDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CCustomInterfaceTutorialDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	//initialize OPCServer pointer
	m_pOPCServer = NULL;
	m_pUnknown = NULL;
}

void CCustomInterfaceTutorialDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CCustomInterfaceTutorialDlg)
	DDX_Control(pDX, IDC_EDIT_WRITE, m_ceWrite);
	DDX_Control(pDX, IDC_EDIT_READ, m_ceRead);
	DDX_Control(pDX, IDC_LIST_ITEMS, m_ListItems);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CCustomInterfaceTutorialDlg, CDialog)
	//{{AFX_MSG_MAP(CCustomInterfaceTutorialDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_COMMAND(ID_SERVER_CONNECT, OnServerConnect)
	ON_COMMAND(ID_SERVER_DISCONNECT, OnServerDisconnect)
	ON_BN_CLICKED(IDC_BUTTON_READ, OnButtonRead)
	ON_BN_CLICKED(IDC_BUTTON_WRITE, OnButtonWrite)
	ON_BN_CLICKED(IDC_BUTTON_INITIALISE, OnButtonInitialise)
	ON_LBN_SELCHANGE(IDC_LIST_ITEMS, OnSelchangeListItems)
	ON_WM_CLOSE()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CCustomInterfaceTutorialDlg message handlers

BOOL CCustomInterfaceTutorialDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	EnableAutomation();
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CCustomInterfaceTutorialDlg::OnPaint() 
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
HCURSOR CCustomInterfaceTutorialDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CCustomInterfaceTutorialDlg::OnServerConnect() 
{
	// Ask if the cdm file has been configured with items of unsigned short type
	// if not, close dialog

	CString csMessage = "You MUST configure the OPC Server file with items of unsigned short type before proceeding.\n Do you want to continue?";
	if (AfxMessageBox(csMessage, MB_YESNO|MB_ICONEXCLAMATION|MB_APPLMODAL) == IDNO)
	{
		CDialog::EndDialog(IDABORT);
		return;
	}

	// Initialize the COM library.

	HRESULT hr;
	hr = CoInitialize(NULL);
	if (FAILED(hr))
	{
		return;
	}

	// Create the OPCServer object and obtain the first interface (IOPCServer).
	
	USES_CONVERSION;
	CLSID clsid;
	LPCOLESTR oleProgID = T2OLE("OMRON.OpenDataServer.1");
	CLSIDFromProgID(oleProgID, &clsid);

	hr = CoCreateInstance(clsid, NULL, CLSCTX_LOCAL_SERVER, IID_IOPCServer, (void**)&m_pOPCServer);
	if (FAILED(hr))
	{
		return;
	}

}

void CCustomInterfaceTutorialDlg::OnServerDisconnect() 
{
	if (m_pOPCServer)
	{
		m_pOPCServer->Release();
		m_pOPCServer = NULL;
	}
}

void CCustomInterfaceTutorialDlg::OnButtonRead() 
{
	if (!m_pUnknown)
		return;

	Advise();

	HRESULT hResult = NULL;
	HRESULT* phErrors = NULL;
	DWORD dwCancelID;
	DWORD dwTransID = 1;
	IOPCAsyncIO2* pAsyncIO2 = NULL;

	ResetEvent(m_hAsyncCompleted);
	
	m_pUnknown->QueryInterface(__uuidof(IOPCAsyncIO2), (void**)&pAsyncIO2);
	hResult = pAsyncIO2->Read(1, &m_opcServerHandle, dwTransID, &dwCancelID, &phErrors);

	if (hResult != S_OK)  // Purposely checking against 0.
	{
	}
	else
	{
		WaitForEvent(m_hAsyncCompleted);
	}

	CoTaskMemFree(phErrors);
}

void CCustomInterfaceTutorialDlg::OnButtonWrite() 
{
	if (!m_pUnknown)
		return;

	Advise();

	HRESULT hResult = NULL;
	HRESULT* phErrors = NULL;
	DWORD dwCancelID;
	DWORD dwTransID = 1;
	IOPCAsyncIO2* pAsyncIO2 = NULL;

	ResetEvent(m_hAsyncCompleted);
	
	m_pUnknown->QueryInterface(__uuidof(IOPCAsyncIO2), (void**)&pAsyncIO2);

	CString csWriteContents;
	m_ceWrite.GetWindowText(csWriteContents);
	unsigned long nVal = (unsigned long)atoi(csWriteContents.GetBuffer(0));

	VARIANT variant;
	VariantInit(&variant);
	variant.ulVal = nVal;
	variant.vt = VT_UI4;

	hResult = pAsyncIO2->Write(1, &m_opcServerHandle, &variant, dwTransID, &dwCancelID, &phErrors);

	if (hResult != S_OK)  // Purposely checking against 0.
	{
	}
	else
	{
		WaitForEvent(m_hAsyncCompleted);
	}

	CoTaskMemFree(phErrors);
}

bool CCustomInterfaceTutorialDlg::WaitForEvent(HANDLE hEvent)
{
    MSG msg;

	for (;;)
	{
		DWORD dwResult = ::MsgWaitForMultipleObjects (1, &hEvent, FALSE, 300000, QS_ALLINPUT);
        switch (dwResult)
		{
		  case WAIT_OBJECT_0:
		  case WAIT_ABANDONED_0:
			  return true;
		  case WAIT_TIMEOUT:
			  return false;
		  case (WAIT_OBJECT_0 + 1):
		      while (::PeekMessage (&msg,NULL,NULL,NULL,PM_NOREMOVE))
              {
			      if (!::MessagePump ())
                  {
				      return false;
                  }
              } 
			  break;

          default:
			  return true;
		}
	}
}

void CCustomInterfaceTutorialDlg::OnButtonInitialise() 
{
	if (!m_pOPCServer)
		return;

	// Add a group.
	DWORD dwRevisedUpdateRate = 0;
	HRESULT hr = E_FAIL;

	hr = m_pOPCServer->AddGroup(
	(LPCWSTR)"myGroup",
	TRUE,
	1000,
	m_hClientGroup,
	0,
	0,
	1033,
	&m_hGroup,
	&dwRevisedUpdateRate,
	__uuidof(IUnknown),
	(IUnknown**)&m_pUnknown);

	if (SUCCEEDED(hr))
	{
	}

	BrowseItems();
	
}

void CCustomInterfaceTutorialDlg::BrowseItems()
{
	if (!m_pOPCServer)
		return;

	USES_CONVERSION;
	
	m_ListItems.ResetContent();

	IOPCBrowseServerAddressSpace* pBAS = NULL;
	IEnumString* pEnum = NULL;
	LPOLESTR pStr, pStrItem;
	ULONG actual;
	long i = 0;

	m_pOPCServer->QueryInterface(__uuidof(IOPCBrowseServerAddressSpace), (void**) &pBAS);
	pBAS->BrowseOPCItemIDs(OPC_FLAT, T2W("*"), VT_UI4, OPC_READABLE|OPC_WRITEABLE, &pEnum);

	while (pEnum->Next(1, &pStr, &actual) == S_OK)
	{
		pBAS->GetItemID(pStr, &pStrItem);
		
		m_ListItems.AddString(CString(pStrItem));
		m_ListItems.SetItemData(i, (DWORD)VT_UI4);

		i++;

		CoTaskMemFree(pStr);
		CoTaskMemFree(pStrItem);
	}

	pEnum->Release();
	pBAS->Release();
}

void CCustomInterfaceTutorialDlg::OnSelchangeListItems() 
{
	if (!m_pUnknown)
		return;

	CString csSel;
	CString csPath;
	int nCurSel = m_ListItems.GetCurSel();
	m_ListItems.GetText(nCurSel, csSel);
	VARTYPE vtType = (VARTYPE)m_ListItems.GetItemData(nCurSel);

	HRESULT *pErrors = NULL;
	OPCITEMRESULT *pOIR = NULL;
	OPCITEMDEF oid;

	oid.szItemID			= csSel.AllocSysString();
	oid.vtRequestedDataType	= vtType;
	oid.szAccessPath		= csPath.AllocSysString();
	oid.hClient				= (OPCHANDLE)nCurSel;
	oid.bActive				= TRUE;
	oid.dwBlobSize			= 0;

	IOPCItemMgt* pIIM;
	m_pUnknown->QueryInterface(__uuidof(IOPCItemMgt), (void**) &pIIM);
	pIIM->AddItems(1, &oid, &pOIR, &pErrors);

	m_opcServerHandle = pOIR->hServer;

	SysFreeString(oid.szItemID);
	SysFreeString(oid.szAccessPath);

	if (pOIR && pOIR->pBlob)
		CoTaskMemFree(pOIR->pBlob);

	if (pOIR)
		CoTaskMemFree(pOIR);			

	if (pErrors)
		CoTaskMemFree(pErrors);
}

long FAR EXPORT CCustomInterfaceTutorialDlg::XOnDataCallback::OnCancelComplete(DWORD dwTransID, OPCHANDLE hGroup)
{
	METHOD_PROLOGUE(CCustomInterfaceTutorialDlg, OnDataCallback)
	return 1;
}

HRESULT FAR EXPORT CCustomInterfaceTutorialDlg::XOnDataCallback::OnWriteComplete(DWORD dwTransID, OPCHANDLE hGroup, HRESULT hrMasterError, DWORD dwCount, OPCHANDLE* phClientItems, HRESULT* pError)
{
	METHOD_PROLOGUE(CCustomInterfaceTutorialDlg, OnDataCallback)
	return S_OK;
}

long FAR EXPORT CCustomInterfaceTutorialDlg::XOnDataCallback::OnReadComplete(DWORD dwTransid, OPCHANDLE hGroup, HRESULT hrMasterquality, HRESULT hrMastererror, DWORD dwCount, OPCHANDLE* phClientItems, VARIANT* pvValues, WORD* pwQualities, FILETIME* pftTimeStamps, HRESULT* pErrors)
{
	METHOD_PROLOGUE(CCustomInterfaceTutorialDlg, OnDataCallback)
	ASSERT_VALID(pThis);

	CString csValue;
	if (pvValues)
	{
		csValue.Format("%ld", pvValues[0].ulVal);
	}
	
	pThis->m_ceRead.SetWindowText(csValue.GetBuffer(0));
	SetEvent(pThis->m_hAsyncCompleted);

	return S_OK;
}

long FAR EXPORT CCustomInterfaceTutorialDlg::XOnDataCallback::OnDataChange(DWORD dwTransid, OPCHANDLE hGroup, HRESULT hrMasterquality, HRESULT hrMastererror, DWORD dwCount, OPCHANDLE* phClientItems, VARIANT* pvValues, WORD* pwQualities, FILETIME* pftTimeStamps, HRESULT* pErrors)
{
	METHOD_PROLOGUE(CCustomInterfaceTutorialDlg, OnDataCallback)

	return S_OK;
}

ULONG FAR EXPORT CCustomInterfaceTutorialDlg::XOnDataCallback::Release(void)
{
	METHOD_PROLOGUE(CCustomInterfaceTutorialDlg, OnDataCallback)
	return pThis->ExternalRelease();
}

ULONG FAR EXPORT CCustomInterfaceTutorialDlg::XOnDataCallback::AddRef(void)
{
	METHOD_PROLOGUE(CCustomInterfaceTutorialDlg, OnDataCallback)
	return pThis->ExternalAddRef();
}

long FAR EXPORT CCustomInterfaceTutorialDlg::XOnDataCallback::QueryInterface(REFIID iid, void** ppvObj)
{
	METHOD_PROLOGUE(CCustomInterfaceTutorialDlg, OnDataCallback)
	return pThis->ExternalQueryInterface(&iid, ppvObj);
}

void CCustomInterfaceTutorialDlg::Advise(void)
{
	if (!m_pUnknown)
		return;

	IConnectionPointContainer* pCPC;
	IConnectionPoint* pCP;
	HRESULT hResult;

	LPUNKNOWN pUnknown = GetIDispatch(FALSE);

	hResult = m_pUnknown->QueryInterface(__uuidof(IConnectionPointContainer), (void**)&pCPC);
	if (SUCCEEDED(hResult))
		hResult = pCPC->FindConnectionPoint(__uuidof(IOPCDataCallback), &pCP);
	if (SUCCEEDED(hResult))
		hResult = pCP->Advise(pUnknown, &m_dwCPCookie);
}

void CCustomInterfaceTutorialDlg::UnAdvise(void)
{
	if (!m_pUnknown)
		return;

	IConnectionPointContainer* pCPC;
	IConnectionPoint* pCP;
	HRESULT hResult;
	hResult = m_pUnknown->QueryInterface(__uuidof(IConnectionPointContainer), (void**)&pCPC);
	if (SUCCEEDED(hResult))
		hResult = pCPC->FindConnectionPoint(__uuidof(IOPCDataCallback), &pCP);
	if (SUCCEEDED(hResult))
		hResult = pCP->Unadvise(m_dwCPCookie);
}

void CCustomInterfaceTutorialDlg::OnClose() 
{
	if (!m_pUnknown)
	{
		CDialog::EndDialog(IDABORT);
		return;
	}

	UnAdvise();

	HRESULT *pErrors = NULL;
	HRESULT hResult = NULL;	

	IOPCItemMgt* pIIM;
	m_pUnknown->QueryInterface(__uuidof(IOPCItemMgt), (void**) &pIIM);
	hResult = pIIM->RemoveItems(1, &m_opcServerHandle, &pErrors);

	if (pErrors)
		CoTaskMemFree(pErrors);

	if (pIIM)
		pIIM->Release();

	if (m_pOPCServer != NULL)
	{
		hResult = m_pOPCServer->RemoveGroup(m_hGroup, TRUE);

		m_pOPCServer->Release();
	}
	
	CDialog::OnClose();
}
