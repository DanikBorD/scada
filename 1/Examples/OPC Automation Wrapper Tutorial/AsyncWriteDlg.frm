VERSION 5.00
Begin VB.Form AsyncWriteDlg 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Async Write"
   ClientHeight    =   1305
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   4485
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1305
   ScaleWidth      =   4485
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox txtValue 
      Height          =   345
      Left            =   1185
      TabIndex        =   5
      Top             =   735
      Width           =   1620
   End
   Begin VB.TextBox txtName 
      Enabled         =   0   'False
      Height          =   330
      Left            =   1200
      TabIndex        =   3
      Top             =   180
      Width           =   1590
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   3135
      TabIndex        =   1
      Top             =   690
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Height          =   375
      Left            =   3135
      TabIndex        =   0
      Top             =   165
      Width           =   1215
   End
   Begin VB.Label Label2 
      Caption         =   "New Value:"
      Height          =   330
      Left            =   105
      TabIndex        =   4
      Top             =   810
      Width           =   990
   End
   Begin VB.Label Label1 
      Caption         =   "Item :"
      Height          =   345
      Left            =   135
      TabIndex        =   2
      Top             =   255
      Width           =   675
   End
End
Attribute VB_Name = "AsyncWriteDlg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Public bOK As Boolean

Private Sub CancelButton_Click()
    bOK = False
    Hide
End Sub


Private Sub OKButton_Click()
    bOK = True
    Hide
End Sub
