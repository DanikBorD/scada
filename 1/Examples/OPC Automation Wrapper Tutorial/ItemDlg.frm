VERSION 5.00
Begin VB.Form ItemDlg 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Item"
   ClientHeight    =   3240
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   5250
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3240
   ScaleWidth      =   5250
   ShowInTaskbar   =   0   'False
   Begin VB.CheckBox chkCache 
      Caption         =   "Cache"
      Height          =   345
      Left            =   4185
      TabIndex        =   11
      Top             =   1815
      Width           =   795
   End
   Begin VB.TextBox txtWriteVal 
      Height          =   375
      Left            =   2985
      TabIndex        =   10
      Top             =   2565
      Width           =   1845
   End
   Begin VB.CommandButton cmdWrite 
      Caption         =   "Write"
      Height          =   360
      Left            =   420
      TabIndex        =   9
      Top             =   2580
      Width           =   1200
   End
   Begin VB.TextBox txtReadVal 
      Enabled         =   0   'False
      Height          =   375
      Left            =   2160
      TabIndex        =   8
      Top             =   1785
      Width           =   1830
   End
   Begin VB.CommandButton cmdRead 
      Caption         =   "Read"
      Height          =   360
      Left            =   435
      TabIndex        =   7
      Top             =   1845
      Width           =   1230
   End
   Begin VB.TextBox txtType 
      Enabled         =   0   'False
      Height          =   360
      Left            =   1560
      TabIndex        =   6
      Top             =   750
      Width           =   1830
   End
   Begin VB.TextBox txtName 
      Enabled         =   0   'False
      Height          =   375
      Left            =   945
      TabIndex        =   5
      Top             =   210
      Width           =   1890
   End
   Begin VB.CheckBox chkActive 
      Caption         =   "Active"
      Height          =   315
      Left            =   270
      TabIndex        =   4
      Top             =   1200
      Width           =   1275
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3915
      TabIndex        =   1
      Top             =   600
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Height          =   375
      Left            =   3900
      TabIndex        =   0
      Top             =   135
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Write"
      Height          =   735
      Left            =   210
      TabIndex        =   12
      Top             =   2340
      Width           =   4920
      Begin VB.Label Label3 
         Caption         =   "New Value :"
         Height          =   300
         Left            =   1575
         TabIndex        =   13
         Top             =   300
         Width           =   1065
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "Read"
      Height          =   750
      Left            =   210
      TabIndex        =   14
      Top             =   1560
      Width           =   4920
   End
   Begin VB.Label Label2 
      Caption         =   "Canonical Type"
      Height          =   330
      Left            =   210
      TabIndex        =   3
      Top             =   780
      Width           =   1230
   End
   Begin VB.Label Label1 
      Caption         =   "Name :"
      Height          =   300
      Left            =   240
      TabIndex        =   2
      Top             =   255
      Width           =   1575
   End
End
Attribute VB_Name = "ItemDlg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Public theItem As OPCItem


Private Sub CancelButton_Click()
    Unload Me
End Sub

Private Sub cmdRead_Click()
    Dim source As OPCDataSource
    Dim Value As Variant
    If chkCache.Value = 1 Then
        source = OPCDataSource.OPCCache
    Else
        source = OPCDataSource.OPCDevice
    End If
    theItem.Read source, Value
    txtReadVal.Text = Value
End Sub

Private Sub cmdWrite_Click()
    theItem.Write (txtWriteVal)
End Sub

Private Sub Form_Load()
    If Not theItem Is Nothing Then
        txtName = theItem.ItemID
        txtType = GetCanonicalType(theItem.CanonicalDataType)
        chkActive.Value = CInt(theItem.IsActive) * -1
    End If
End Sub

Private Sub OKButton_Click()
    If Not theItem Is Nothing Then
        theItem.IsActive = CBool(chkActive.Value)
    End If
    Unload Me
End Sub

