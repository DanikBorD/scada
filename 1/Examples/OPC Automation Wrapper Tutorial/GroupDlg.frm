VERSION 5.00
Begin VB.Form GroupDlg 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Group"
   ClientHeight    =   2880
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   4320
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2880
   ScaleWidth      =   4320
   ShowInTaskbar   =   0   'False
   Begin VB.CheckBox chkSubscribe 
      Caption         =   "Subscribed"
      Height          =   270
      Left            =   1575
      TabIndex        =   11
      Top             =   2535
      Value           =   1  'Checked
      Width           =   1590
   End
   Begin VB.CheckBox chkActive 
      Caption         =   "Active"
      Height          =   255
      Left            =   240
      TabIndex        =   10
      Top             =   2535
      Value           =   1  'Checked
      Width           =   1215
   End
   Begin VB.TextBox txtDeadband 
      Height          =   375
      Left            =   1920
      TabIndex        =   9
      Text            =   "1"
      Top             =   2040
      Width           =   720
   End
   Begin VB.TextBox txtTimeBias 
      Height          =   375
      Left            =   1920
      TabIndex        =   7
      Text            =   "0"
      Top             =   1440
      Width           =   705
   End
   Begin VB.TextBox txtRate 
      Height          =   375
      Left            =   1920
      TabIndex        =   4
      Text            =   "1000"
      Top             =   840
      Width           =   690
   End
   Begin VB.TextBox txtName 
      Height          =   375
      Left            =   1035
      TabIndex        =   3
      Top             =   240
      Width           =   1575
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   2970
      TabIndex        =   1
      Top             =   720
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Height          =   375
      Left            =   2955
      TabIndex        =   0
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Label4 
      Caption         =   "% Deadband"
      Height          =   255
      Left            =   600
      TabIndex        =   8
      Top             =   2040
      Width           =   1095
   End
   Begin VB.Label Label3 
      Caption         =   "Time Bias"
      Height          =   255
      Left            =   840
      TabIndex        =   6
      Top             =   1560
      Width           =   855
   End
   Begin VB.Label Label2 
      Caption         =   "Update Rate (ms)"
      Height          =   255
      Left            =   240
      TabIndex        =   5
      Top             =   960
      Width           =   1575
   End
   Begin VB.Label Label1 
      Caption         =   "Name"
      Height          =   255
      Left            =   255
      TabIndex        =   2
      Top             =   330
      Width           =   615
   End
End
Attribute VB_Name = "GroupDlg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Public theGroup As OPCGroup
Private Sub CancelButton_Click()
    Set theGroup = Nothing
    Unload Me
End Sub

Private Sub Form_Load()
    If Not theGroup Is Nothing Then
        txtName = theGroup.name
        txtRate = theGroup.UpdateRate
        txtDeadband = theGroup.DeadBand
        txtTimeBias = theGroup.TimeBias
        chkActive.Value = CInt(theGroup.IsActive) * -1
        chkSubscribe.Value = CInt(theGroup.IsSubscribed) * -1
    End If
        
End Sub

Private Sub OKButton_Click()
    If theGroups Is Nothing Then
        Set theGroups = theServer.OPCGroups
    End If
    If theGroup Is Nothing Then
        Set theGroup = theGroups.Add(txtName.Text)
        txtName = theGroup.name
    End If
    theGroup.name = txtName
    theGroup.UpdateRate = CLng(txtRate)
    theGroup.DeadBand = CLng(txtDeadband)
    theGroup.TimeBias = CLng(txtTimeBias)
    theGroup.IsActive = CBool(chkActive.Value)
    theGroup.IsSubscribed = CBool(chkSubscribe.Value)
    Unload Me
End Sub
