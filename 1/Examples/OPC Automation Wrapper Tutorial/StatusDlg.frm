VERSION 5.00
Begin VB.Form StatusDlg 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Server Status"
   ClientHeight    =   3915
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   5910
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3915
   ScaleWidth      =   5910
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox txtLast 
      BackColor       =   &H80000004&
      Height          =   375
      Left            =   2160
      TabIndex        =   12
      Top             =   3240
      Width           =   1935
   End
   Begin VB.TextBox txtCurrent 
      BackColor       =   &H80000004&
      Height          =   375
      Left            =   2160
      TabIndex        =   11
      Top             =   2640
      Width           =   1935
   End
   Begin VB.TextBox txtStartTime 
      BackColor       =   &H80000004&
      Height          =   375
      Left            =   2160
      TabIndex        =   10
      Top             =   2040
      Width           =   1935
   End
   Begin VB.TextBox txtState 
      BackColor       =   &H80000004&
      Height          =   375
      Left            =   2160
      TabIndex        =   9
      Top             =   1440
      Width           =   1935
   End
   Begin VB.TextBox txtVersion 
      BackColor       =   &H80000004&
      Height          =   375
      Left            =   2160
      TabIndex        =   8
      Top             =   840
      Width           =   1935
   End
   Begin VB.TextBox txtVendor 
      BackColor       =   &H80000004&
      Height          =   375
      Left            =   2160
      TabIndex        =   7
      Top             =   240
      Width           =   1935
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Height          =   375
      Left            =   4440
      TabIndex        =   0
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Label5 
      Caption         =   "Last Update Time"
      Height          =   255
      Left            =   360
      TabIndex        =   6
      Top             =   3360
      Width           =   1455
   End
   Begin VB.Label Label4 
      Caption         =   "Current Time"
      Height          =   255
      Left            =   360
      TabIndex        =   5
      Top             =   2760
      Width           =   1335
   End
   Begin VB.Label txtStart 
      Caption         =   "Start Time"
      Height          =   375
      Left            =   360
      TabIndex        =   4
      Top             =   2160
      Width           =   1095
   End
   Begin VB.Label Label2 
      Caption         =   "State"
      Height          =   255
      Left            =   360
      TabIndex        =   3
      Top             =   1560
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "Version"
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   960
      Width           =   1455
   End
   Begin VB.Label dlgStatus 
      Caption         =   "Vendor Info"
      Height          =   255
      Left            =   360
      TabIndex        =   1
      Top             =   360
      Width           =   1095
   End
End
Attribute VB_Name = "StatusDlg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit

Private Sub Form_Load()
    Dim theStates As Variant
    theStates = Array("Disconnected", "Running", "Failed", "No Configuration", _
     "Suspended", "In Test")
    txtVendor = theServer.VendorInfo
    txtVersion = theServer.MajorVersion & "." & theServer.MinorVersion
    txtState = theStates(theServer.ServerState)
    txtStartTime = theServer.StartTime
    txtCurrent = theServer.CurrentTime
    txtLast = theServer.LastUpdateTime
End Sub

Private Sub OKButton_Click()
    Unload Me
End Sub
