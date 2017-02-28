VERSION 5.00
Object = "{BDC217C8-ED16-11CD-956C-0000C04E4C0A}#1.1#0"; "tabctl32.ocx"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Object = "{883740F0-C519-11D3-92DF-005004B0A636}#1.15#0"; "OPCCOM~1.OCX"
Object = "{8EA37624-CFDB-11D3-9FAE-005004B0A5D9}#1.91#0"; "CX7SEG~1.OCX"
Object = "{98F2ABE2-C2C3-11D3-9F93-005004B0A5D9}#1.8#0"; "CXKnob.ocx"
Object = "{56C5EA50-9C02-11D3-92B6-005004B0A636}#1.9#0"; "CXDisplay.ocx"
Object = "{65959342-C2AF-11D3-9F92-005004B0A5D9}#1.7#0"; "CXRotaryGauge.ocx"
Object = "{935EC9F2-9B57-11D3-9F4A-005004B0A5D9}#1.9#0"; "CXLinearGauge.ocx"
Object = "{0084C5A0-B9EF-11D3-B65F-0080C7DF6B6B}#1.9#0"; "CXToggleButton.ocx"
Object = "{98316954-D3EC-11D3-9FB6-005004B0A5D9}#1.5#0"; "CXLed.ocx"
Begin VB.Form MainForm 
   BackColor       =   &H00C0C0C0&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CX-Server OPC Test Application"
   ClientHeight    =   7080
   ClientLeft      =   2250
   ClientTop       =   2340
   ClientWidth     =   8580
   HelpContextID   =   1
   Icon            =   "Main.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   7080
   ScaleWidth      =   8580
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   600
      Top             =   6480
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin TabDlg.SSTab tabControl 
      Height          =   6135
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   8295
      _ExtentX        =   14631
      _ExtentY        =   10821
      _Version        =   393216
      Tabs            =   6
      TabsPerRow      =   6
      TabHeight       =   420
      BackColor       =   12632256
      MouseIcon       =   "Main.frx":030A
      TabCaption(0)   =   "Main"
      TabPicture(0)   =   "Main.frx":0326
      Tab(0).ControlEnabled=   -1  'True
      Tab(0).Control(0)=   "Image1"
      Tab(0).Control(0).Enabled=   0   'False
      Tab(0).Control(1)=   "lblTitle"
      Tab(0).Control(1).Enabled=   0   'False
      Tab(0).Control(2)=   "cmdExit"
      Tab(0).Control(2).Enabled=   0   'False
      Tab(0).Control(3)=   "OPCComms1"
      Tab(0).Control(3).Enabled=   0   'False
      Tab(0).ControlCount=   4
      TabCaption(1)   =   "7 Segment"
      TabPicture(1)   =   "Main.frx":0342
      Tab(1).ControlEnabled=   0   'False
      Tab(1).Control(0)=   "Label1"
      Tab(1).Control(0).Enabled=   0   'False
      Tab(1).Control(1)=   "Segment2"
      Tab(1).Control(1).Enabled=   0   'False
      Tab(1).Control(2)=   "Segment1"
      Tab(1).Control(2).Enabled=   0   'False
      Tab(1).Control(3)=   "Segment3"
      Tab(1).Control(3).Enabled=   0   'False
      Tab(1).Control(4)=   "Segment4"
      Tab(1).Control(4).Enabled=   0   'False
      Tab(1).Control(5)=   "Segment5"
      Tab(1).Control(5).Enabled=   0   'False
      Tab(1).Control(6)=   "Segment6"
      Tab(1).Control(6).Enabled=   0   'False
      Tab(1).Control(7)=   "Segment7"
      Tab(1).Control(7).Enabled=   0   'False
      Tab(1).ControlCount=   8
      TabCaption(2)   =   "Knob/Display"
      TabPicture(2)   =   "Main.frx":035E
      Tab(2).ControlEnabled=   0   'False
      Tab(2).Control(0)=   "Label2"
      Tab(2).Control(0).Enabled=   0   'False
      Tab(2).Control(1)=   "Knob1"
      Tab(2).Control(1).Enabled=   0   'False
      Tab(2).Control(2)=   "Display1"
      Tab(2).Control(2).Enabled=   0   'False
      Tab(2).Control(3)=   "Knob2"
      Tab(2).Control(3).Enabled=   0   'False
      Tab(2).Control(4)=   "Display2"
      Tab(2).Control(4).Enabled=   0   'False
      Tab(2).ControlCount=   5
      TabCaption(3)   =   "Gauges"
      TabPicture(3)   =   "Main.frx":037A
      Tab(3).ControlEnabled=   0   'False
      Tab(3).Control(0)=   "Gauge1"
      Tab(3).Control(0).Enabled=   0   'False
      Tab(3).Control(1)=   "Gauge2"
      Tab(3).Control(1).Enabled=   0   'False
      Tab(3).Control(2)=   "Gauge3"
      Tab(3).Control(2).Enabled=   0   'False
      Tab(3).Control(3)=   "Gauge4"
      Tab(3).Control(3).Enabled=   0   'False
      Tab(3).Control(4)=   "Gauge5"
      Tab(3).Control(4).Enabled=   0   'False
      Tab(3).Control(5)=   "Gauge6"
      Tab(3).Control(5).Enabled=   0   'False
      Tab(3).Control(6)=   "Timer1"
      Tab(3).Control(6).Enabled=   0   'False
      Tab(3).ControlCount=   7
      TabCaption(4)   =   "Toggle/LED"
      TabPicture(4)   =   "Main.frx":0396
      Tab(4).ControlEnabled=   0   'False
      Tab(4).Control(0)=   "LED5"
      Tab(4).Control(0).Enabled=   0   'False
      Tab(4).Control(1)=   "Toggle1"
      Tab(4).Control(1).Enabled=   0   'False
      Tab(4).Control(2)=   "LED1"
      Tab(4).Control(2).Enabled=   0   'False
      Tab(4).Control(3)=   "Toggle2"
      Tab(4).Control(3).Enabled=   0   'False
      Tab(4).Control(4)=   "Toggle3"
      Tab(4).Control(4).Enabled=   0   'False
      Tab(4).Control(5)=   "Toggle4"
      Tab(4).Control(5).Enabled=   0   'False
      Tab(4).Control(6)=   "Toggle5"
      Tab(4).Control(6).Enabled=   0   'False
      Tab(4).Control(7)=   "Toggle6"
      Tab(4).Control(7).Enabled=   0   'False
      Tab(4).Control(8)=   "LED2"
      Tab(4).Control(8).Enabled=   0   'False
      Tab(4).Control(9)=   "LED3"
      Tab(4).Control(9).Enabled=   0   'False
      Tab(4).Control(10)=   "LED4"
      Tab(4).Control(10).Enabled=   0   'False
      Tab(4).Control(11)=   "LED6"
      Tab(4).Control(11).Enabled=   0   'False
      Tab(4).ControlCount=   12
      TabCaption(5)   =   "Scripts"
      TabPicture(5)   =   "Main.frx":03B2
      Tab(5).ControlEnabled=   0   'False
      Tab(5).Control(0)=   "lblGetValue"
      Tab(5).Control(0).Enabled=   0   'False
      Tab(5).Control(1)=   "lblName"
      Tab(5).Control(1).Enabled=   0   'False
      Tab(5).Control(2)=   "lblProject"
      Tab(5).Control(2).Enabled=   0   'False
      Tab(5).Control(3)=   "Label3"
      Tab(5).Control(3).Enabled=   0   'False
      Tab(5).Control(4)=   "lblNode"
      Tab(5).Control(4).Enabled=   0   'False
      Tab(5).Control(5)=   "cmdGetValue"
      Tab(5).Control(5).Enabled=   0   'False
      Tab(5).Control(6)=   "cmdSetValue"
      Tab(5).Control(6).Enabled=   0   'False
      Tab(5).Control(7)=   "txtSetValue"
      Tab(5).Control(7).Enabled=   0   'False
      Tab(5).Control(8)=   "cmdProperties"
      Tab(5).Control(8).Enabled=   0   'False
      Tab(5).Control(9)=   "txtName"
      Tab(5).Control(9).Enabled=   0   'False
      Tab(5).Control(10)=   "txtProject"
      Tab(5).Control(10).Enabled=   0   'False
      Tab(5).Control(11)=   "txtServer"
      Tab(5).Control(11).Enabled=   0   'False
      Tab(5).Control(12)=   "txtNode"
      Tab(5).Control(12).Enabled=   0   'False
      Tab(5).Control(13)=   "cmdSyncWrite"
      Tab(5).Control(13).Enabled=   0   'False
      Tab(5).Control(14)=   "cmdSyncRead"
      Tab(5).Control(14).Enabled=   0   'False
      Tab(5).Control(15)=   "txtSyncWrite"
      Tab(5).Control(15).Enabled=   0   'False
      Tab(5).Control(16)=   "txtSyncRead"
      Tab(5).Control(16).Enabled=   0   'False
      Tab(5).Control(17)=   "cmdAsyncWrite"
      Tab(5).Control(17).Enabled=   0   'False
      Tab(5).Control(18)=   "txtAsyncWrite"
      Tab(5).Control(18).Enabled=   0   'False
      Tab(5).Control(19)=   "cmdAsyncRead"
      Tab(5).Control(19).Enabled=   0   'False
      Tab(5).Control(20)=   "txtAsyncRead"
      Tab(5).Control(20).Enabled=   0   'False
      Tab(5).Control(21)=   "cmdGetData"
      Tab(5).Control(21).Enabled=   0   'False
      Tab(5).Control(22)=   "cmdStopData"
      Tab(5).Control(22).Enabled=   0   'False
      Tab(5).Control(23)=   "txtGetData"
      Tab(5).Control(23).Enabled=   0   'False
      Tab(5).Control(24)=   "cmdWriteArray"
      Tab(5).Control(24).Enabled=   0   'False
      Tab(5).Control(25)=   "cmdReadArray"
      Tab(5).Control(25).Enabled=   0   'False
      Tab(5).Control(26)=   "txtReadArray"
      Tab(5).Control(26).Enabled=   0   'False
      Tab(5).Control(27)=   "txtWriteArray"
      Tab(5).Control(27).Enabled=   0   'False
      Tab(5).ControlCount=   28
      Begin VB.TextBox txtWriteArray 
         Height          =   375
         Left            =   -72840
         TabIndex        =   61
         Top             =   2640
         Width           =   1695
      End
      Begin VB.TextBox txtReadArray 
         Height          =   375
         Left            =   -69120
         TabIndex        =   60
         Top             =   2640
         Width           =   1815
      End
      Begin VB.CommandButton cmdReadArray 
         Caption         =   "Read IntArray[3]"
         Height          =   375
         Left            =   -70680
         TabIndex        =   59
         Top             =   2640
         Width           =   1455
      End
      Begin VB.CommandButton cmdWriteArray 
         Caption         =   "Write IntArray[3]"
         Height          =   375
         Left            =   -74400
         TabIndex        =   58
         Top             =   2640
         Width           =   1455
      End
      Begin VB.TextBox txtGetData 
         Height          =   375
         Left            =   -71760
         TabIndex        =   56
         Top             =   3240
         Width           =   2535
      End
      Begin VB.CommandButton cmdStopData 
         Caption         =   "StopData"
         Height          =   375
         Left            =   -73080
         TabIndex        =   55
         Top             =   3240
         Width           =   1215
      End
      Begin VB.CommandButton cmdGetData 
         Caption         =   "GetData"
         Height          =   375
         Left            =   -74400
         TabIndex        =   54
         Top             =   3240
         Width           =   1215
      End
      Begin VB.TextBox txtAsyncRead 
         Height          =   375
         Left            =   -69120
         TabIndex        =   53
         Top             =   2040
         Width           =   1815
      End
      Begin VB.CommandButton cmdAsyncRead 
         Caption         =   "Async Read"
         Height          =   375
         Left            =   -70440
         TabIndex        =   52
         Top             =   2040
         Width           =   1215
      End
      Begin VB.TextBox txtAsyncWrite 
         Height          =   375
         Left            =   -72840
         TabIndex        =   51
         Top             =   2040
         Width           =   1695
      End
      Begin VB.CommandButton cmdAsyncWrite 
         Caption         =   "Async Write"
         Height          =   375
         Left            =   -74160
         TabIndex        =   50
         Top             =   2040
         Width           =   1215
      End
      Begin CXOPCCLIENTCOMMUNICATIONSLibCtl.OPCComms OPCComms1 
         Left            =   600
         OleObjectBlob   =   "Main.frx":03CE
         Top             =   4080
      End
      Begin VB.TextBox txtSyncRead 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -69120
         TabIndex        =   49
         Top             =   1440
         Width           =   1815
      End
      Begin VB.TextBox txtSyncWrite 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -72840
         TabIndex        =   48
         ToolTipText     =   "Input a string value and press the 'Write Value' button"
         Top             =   1440
         Width           =   1695
      End
      Begin VB.CommandButton cmdSyncRead 
         Caption         =   "Sync Read"
         Height          =   375
         Left            =   -70440
         TabIndex        =   47
         Top             =   1440
         Width           =   1215
      End
      Begin VB.CommandButton cmdSyncWrite 
         Caption         =   "Sync Write"
         Height          =   375
         Left            =   -74160
         TabIndex        =   46
         Top             =   1440
         Width           =   1215
      End
      Begin VB.TextBox txtNode 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000D&
         Height          =   375
         Left            =   -71760
         TabIndex        =   45
         Top             =   4440
         Width           =   2535
      End
      Begin VB.TextBox txtServer 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000D&
         Height          =   375
         Left            =   -71760
         TabIndex        =   43
         Top             =   4920
         Width           =   4455
      End
      Begin VB.TextBox txtProject 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000D&
         Height          =   375
         Left            =   -71760
         TabIndex        =   41
         Top             =   5400
         Width           =   4455
      End
      Begin VB.TextBox txtName 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000D&
         Height          =   375
         Left            =   -71760
         TabIndex        =   39
         Top             =   3960
         Width           =   2535
      End
      Begin VB.CommandButton cmdProperties 
         Caption         =   "Properties"
         Height          =   375
         Left            =   -74400
         TabIndex        =   38
         Top             =   3840
         Width           =   1215
      End
      Begin VB.TextBox txtSetValue 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -72840
         TabIndex        =   35
         ToolTipText     =   "Input an Integer value and press the 'Set Value' button"
         Top             =   840
         Width           =   1695
      End
      Begin VB.CommandButton cmdSetValue 
         Caption         =   "Set Value"
         Height          =   375
         Left            =   -74160
         TabIndex        =   34
         Top             =   840
         Width           =   1215
      End
      Begin VB.CommandButton cmdGetValue 
         Caption         =   "Get Value"
         Height          =   375
         Left            =   -70440
         TabIndex        =   32
         Top             =   840
         Width           =   1215
      End
      Begin CXLEDLibCtl.LED LED6 
         Height          =   495
         Left            =   -68400
         OleObjectBlob   =   "Main.frx":0466
         TabIndex        =   31
         Top             =   3720
         Width           =   495
      End
      Begin CXLEDLibCtl.LED LED4 
         Height          =   495
         Left            =   -68400
         OleObjectBlob   =   "Main.frx":0502
         TabIndex        =   30
         Top             =   1080
         Width           =   495
      End
      Begin CXLEDLibCtl.LED LED3 
         Height          =   495
         Left            =   -72480
         OleObjectBlob   =   "Main.frx":059E
         TabIndex        =   29
         Top             =   3720
         Width           =   495
      End
      Begin CXLEDLibCtl.LED LED2 
         Height          =   495
         Left            =   -72480
         OleObjectBlob   =   "Main.frx":063A
         TabIndex        =   28
         Top             =   2400
         Width           =   495
      End
      Begin CXTOGGLEBUTTONLibCtl.Toggle Toggle6 
         Height          =   855
         Left            =   -70200
         OleObjectBlob   =   "Main.frx":06D6
         TabIndex        =   27
         Top             =   2160
         Width           =   975
      End
      Begin CXTOGGLEBUTTONLibCtl.Toggle Toggle5 
         Height          =   855
         Left            =   -70200
         OleObjectBlob   =   "Main.frx":07AC
         TabIndex        =   26
         Top             =   840
         Width           =   975
      End
      Begin CXTOGGLEBUTTONLibCtl.Toggle Toggle4 
         Height          =   855
         Left            =   -70200
         OleObjectBlob   =   "Main.frx":0882
         TabIndex        =   25
         Top             =   3480
         Width           =   975
      End
      Begin CXTOGGLEBUTTONLibCtl.Toggle Toggle3 
         Height          =   855
         Left            =   -74040
         OleObjectBlob   =   "Main.frx":0958
         TabIndex        =   24
         Top             =   3480
         Width           =   975
      End
      Begin CXTOGGLEBUTTONLibCtl.Toggle Toggle2 
         Height          =   855
         Left            =   -74040
         OleObjectBlob   =   "Main.frx":0A2E
         TabIndex        =   23
         Top             =   2160
         Width           =   975
      End
      Begin CXLEDLibCtl.LED LED1 
         Height          =   495
         Left            =   -72480
         OleObjectBlob   =   "Main.frx":0B04
         TabIndex        =   22
         Top             =   1080
         Width           =   495
      End
      Begin CXTOGGLEBUTTONLibCtl.Toggle Toggle1 
         Height          =   855
         Left            =   -74040
         OleObjectBlob   =   "Main.frx":0BA0
         TabIndex        =   21
         Top             =   840
         Width           =   975
      End
      Begin VB.Timer Timer1 
         Interval        =   1000
         Left            =   -68400
         Top             =   3000
      End
      Begin CXLINEARGAUGELibCtl.Gauge Gauge6 
         Height          =   1215
         Left            =   -71400
         OleObjectBlob   =   "Main.frx":0C76
         TabIndex        =   20
         Top             =   4440
         Width           =   3975
      End
      Begin CXLINEARGAUGELibCtl.Gauge Gauge5 
         Height          =   1695
         Left            =   -70440
         OleObjectBlob   =   "Main.frx":0D7A
         TabIndex        =   19
         Top             =   2400
         Width           =   1335
      End
      Begin CXLINEARGAUGELibCtl.Gauge Gauge4 
         Height          =   1455
         Left            =   -71400
         OleObjectBlob   =   "Main.frx":0E7E
         TabIndex        =   18
         Top             =   600
         Width           =   3975
      End
      Begin CXROTARYGAUGELibCtl.Gauge Gauge3 
         Height          =   1575
         Left            =   -73920
         OleObjectBlob   =   "Main.frx":0F82
         TabIndex        =   17
         Top             =   4200
         Width           =   1695
      End
      Begin CXROTARYGAUGELibCtl.Gauge Gauge2 
         Height          =   1575
         Left            =   -73920
         OleObjectBlob   =   "Main.frx":109A
         TabIndex        =   16
         Top             =   2400
         Width           =   1695
      End
      Begin CXROTARYGAUGELibCtl.Gauge Gauge1 
         Height          =   1575
         Left            =   -73920
         OleObjectBlob   =   "Main.frx":11B2
         TabIndex        =   15
         Top             =   600
         Width           =   1695
      End
      Begin CXDISPLAYLibCtl.Display Display2 
         Height          =   855
         Left            =   -70920
         OleObjectBlob   =   "Main.frx":12CA
         TabIndex        =   13
         ToolTipText     =   "Item: FLOAT, Border: None, "
         Top             =   3360
         Width           =   2175
      End
      Begin CXKnobLibCtl.Knob Knob2 
         Height          =   1935
         Left            =   -74040
         OleObjectBlob   =   "Main.frx":13EA
         TabIndex        =   12
         ToolTipText     =   "Item: FLOAT, Format: Real, Style: 3D - Sunken, Scale: 0-50 "
         Top             =   2880
         Width           =   2055
      End
      Begin CXDISPLAYLibCtl.Display Display1 
         Height          =   735
         Left            =   -70800
         OleObjectBlob   =   "Main.frx":1500
         TabIndex        =   11
         ToolTipText     =   "Item: LONG2, Border: Single-lines, Leading zeros"
         Top             =   1200
         Width           =   1935
      End
      Begin CXKnobLibCtl.Knob Knob1 
         Height          =   1935
         Left            =   -74040
         OleObjectBlob   =   "Main.frx":1620
         TabIndex        =   10
         ToolTipText     =   "Item: LONG2, Format: Real, Style: 3D - Raised, Scale 0-100"
         Top             =   600
         Width           =   2055
      End
      Begin SS7SEGMENTLibCtl.Segment Segment7 
         Height          =   975
         Left            =   -69840
         OleObjectBlob   =   "Main.frx":172E
         TabIndex        =   8
         ToolTipText     =   "Item: Randon.R8, Format: Hex(6), Style: 3D - Raised, Top Title, No auto fonts"
         Top             =   3720
         Width           =   2175
      End
      Begin SS7SEGMENTLibCtl.Segment Segment6 
         Height          =   855
         Left            =   -69840
         OleObjectBlob   =   "Main.frx":17F6
         TabIndex        =   7
         ToolTipText     =   "Item: Randon.I4, Format: Decimal(6,1), Style: None, Bottom Title, No auto fonts, Hide off segments"
         Top             =   2280
         Width           =   2175
      End
      Begin SS7SEGMENTLibCtl.Segment Segment5 
         Height          =   855
         Left            =   -69840
         OleObjectBlob   =   "Main.frx":18C4
         TabIndex        =   6
         ToolTipText     =   "Item: Randon.I2, Format: Binary, Style: 3D - Sunken, Top Title, No auto fonts"
         Top             =   840
         Width           =   2175
      End
      Begin SS7SEGMENTLibCtl.Segment Segment4 
         Height          =   615
         Left            =   -74400
         OleObjectBlob   =   "Main.frx":198C
         TabIndex        =   5
         ToolTipText     =   "Item: Randon.R4, Format: Decimal (8,1), Style: Single Line, Hide off segments"
         Top             =   4080
         Width           =   2175
      End
      Begin SS7SEGMENTLibCtl.Segment Segment3 
         Height          =   615
         Left            =   -74400
         OleObjectBlob   =   "Main.frx":1A42
         TabIndex        =   4
         ToolTipText     =   "Item: Randon.I4, Format: Hex, Style: 3D - Sunken, No leading 0"
         Top             =   2880
         Width           =   2175
      End
      Begin SS7SEGMENTLibCtl.Segment Segment1 
         Height          =   615
         Left            =   -74400
         OleObjectBlob   =   "Main.frx":1AF8
         TabIndex        =   3
         ToolTipText     =   "Item: Randon.I2, Format: Decimal (6,0), Style: 3D - Raised"
         Top             =   840
         Width           =   2175
      End
      Begin VB.CommandButton cmdExit 
         Caption         =   "&Exit"
         Height          =   375
         Left            =   3720
         TabIndex        =   1
         Top             =   5520
         Width           =   975
      End
      Begin SS7SEGMENTLibCtl.Segment Segment2 
         Height          =   615
         Left            =   -74400
         OleObjectBlob   =   "Main.frx":1BAE
         TabIndex        =   2
         ToolTipText     =   "Item: Randon.R8, Format: Decimal (8,2), Style: None"
         Top             =   1920
         Width           =   2175
      End
      Begin CXLEDLibCtl.LED LED5 
         Height          =   495
         Left            =   -68400
         OleObjectBlob   =   "Main.frx":1C64
         TabIndex        =   57
         Top             =   2400
         Width           =   495
      End
      Begin VB.Label lblNode 
         Caption         =   "Node:"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -72600
         TabIndex        =   44
         Top             =   4440
         Width           =   615
      End
      Begin VB.Label Label3 
         Caption         =   "Server:"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -72600
         TabIndex        =   42
         Top             =   4920
         Width           =   735
      End
      Begin VB.Label lblProject 
         Caption         =   "Project:"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -72600
         TabIndex        =   40
         Top             =   5400
         Width           =   735
      End
      Begin VB.Label lblName 
         Caption         =   "Name:"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -72600
         TabIndex        =   37
         Top             =   3960
         Width           =   615
      End
      Begin VB.Label lblTitle 
         AutoSize        =   -1  'True
         BackColor       =   &H80000001&
         BackStyle       =   0  'Transparent
         Caption         =   "Test Application"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   14.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   330
         Left            =   1320
         TabIndex        =   36
         Top             =   3240
         Width           =   2250
      End
      Begin VB.Image Image1 
         Height          =   4755
         Left            =   240
         Picture         =   "Main.frx":1D00
         Top             =   600
         Width           =   7800
      End
      Begin VB.Label lblGetValue 
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   -69120
         TabIndex        =   33
         Top             =   840
         Width           =   1815
      End
      Begin VB.Label Label2 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         Caption         =   $"Main.frx":2A52A
         ForeColor       =   &H80000008&
         Height          =   735
         Left            =   -74040
         TabIndex        =   14
         Top             =   5160
         Width           =   6255
      End
      Begin VB.Label Label1 
         Appearance      =   0  'Flat
         BackColor       =   &H80000005&
         BorderStyle     =   1  'Fixed Single
         Caption         =   $"Main.frx":2A5E4
         ForeColor       =   &H80000008&
         Height          =   735
         Left            =   -74400
         TabIndex        =   9
         Top             =   5160
         Width           =   6735
      End
   End
