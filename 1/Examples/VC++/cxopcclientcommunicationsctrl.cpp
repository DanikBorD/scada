// Machine generated IDispatch wrapper class(es) created by Microsoft Visual C++

// NOTE: Do not modify the contents of this file.  If this class is regenerated by
//  Microsoft Visual C++, your modifications will be overwritten.


#include "stdafx.h"
#include "cxopcclientcommunicationsctrl.h"

/////////////////////////////////////////////////////////////////////////////
// CCXOPCClientCommunicationsCtrl

IMPLEMENT_DYNCREATE(CCXOPCClientCommunicationsCtrl, CWnd)

/////////////////////////////////////////////////////////////////////////////
// CCXOPCClientCommunicationsCtrl properties

/////////////////////////////////////////////////////////////////////////////
// CCXOPCClientCommunicationsCtrl operations

void CCXOPCClientCommunicationsCtrl::AboutBox()
{
	InvokeHelper(0xfffffdd8, DISPATCH_METHOD, VT_EMPTY, NULL, NULL);
}

CString CCXOPCClientCommunicationsCtrl::GetServerComputerName()
{
	CString result;
	InvokeHelper(0x1, DISPATCH_PROPERTYGET, VT_BSTR, (void*)&result, NULL);
	return result;
}

void CCXOPCClientCommunicationsCtrl::SetServerComputerName(LPCTSTR lpszNewValue)
{
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0x1, DISPATCH_PROPERTYPUT, VT_EMPTY, NULL, parms,
		 lpszNewValue);
}

CString CCXOPCClientCommunicationsCtrl::GetServerName()
{
	CString result;
	InvokeHelper(0x2, DISPATCH_PROPERTYGET, VT_BSTR, (void*)&result, NULL);
	return result;
}

void CCXOPCClientCommunicationsCtrl::SetServerName(LPCTSTR lpszNewValue)
{
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0x2, DISPATCH_PROPERTYPUT, VT_EMPTY, NULL, parms,
		 lpszNewValue);
}

CString CCXOPCClientCommunicationsCtrl::GetServerProjectName()
{
	CString result;
	InvokeHelper(0x3, DISPATCH_PROPERTYGET, VT_BSTR, (void*)&result, NULL);
	return result;
}

void CCXOPCClientCommunicationsCtrl::SetServerProjectName(LPCTSTR lpszNewValue)
{
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0x3, DISPATCH_PROPERTYPUT, VT_EMPTY, NULL, parms,
		 lpszNewValue);
}

CString CCXOPCClientCommunicationsCtrl::GetProjectName()
{
	CString result;
	InvokeHelper(0x4, DISPATCH_PROPERTYGET, VT_BSTR, (void*)&result, NULL);
	return result;
}

void CCXOPCClientCommunicationsCtrl::SetProjectName(LPCTSTR lpszNewValue)
{
	static BYTE parms[] =
		VTS_BSTR;
	InvokeHelper(0x4, DISPATCH_PROPERTYPUT, VT_EMPTY, NULL, parms,
		 lpszNewValue);
}

VARIANT CCXOPCClientCommunicationsCtrl::GetValue(LPCTSTR Group, LPCTSTR Item)
{
	VARIANT result;
	static BYTE parms[] =
		VTS_BSTR VTS_BSTR;
	InvokeHelper(0x0, DISPATCH_PROPERTYGET, VT_VARIANT, (void*)&result, parms,
		Group, Item);
	return result;
}

void CCXOPCClientCommunicationsCtrl::SetValue(LPCTSTR Group, LPCTSTR Item, const VARIANT& newValue)
{
	static BYTE parms[] =
		VTS_BSTR VTS_BSTR VTS_VARIANT;
	InvokeHelper(0x0, DISPATCH_PROPERTYPUT, VT_EMPTY, NULL, parms,
		 Group, Item, &newValue);
}

void CCXOPCClientCommunicationsCtrl::ConnectToServer(BOOL DownloadGroupsAndItems)
{
	static BYTE parms[] =
		VTS_BOOL;
	InvokeHelper(0xc, DISPATCH_METHOD, VT_EMPTY, NULL, parms,
		 DownloadGroupsAndItems);
}

void CCXOPCClientCommunicationsCtrl::Disconnect()
{
	InvokeHelper(0xe, DISPATCH_METHOD, VT_EMPTY, NULL, NULL);
}

void CCXOPCClientCommunicationsCtrl::Help()
{
	InvokeHelper(0xf, DISPATCH_METHOD, VT_EMPTY, NULL, NULL);
}

VARIANT CCXOPCClientCommunicationsCtrl::Read(LPCTSTR Group, LPCTSTR Item, long Wait)
{
	VARIANT result;
	static BYTE parms[] =
		VTS_BSTR VTS_BSTR VTS_I4;
	InvokeHelper(0x12, DISPATCH_METHOD, VT_VARIANT, (void*)&result, parms,
		Group, Item, Wait);
	return result;
}

void CCXOPCClientCommunicationsCtrl::Write(LPCTSTR Group, LPCTSTR Item, const VARIANT& Value, long Wait)
{
	static BYTE parms[] =
		VTS_BSTR VTS_BSTR VTS_VARIANT VTS_I4;
	InvokeHelper(0x13, DISPATCH_METHOD, VT_EMPTY, NULL, parms,
		 Group, Item, &Value, Wait);
}

BOOL CCXOPCClientCommunicationsCtrl::GetActive(LPCTSTR Group, LPCTSTR Item)
{
	BOOL result;
	static BYTE parms[] =
		VTS_BSTR VTS_BSTR;
	InvokeHelper(0x14, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, parms,
		Group, Item);
	return result;
}

void CCXOPCClientCommunicationsCtrl::SetActive(LPCTSTR Group, LPCTSTR Item, BOOL bNewValue)
{
	static BYTE parms[] =
		VTS_BSTR VTS_BSTR VTS_BOOL;
	InvokeHelper(0x14, DISPATCH_PROPERTYPUT, VT_EMPTY, NULL, parms,
		 Group, Item, bNewValue);
}

void CCXOPCClientCommunicationsCtrl::GetData(LPCTSTR Group, LPCTSTR Item, long Update)
{
	static BYTE parms[] =
		VTS_BSTR VTS_BSTR VTS_I4;
	InvokeHelper(0x15, DISPATCH_METHOD, VT_EMPTY, NULL, parms,
		 Group, Item, Update);
}

void CCXOPCClientCommunicationsCtrl::StopData(LPCTSTR Group, LPCTSTR Item)
{
	static BYTE parms[] =
		VTS_BSTR VTS_BSTR;
	InvokeHelper(0x16, DISPATCH_METHOD, VT_EMPTY, NULL, parms,
		 Group, Item);
}

BOOL CCXOPCClientCommunicationsCtrl::GetDisplayErrors()
{
	BOOL result;
	InvokeHelper(0x17, DISPATCH_PROPERTYGET, VT_BOOL, (void*)&result, NULL);
	return result;
}

void CCXOPCClientCommunicationsCtrl::SetDisplayErrors(BOOL bNewValue)
{
	static BYTE parms[] =
		VTS_BOOL;
	InvokeHelper(0x17, DISPATCH_PROPERTYPUT, VT_EMPTY, NULL, parms,
		 bNewValue);
}
