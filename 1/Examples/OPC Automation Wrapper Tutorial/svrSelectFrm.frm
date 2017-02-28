VERSION 5.00
Begin VB.Form svrSelectDlg 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Select OPC Server"
   ClientHeight    =   2400
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3990
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2400
   ScaleWidth      =   3990
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox lstServers 
      Height          =   1035
      Left            =   120
      TabIndex        =   5
      Top             =   1200
      Width           =   2175
   End
   Begin VB.CommandButton cmdBrowse 
      Caption         =   "Browse..."
      Height          =   375
      Left            =   2760
      TabIndex        =   4
      Top             =   1560
      Width           =   1095
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   2760
      TabIndex        =   3
      Top             =   840
      Width           =   1095
   End
   Begin VB.CommandButton cmd_OK 
      Caption         =   "OK"
      Height          =   375
      Left            =   2760
      TabIndex        =   2
      Top             =   360
      Width           =   1095
   End
   Begin VB.TextBox txtServer 
      Enabled         =   0   'False
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   360
      Width           =   2175
   End
   Begin VB.Label Label2 
      Caption         =   "Available Servers:"
      Height          =   255
      Left            =   120
      TabIndex        =   6
      Top             =   840
      Width           =   1935
   End
   Begin VB.Label Label1 
      Caption         =   "OPC Server:"
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2055
   End
End
Attribute VB_Name = "svrSelectDlg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmd_OK_Click()
    theServer.Connect (lstServers.List(lstServers.ListIndex))
    Unload Me
End Sub

Private Sub cmdCancel_Click()
    Set theServer = Nothing
    Unload Me
End Sub


Private Sub Form_Load()
    Dim ServerNames As Variant
    Dim i As Integer
    Set theServer = New OPCServer
    ServerNames = theServer.GetOPCServers
    For i = LBound(ServerNames) To UBound(ServerNames)
        lstServers.AddItem ServerNames(i)
    Next
    lstServers.ListIndex = 0
    txtServer.Text = lstServers.List(0)
End Sub


Private Sub lstServers_Click()
    txtServer.Text = lstServers.List(lstServers.ListIndex)
End Sub