End
Attribute VB_Name = "MainForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Dim nTimer As Integer

Private Sub cmdAsyncRead_Click()
    OPCComms1.Read "ScriptGrp", "Text3", ReadFromDeviceAsync
End Sub

Private Sub cmdAsyncWrite_Click()
    Dim sValue As Variant
    sValue = txtAsyncWrite.Text
    OPCComms1.Write "ScriptGrp", "Text3", sValue, NoWaiting
End Sub

Private Sub cmdExit_Click()
    Unload MainForm
    End
End Sub

Private Sub cmdGetData_Click()
    OPCComms1.GetData "ScriptGrp", "Integer2"
End Sub

Private Sub cmdGetValue_Click()
    Dim sValue As Variant
    sValue = OPCComms1.Value("ScriptGrp", "Text1")
    lblGetValue.Caption = sValue
End Sub

Private Sub cmdProperties_Click()
    Dim sName As String
    txtName.Text = OPCComms1.Name
    txtNode.Text = OPCComms1.ServerComputerName
    txtServer.Text = OPCComms1.ServerName
    txtProject.Text = OPCComms1.ProjectName
End Sub

Private Sub cmdReadArray_Click()
    Dim sValue As Variant
    sValue = OPCComms1.Read("ScriptGrp", "IntArray[3]", ReadFromDevice)
    txtReadArray.Text = sValue
