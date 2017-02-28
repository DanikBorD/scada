VERSION 5.00
Begin VB.Form BrowseDlg 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Add Items"
   ClientHeight    =   4800
   ClientLeft      =   2760
   ClientTop       =   3750
   ClientWidth     =   6210
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4800
   ScaleWidth      =   6210
   ShowInTaskbar   =   0   'False
   Begin VB.TextBox Text3 
      Height          =   300
      Left            =   3510
      TabIndex        =   17
      Top             =   3435
      Width           =   1350
   End
   Begin VB.CommandButton cmdAdd 
      Caption         =   "Add Item"
      Height          =   375
      Left            =   4800
      TabIndex        =   14
      Top             =   1080
      Width           =   1215
   End
   Begin VB.Frame Frame2 
      Caption         =   "Attributes"
      Height          =   1890
      Left            =   2400
      TabIndex        =   13
      Top             =   2805
      Width           =   3285
      Begin VB.TextBox txtType 
         Enabled         =   0   'False
         Height          =   285
         Left            =   1410
         TabIndex        =   21
         Top             =   1440
         Width           =   1740
      End
      Begin VB.CheckBox chkActive 
         Alignment       =   1  'Right Justify
         Caption         =   "Active"
         Height          =   285
         Left            =   135
         TabIndex        =   19
         Top             =   1065
         Value           =   1  'Checked
         Width           =   1155
      End
      Begin VB.TextBox txtName 
         Height          =   300
         Left            =   1110
         TabIndex        =   16
         Top             =   240
         Width           =   1335
      End
      Begin VB.Label Label7 
         Caption         =   "Canonical Type"
         Height          =   270
         Left            =   135
         TabIndex        =   20
         Top             =   1470
         Width           =   1275
      End
      Begin VB.Label Label6 
         Caption         =   "Access Path"
         Height          =   360
         Left            =   135
         TabIndex        =   18
         Top             =   660
         Width           =   1155
      End
      Begin VB.Label Label5 
         Caption         =   "Item Name "
         Height          =   270
         Left            =   135
         TabIndex        =   15
         Top             =   270
         Width           =   855
      End
   End
   Begin VB.ListBox lstAdd 
      Height          =   1815
      Left            =   120
      TabIndex        =   11
      Top             =   2880
      Width           =   2055
   End
   Begin VB.Frame Frame1 
      Caption         =   "Browse Options"
      Height          =   735
      Left            =   120
      TabIndex        =   4
      Top             =   1680
      Width           =   6015
      Begin VB.ComboBox cmbBrowseAccess 
         Height          =   315
         Left            =   4575
         TabIndex        =   10
         Top             =   240
         Width           =   1335
      End
      Begin VB.TextBox txtFilter 
         Height          =   285
         Left            =   2745
         TabIndex        =   8
         Text            =   "*"
         Top             =   255
         Width           =   870
      End
      Begin VB.ComboBox cmbBrowseType 
         Height          =   315
         IntegralHeight  =   0   'False
         ItemData        =   "BrowseDlg.frx":0000
         Left            =   915
         List            =   "BrowseDlg.frx":0002
         TabIndex        =   5
         Top             =   240
         Width           =   1215
      End
      Begin VB.Label Label3 
         Caption         =   "Access:"
         Height          =   255
         Left            =   3855
         TabIndex        =   9
         Top             =   270
         Width           =   630
      End
      Begin VB.Label Label2 
         Caption         =   "Filter:"
         Height          =   255
         Left            =   2220
         TabIndex        =   7
         Top             =   255
         Width           =   495
      End
      Begin VB.Label Label1 
         Caption         =   "DataType:"
         Height          =   255
         Left            =   90
         TabIndex        =   6
         Top             =   240
         Width           =   855
      End
   End
   Begin VB.ListBox lstBranch 
      Height          =   1425
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   1935
   End
   Begin VB.ListBox lstLeaf 
      Height          =   1425
      Left            =   2400
      TabIndex        =   2
      Top             =   120
      Width           =   2175
   End
   Begin VB.CommandButton CancelButton 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   4800
      TabIndex        =   1
      Top             =   600
      Width           =   1215
   End
   Begin VB.CommandButton OKButton 
      Caption         =   "OK"
      Height          =   375
      Left            =   4800
      TabIndex        =   0
      Top             =   120
      Width           =   1215
   End
   Begin VB.Label Label4 
      Caption         =   "Items Added:"
      Height          =   255
      Left            =   105
      TabIndex        =   12
      Top             =   2550
      Width           =   1455
   End
End
Attribute VB_Name = "BrowseDlg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Dim theBrowser As OPCBrowser

Public theGroup As OPCGroup
Dim errors() As Long

Private Sub CancelButton_Click()
    Set theBrowser = Nothing
    Dim i As Integer
    Dim handles() As Long
    Dim errors() As Long
    'need to remove any items added to group here if there are any
    If lstAdd.ListCount > 0 Then
        ReDim handles(lstAdd.ListCount)
        For i = 1 To lstAdd.ListCount
            handles(i) = CLng(lstAdd.ItemData(i - 1))
        Next
        theGroup.OPCItems.Remove lstAdd.ListCount, handles, errors
    End If
    Unload Me
End Sub

