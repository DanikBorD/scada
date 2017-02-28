// CustomInterfaceTutorialDlg.h : header file
//

#if !defined(AFX_CUSTOMINTERFACETUTORIALDLG_H__C62F7452_7CEE_45F5_820C_CAB72C81F870__INCLUDED_)
#define AFX_CUSTOMINTERFACETUTORIALDLG_H__C62F7452_7CEE_45F5_820C_CAB72C81F870__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include "opccomn.h"
#include "opcda.h"
#include "AFXPRIV.H"

/////////////////////////////////////////////////////////////////////////////
// CCustomInterfaceTutorialDlg dialog

EXTERN_C const CLSID CLSID_OPCServerList;	// opcenum_clsid.c
EXTERN_C const IID IID_IOPCServerList;		// opccomn_i.c
EXTERN_C const IID IID_IOPCServer;			// opcda.h

class CCustomInterfaceTutorialDlg : public CDialog
{
private:
	IOPCServer* m_pOPCServer;
	IUnknown* m_pUnknown;
	HANDLE m_hAsyncCompleted;
	OPCHANDLE m_opcServerHandle;
	DWORD m_dwCPCookie;
	OPCHANDLE m_hGroup;
	OPCHANDLE m_hClientGroup;


	// Construction
public:
	CCustomInterfaceTutorialDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CCustomInterfaceTutorialDlg)
	enum { IDD = IDD_CUSTOMINTERFACETUTORIAL_DIALOG };
	CEdit	m_ceWrite;
	CEdit	m_ceRead;
	CListBox	m_ListItems;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CCustomInterfaceTutorialDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CCustomInterfaceTutorialDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnServerConnect();
	afx_msg void OnServerDisconnect();
	afx_msg void OnButtonRead();
	afx_msg void OnButtonWrite();
	afx_msg void OnButtonInitialise();
	afx_msg void OnSelchangeListItems();
	afx_msg void OnClose();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()

	BEGIN_CONNECTION_PART(CCustomInterfaceTutorialDlg, OPCDataCallback)
        CONNECTION_IID(IID_IOPCDataCallback)
    END_CONNECTION_PART(OPCDataCallback)

    DECLARE_CONNECTION_MAP()
	
	DECLARE_INTERFACE_MAP()

	BEGIN_INTERFACE_PART(OnDataCallback, IOPCDataCallback)
	STDMETHOD(OnDataChange)(
		/*[in]*/ DWORD dwTransid,
		/*[in]*/ OPCHANDLE hGroup,
		/*[in]*/ HRESULT hrMasterquality,
		/*[in]*/ HRESULT hrMastererror,
		/*[in]*/ DWORD dwCount,
		/*[in, sizeis(dwCount)]*/ OPCHANDLE* phClientItems,
		/*[in, sizeis(dwCount)]*/ VARIANT* pvValues, 
		/*[in, sizeis(dwCount)]*/ WORD* pwQualities,
		/*[in, sizeis(dwCount)]*/ FILETIME* pftTimeStamps,
		/*[in, sizeis(dwCount)]*/ HRESULT* pErrors);
	STDMETHOD(OnReadComplete)(
		/*[in]*/ DWORD dwTransid,
		/*[in]*/ OPCHANDLE hGroup,
		/*[in]*/ HRESULT hrMasterquality,
		/*[in]*/ HRESULT hrMastererror,
		/*[in]*/ DWORD dwCount,
		/*[in, sizeis(dwCount)]*/ OPCHANDLE* phClientItems,
		/*[in, sizeis(dwCount)]*/ VARIANT* pvValues, 
		/*[in, sizeis(dwCount)]*/ WORD* pwQualities,
		/*[in, sizeis(dwCount)]*/ FILETIME* pftTimeStamps,
		/*[in, sizeis(dwCount)]*/ HRESULT* pErrors);
	STDMETHOD(OnWriteComplete)(
		/*[in]*/ DWORD dwTransid,
		/*[in]*/ OPCHANDLE hGroup,
		/*[in]*/ HRESULT hrMasterError,
		/*[in]*/ DWORD dwCount,
		/*[in, sizeis(dwCount)]*/ OPCHANDLE* phClientItems,
		/*[in, sizeis(dwCount)]*/ HRESULT* pError);
	STDMETHOD(OnCancelComplete)(
		/*[in]*/ DWORD dwTransid,
		/*[in]*/ OPCHANDLE hGroup);
	END_INTERFACE_PART(OnDataCallback)

private:
	void BrowseItems();
	bool WaitForEvent(HANDLE);
	void Advise();
	void UnAdvise();

};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_CUSTOMINTERFACETUTORIALDLG_H__C62F7452_7CEE_45F5_820C_CAB72C81F870__INCLUDED_)
