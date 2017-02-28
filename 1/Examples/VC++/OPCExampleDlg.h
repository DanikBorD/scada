// This is a CX-Server OPC example in Visual C++ 
// using an Automation interface.
// Copyright © 2002 OMRON Corporation
//
// OPCExampleDlg.h : header file declare all the functions used 
// in OPC Example Application.
//
// For more details, read OPC Example.doc file, enclosed 
// with this example.	
//

#include "cxopcclientcommunicationsctrl.h"

#if !defined(AFX_OPCEXAMPLEDLG_H__09F24A9D_72BC_41F4_8546_2D5FE17B3241__INCLUDED_)
#define AFX_OPCEXAMPLEDLG_H__09F24A9D_72BC_41F4_8546_2D5FE17B3241__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// COPCExampleDlg dialog

class COPCExampleDlg : public CDialog
{
// Construction
private:
	COleVariant ProcessInput(CString csValue);
	CString ProcessOutput(COleVariant vaData);
	CString GetGroupSelected();
	CString GetItemSelected();
public:
	COPCExampleDlg(CWnd* pParent = NULL);	// standard constructor
	
// Dialog Data
	//{{AFX_DATA(COPCAppDlg)
	enum { IDD = IDD_OPCEXAMPLE_DIALOG };
	CCXOPCClientCommunicationsCtrl m_OPCCtrl;
	CComboBox	m_cbGroupList;
	CComboBox	m_cbItemList;
	
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(COPCAppDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(COPCExampleDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnOnDataCxopcclientcommunicationsctrl1(LPCTSTR Group, LPCTSTR Item, const VARIANT FAR& Value, BOOL BadQuality);
	afx_msg void OnGetData();
	afx_msg void OnStopData();
	afx_msg void OnReadAsync();
	afx_msg void OnReadSync();
	afx_msg void OnWriteAsync();
	afx_msg void OnWriteSync();
	afx_msg void OnExit();
	afx_msg void OnSelchangeGroupCombo();
	afx_msg void OnButtonProject();
	DECLARE_EVENTSINK_MAP()
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_OPCEXAMPLEDLG_H__09F24A9D_72BC_41F4_8546_2D5FE17B3241__INCLUDED_)