Private Sub chkActive_Click()
    Dim theItem As OPCItem
    Dim handle As Long
    If lstAdd.ListIndex >= 0 Then
        handle = lstAdd.ItemData(lstAdd.ListIndex)
        Set theItem = theGroup.OPCItems.GetOPCItem(handle)
        theItem.IsActive = chkActive.Value
    End If
End Sub

Private Sub cmbBrowseAccess_Click()
    theBrowser.AccessRights = cmbBrowseAccess.ItemData(cmbBrowseAccess.ListIndex)
    PopulateLeaf (lstBranch.List(lstBranch.ListIndex))
End Sub

Private Sub cmbBrowseType_Click()
    theBrowser.DataType = cmbBrowseType.ItemData(cmbBrowseType.ListIndex)
    PopulateLeaf (lstBranch.List(lstBranch.ListIndex))
End Sub

Private Sub cmdAdd_Click()
    Dim theItem As OPCItem
    Dim name As String
    Dim errors() As Long
    Dim handles(1) As Long
    name = lstLeaf.List(lstLeaf.ListIndex)
    If (name <> "") Then
        Set theItem = theGroup.OPCItems.AddItem(name, currentHandle)
        If theItem.CanonicalDataType > vbArray Then
            MsgBox "Arrays are not supported by this tutorial application"
            handles(1) = theItem.ServerHandle
            theGroup.OPCItems.Remove 1, handles, errors
        Else
            lstAdd.AddItem (name)
            lstAdd.ItemData(lstAdd.ListCount - 1) = theItem.ServerHandle
            currentHandle = currentHandle + 1
        End If
    End If
    
End Sub

Private Sub Form_Load()
    Set theBrowser = theServer.CreateBrowser
    theBrowser.MoveToRoot
    theBrowser.ShowBranches
    PopulateBranch
    lstBranch.ListIndex = 0
    InitTypeCombo
    InitAccessCombo
    PopulateLeaf (lstBranch.List(0))
End Sub


Private Sub PopulateBranch()
    Dim i As Integer
    Dim name As String
    For i = 1 To theBrowser.Count
        name = theBrowser.Item(i)
        lstBranch.AddItem (name)
    Next
End Sub

Private Sub PopulateLeaf(branch As String)
Dim i As Integer
Dim name As String
    lstLeaf.Clear
    On Error GoTo EndRoutine
    theBrowser.MoveDown (branch)
    theBrowser.ShowLeafs
    For i = 1 To theBrowser.Count
        name = theBrowser.Item(i)
        lstLeaf.AddItem (name)
    Next
EndRoutine:
    theBrowser.MoveUp
End Sub

Private Sub lstAdd_Click()
    Dim theItem As OPCItem
    Dim handle As Long
    Dim CanonicalType As Integer
    handle = lstAdd.ItemData(lstAdd.ListIndex)
    Set theItem = theGroup.OPCItems.GetOPCItem(handle)
    txtName = theItem.ItemID
    chkActive.Value = CInt(theItem.IsActive) * -1
    txtType.Text = GetCanonicalType(theItem.CanonicalDataType)
End Sub

Private Sub lstBranch_Click()
    Dim name As String
    name = lstBranch.List(lstBranch.ListIndex)
    PopulateLeaf (name)
    
End Sub

Private Sub OKButton_Click()
    Set theBrowser = Nothing
    Unload Me
End Sub

Private Sub InitTypeCombo()
    cmbBrowseType.Clear
    cmbBrowseType.AddItem "Native"
    cmbBrowseType.ItemData(cmbBrowseType.ListCount - 1) = vbEmpty
    cmbBrowseType.AddItem "Short"
    cmbBrowseType.ItemData(cmbBrowseType.ListCount - 1) = vbInteger
    cmbBrowseType.AddItem "Long"
    cmbBrowseType.ItemData(cmbBrowseType.ListCount - 1) = vbLong
    cmbBrowseType.AddItem "Float"
    cmbBrowseType.ItemData(cmbBrowseType.ListCount - 1) = vbSingle
    cmbBrowseType.AddItem "Double"
    cmbBrowseType.ItemData(cmbBrowseType.ListCount - 1) = vbDouble
    cmbBrowseType.AddItem "String"
    cmbBrowseType.ItemData(cmbBrowseType.ListCount - 1) = vbString
    cmbBrowseType.AddItem "Boolean"
    cmbBrowseType.ItemData(cmbBrowseType.ListCount - 1) = vbBoolean
    cmbBrowseType.AddItem "Byte"
    cmbBrowseType.ItemData(cmbBrowseType.ListCount - 1) = vbByte
    cmbBrowseType.ListIndex = 0
End Sub

Private Sub InitAccessCombo()
    cmbBrowseAccess.Clear
    cmbBrowseAccess.AddItem "Read/Write"
    cmbBrowseAccess.ItemData(cmbBrowseAccess.ListCount - 1) = OPCReadable Or OPCWritable
    cmbBrowseAccess.AddItem "Read"
    cmbBrowseAccess.ItemData(cmbBrowseAccess.ListCount - 1) = OPCReadable
    cmbBrowseAccess.AddItem "Write"
    cmbBrowseAccess.ItemData(cmbBrowseAccess.ListCount - 1) = OPCWritable
    cmbBrowseAccess.ListIndex = 0
End Sub


Private Sub txtFilter_Change()
    theBrowser.Filter = txtFilter.Text
    PopulateLeaf (lstBranch.List(lstBranch.ListIndex))
End Sub


