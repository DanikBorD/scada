; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
LastClass=CCustomInterfaceTutorialDlg
LastTemplate=CDialog
NewFileInclude1=#include "stdafx.h"
NewFileInclude2=#include "CustomInterfaceTutorial.h"

ClassCount=2
Class1=CCustomInterfaceTutorialApp
Class2=CCustomInterfaceTutorialDlg

ResourceCount=5
Resource2=IDR_MAINFRAME
Resource3=IDD_CUSTOMINTERFACETUTORIAL_DIALOG
Resource4=IDD_CUSTOMINTERFACETUTORIAL_DIALOG (English (U.S.))
Resource5=IDR_MENU_MAIN

[CLS:CCustomInterfaceTutorialApp]
Type=0
HeaderFile=CustomInterfaceTutorial.h
ImplementationFile=CustomInterfaceTutorial.cpp
Filter=N

[CLS:CCustomInterfaceTutorialDlg]
Type=0
HeaderFile=CustomInterfaceTutorialDlg.h
ImplementationFile=CustomInterfaceTutorialDlg.cpp
Filter=D
BaseClass=CDialog
VirtualFilter=dWC
LastObject=CCustomInterfaceTutorialDlg



[DLG:IDD_CUSTOMINTERFACETUTORIAL_DIALOG]
Type=1
ControlCount=3
Control1=IDOK,button,1342242817
Control2=IDCANCEL,button,1342242816
Control3=IDC_STATIC,static,1342308352
Class=CCustomInterfaceTutorialDlg

[DLG:IDD_CUSTOMINTERFACETUTORIAL_DIALOG (English (U.S.))]
Type=1
Class=CCustomInterfaceTutorialDlg
ControlCount=8
Control1=IDC_LIST_ITEMS,listbox,1352728835
Control2=IDC_BUTTON_READ,button,1342242816
Control3=IDC_BUTTON_WRITE,button,1342242816
Control4=IDC_EDIT_WRITE,edit,1350631552
Control5=IDC_EDIT_READ,edit,1350631552
Control6=IDC_BUTTON_INITIALISE,button,1342242816
Control7=IDC_STATIC,static,1342308352
Control8=IDC_STATIC,static,1342308352

[MNU:IDR_MENU_MAIN]
Type=1
Class=CCustomInterfaceTutorialDlg
Command1=ID_SERVER_CONNECT
Command2=ID_SERVER_DISCONNECT
CommandCount=2