End Sub

Private Sub cmdSetValue_Click()
    Dim sValue As String
    sValue = txtSetValue.Text
    OPCComms1.Value("ScriptGrp", "Text1") = sValue
End Sub

Private Sub cmdStopData_Click()
    OPCComms1.StopData "ScriptGrp", "Integer2"
End Sub
Private Sub cmdSyncRead_Click()
    Dim sValue As Variant
    sValue = OPCComms1.Read("ScriptGrp", "Text2")
    txtSyncRead.Text = sValue
End Sub

Private Sub cmdSyncWrite_Click()
    Dim sValue As Variant
    sValue = txtSyncWrite.Text
    OPCComms1.Write "ScriptGrp", "Text2", sValue
End Sub

Private Sub cmdWriteArray_Click()
    Dim sValue As Variant
    sValue = txtWriteArray.Text
    OPCComms1.Write "ScriptGrp", "IntArray[3]", sValue
End Sub

Private Sub Form_Load()
    Timer1.Enabled = False
    Dim X
    Dim msg As String
    Dim CurrentFolder As String
        
    CurrentFolder = App.Path
    OPCComms1.ServerName = "OMRON.OpenDataServer.1"
    
    msg = "This application will automatically configure the server to use VBOD.cdm." & vbCrLf
    msg = msg & "Is this acceptable?"

    Dim style
    style = vbYesNo + vbApplicationModal + vbQuestion
    
    X = MsgBox(msg, style, "CX-Server OPC Example")
   
    If X = VbMsgBoxResult.vbNo Then
        MsgBox "This demo will exit", vbYesNo & vbInformation, "CX-Server OPC Example"
        Unload Me
    Else
        OPCComms1.ServerProjectName = CurrentFolder & "\VBOD.cdm"
        OPCComms1.ProjectName = CurrentFolder & "\ODOPC.opc"
        
        OPCComms1.ConnectToServer (True)
        
        Timer1.Enabled = True
    
        Segment1.GroupOrPLCName = "SegmentGrp"
        Segment1.ItemName = "Integer1"
        Segment1.CommsServerName = "OPCComms1"
        
        Segment2.GroupOrPLCName = "SegmentGrp"
        Segment2.ItemName = "Integer1"
        Segment2.CommsServerName = "OPCComms1"
        
        Segment3.GroupOrPLCName = "SegmentGrp"
        Segment3.ItemName = "Integer1"
        Segment3.CommsServerName = "OPCComms1"
        
        Segment4.GroupOrPLCName = "SegmentGrp"
        Segment4.ItemName = "Integer1"
        Segment4.CommsServerName = "OPCComms1"
        
        Segment5.GroupOrPLCName = "SegmentGrp"
        Segment5.ItemName = "Integer1"
        Segment5.CommsServerName = "OPCComms1"
        
        Segment6.GroupOrPLCName = "SegmentGrp"
        Segment6.ItemName = "Integer1"
        Segment6.CommsServerName = "OPCComms1"
        
        Segment7.GroupOrPLCName = "SegmentGrp"
        Segment7.ItemName = "Integer1"
        Segment7.CommsServerName = "OPCComms1"
        
        Knob1.GroupOrPLCName = "KnobGrp"
        Knob1.ItemName = "Real1"
        Knob1.CommsServerName = "OPCComms1"
        
        Knob2.GroupOrPLCName = "KnobGrp"
        Knob2.ItemName = "Real2"
        Knob2.CommsServerName = "OPCComms1"
        
        Display1.GroupOrPLCName = "KnobGrp"
        Display1.ItemName = "Real1"
        Display1.CommsServerName = "OPCComms1"
        
        Display2.GroupOrPLCName = "KnobGrp"
        Display2.ItemName = "Real2"
        Display2.CommsServerName = "OPCComms1"
        
        Gauge1.GroupOrPLCName = "GaugeGrp"
        Gauge1.ItemName = "Integer3"
        Gauge1.CommsServerName = "OPCComms1"
        
        Gauge2.GroupOrPLCName = "GaugeGrp"
        Gauge2.ItemName = "Integer3"
        Gauge2.CommsServerName = "OPCComms1"
        
        Gauge3.GroupOrPLCName = "GaugeGrp"
        Gauge3.ItemName = "Integer3"
        Gauge3.CommsServerName = "OPCComms1"
        
        Gauge4.GroupOrPLCName = "GaugeGrp"
        Gauge4.ItemName = "Integer3"
        Gauge4.CommsServerName = "OPCComms1"
        
        Gauge5.GroupOrPLCName = "GaugeGrp"
        Gauge5.ItemName = "Integer3"
        Gauge5.CommsServerName = "OPCComms1"
        
        Gauge6.GroupOrPLCName = "GaugeGrp"
        Gauge6.ItemName = "Integer3"
        Gauge6.CommsServerName = "OPCComms1"
        
        Toggle1.GroupOrPLCName = "ToggleGrp"
        Toggle1.ItemName = "Bool1"
        Toggle1.CommsServerName = "OPCComms1"
        
        Toggle2.GroupOrPLCName = "ToggleGrp"
        Toggle2.ItemName = "Bool1"
        Toggle2.CommsServerName = "OPCComms1"
        
        Toggle3.GroupOrPLCName = "ToggleGrp"
        Toggle3.ItemName = "Bool1"
        Toggle3.CommsServerName = "OPCComms1"
        
        Toggle4.GroupOrPLCName = "ToggleGrp"
        Toggle4.ItemName = "Bool1"
        Toggle4.CommsServerName = "OPCComms1"
        
        Toggle5.GroupOrPLCName = "ToggleGrp"
        Toggle5.ItemName = "Bool1"
        Toggle5.CommsServerName = "OPCComms1"
        
        Toggle6.GroupOrPLCName = "ToggleGrp"
        Toggle6.ItemName = "Bool1"
        Toggle6.CommsServerName = "OPCComms1"
        
        LED1.GroupOrPLCName = "ToggleGrp"
        LED1.ItemName = "Bool1"
        LED1.CommsServerName = "OPCComms1"
        
        LED2.GroupOrPLCName = "ToggleGrp"
        LED2.ItemName = "Bool1"
        LED2.CommsServerName = "OPCComms1"
        
        LED3.GroupOrPLCName = "ToggleGrp"
        LED3.ItemName = "Bool1"
        LED3.CommsServerName = "OPCComms1"
        
        LED4.GroupOrPLCName = "ToggleGrp"
        LED4.ItemName = "Bool1"
        LED4.CommsServerName = "OPCComms1"
        
        LED5.GroupOrPLCName = "ToggleGrp"
        LED5.ItemName = "Bool1"
        LED5.CommsServerName = "OPCComms1"
        
        LED6.GroupOrPLCName = "ToggleGrp"
        LED6.ItemName = "Bool1"
        LED6.CommsServerName = "OPCComms1"
        
        nTimer = 1000
    End If
    
End Sub

Private Sub OPCComms1_OnData(ByVal Group As String, ByVal Item As String, ByVal Value As Variant, ByVal BadQuality As Boolean)
    If Group = "ScriptGrp" And Item = "Text3" Then
        txtAsyncRead.Text = Value
    End If
    
    If Group = "ScriptGrp" And Item = "Integer2" Then
        txtGetData.Text = Value
    End If
End Sub

Private Sub Timer1_Timer()
    nTimer = nTimer + 1
    If nTimer > 100 Then
        nTimer = 0
    End If
    OPCComms1.Value("SegmentGrp", "Integer1") = nTimer
    OPCComms1.Value("ScriptGrp", "Integer2") = nTimer
    OPCComms1.Value("GaugeGrp", "Integer3") = nTimer
End Sub

