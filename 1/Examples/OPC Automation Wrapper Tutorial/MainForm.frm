VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "Mscomctl.ocx"
Begin VB.Form MainForm 
   Caption         =   "Omron OPC Client Example"
   ClientHeight    =   6825
   ClientLeft      =   165
   ClientTop       =   735
   ClientWidth     =   10440
   LinkTopic       =   "Form1"
   ScaleHeight     =   6825
   ScaleWidth      =   10440
   StartUpPosition =   3  'Windows Default
   Begin VB.TextBox txtMsg 
      Height          =   345
      Left            =   3015
      TabIndex        =   2
      Top             =   6210
      Width           =   7215
   End
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   120
      Top             =   6120
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      ImageWidth      =   16
      ImageHeight     =   16
      MaskColor       =   12632256
      _Version        =   393216
      BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
         NumListImages   =   3
         BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MainForm.frx":0000
            Key             =   "Group"
         EndProperty
         BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MainForm.frx":0112
            Key             =   "oGroup"
         EndProperty
         BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
            Picture         =   "MainForm.frx":0264
            Key             =   "Item"
         EndProperty
      EndProperty
   End
   Begin MSComctlLib.ListView listItems 
      Height          =   5775
      Left            =   3000
      TabIndex        =   1
      Top             =   120
      Width           =   7335
      _ExtentX        =   12938
      _ExtentY        =   10186
      View            =   3
      LabelWrap       =   -1  'True
      HideSelection   =   -1  'True
      _Version        =   393217
      Icons           =   "ImageList1"
      ForeColor       =   -2147483640
      BackColor       =   -2147483643
      BorderStyle     =   1
      Appearance      =   1
      NumItems        =   4
      BeginProperty ColumnHeader(1) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         Key             =   "Item"
         Text            =   "Item"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(2) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   1
         Key             =   "Value"
         Text            =   "Value"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(3) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   2
         Key             =   "Quality"
         Text            =   "Quality"
         Object.Width           =   2540
      EndProperty
      BeginProperty ColumnHeader(4) {BDD1F052-858B-11D1-B16A-00C0F0283628} 
         SubItemIndex    =   3
         Key             =   "TimeStamp"
         Text            =   "TimeStamp"
         Object.Width           =   2540
      EndProperty
   End
   Begin MSComctlLib.TreeView treeGrps 
      Height          =   5775
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2775
      _ExtentX        =   4895
      _ExtentY        =   10186
      _Version        =   393217
      Style           =   7
      Appearance      =   1
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuFileExit 
         Caption         =   "&Exit"
         Shortcut        =   ^E
      End
   End
   Begin VB.Menu mnuServer 
      Caption         =   "&Server"
      Begin VB.Menu mnuServerConnect 
         Caption         =   "&Connect..."
         Shortcut        =   ^C
      End
      Begin VB.Menu mnuServerDisconnect 
         Caption         =   "&Disconnect"
         Shortcut        =   ^D
      End
      Begin VB.Menu mnuServerStatus 
         Caption         =   "S&tatus..."
         Shortcut        =   ^T
      End
   End
   Begin VB.Menu mnuGroup 
      Caption         =   "&Group"
      Begin VB.Menu mnuGroupAdd 
         Caption         =   "Add Group"
      End
      Begin VB.Menu mnuGroupRemove 
         Caption         =   "Remove Group"
      End
      Begin VB.Menu mnuGroupEdit 
         Caption         =   "Edit Group"
      End
   End
   Begin VB.Menu mnuItem 
      Caption         =   "&Item"
      Begin VB.Menu mnuItemAdd 
         Caption         =   "Add Item"
      End
      Begin VB.Menu mnuItemRemove 
         Caption         =   "Remove Item"
      End
      Begin VB.Menu mnuItemEdit 
         Caption         =   "Edit Item"
      End
      Begin VB.Menu mnuItemAsyncRead 
         Caption         =   "AsyncRead"
      End
      Begin VB.Menu mnuItemAsyncWrite 
         Caption         =   "AsyncWrite"
      End
   End
   Begin VB.Menu mnuAbout 
      Caption         =   "About"
   End
End
Attribute VB_Name = "MainForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public WithEvents selectedGroup As OPCGroup
Attribute selectedGroup.VB_VarHelpID = -1
Public WithEvents theServerRef As OPCServer
Attribute theServerRef.VB_VarHelpID = -1
Dim selectedItem As OPCItem

Private Sub Form_Load()
    EnableMenuItems
    treeGrps.ImageList = ImageList1
    listItems.Icons = ImageList1
End Sub

Private Sub listItems_ItemClick(ByVal Item As MSComctlLib.ListItem)
    Set selectedItem = selectedGroup.OPCItems.Item(Item.Index)
    EnableMenuItems
End Sub

Private Sub mnuAbout_Click()
    frmAbout.Show vbModal
End Sub

Private Sub mnuFileExit_Click()
    If Not theServer Is Nothing Then
        theServer.Disconnect
    End If
    Unload Me
End Sub

Private Sub mnuGroupAdd_Click()
    Set GroupDlg.theGroup = Nothing
    GroupDlg.Show vbModal
    'update the treeview holding the list of groups
    EnableMenuItems
    RefreshGroupTree
End Sub

Private Sub mnuGroupEdit_Click()
    Set GroupDlg.theGroup = selectedGroup
    GroupDlg.Show vbModal
    'update the treeview holding the list of groups
    RefreshGroupTree
End Sub

Private Sub mnuGroupRemove_Click()
    theServer.OPCGroups.Remove selectedGroup.ServerHandle
    Set selectedGroup = Nothing
    RefreshGroupTree
    If theGroups.Count > 0 Then
        Set selectedGroup = theGroups(1)
    Else
        Set selectedGroup = Nothing
    End If
    Set selectedItem = Nothing
    EnableMenuItems
    RefreshItemList
End Sub

Private Sub mnuItemAdd_Click()
    Set BrowseDlg.theGroup = selectedGroup
    BrowseDlg.Show vbModal
    'Refresh the view
    RefreshItemList
End Sub

Private Sub mnuItemEdit_Click()
    Set ItemDlg.theItem = selectedItem
    ItemDlg.Show vbModal
    RefreshItemList
End Sub

Private Sub mnuItemRemove_Click()
    Dim errors() As Long
    Dim handle(1) As Long
    handle(1) = selectedItem.ServerHandle
    selectedGroup.OPCItems.Remove 1, handle, errors
    Set selectedItem = Nothing
    RefreshItemList
    EnableMenuItems
End Sub

Private Sub mnuServerConnect_Click()
    'Invoke server browser
    svrSelectDlg.Show vbModal
    EnableMenuItems
    If Not theServer Is Nothing Then
        txtMsg = "Connected to " & theServer.ServerName
        Set theServerRef = theServer
    End If
End Sub

Private Sub mnuServerDisconnect_Click()
    Disconnect
End Sub


Private Sub EnableMenuItems()
    If theServer Is Nothing Then
        mnuGroupAdd.Enabled = False
        mnuServerStatus.Enabled = False
        mnuServerDisconnect.Enabled = False
        mnuServerConnect.Enabled = True
    Else
        mnuGroupAdd.Enabled = True
        mnuServerStatus.Enabled = True
        mnuServerDisconnect.Enabled = True
        mnuServerConnect.Enabled = False
    End If
    
    If selectedGroup Is Nothing Then
        mnuItemAdd.Enabled = False
        mnuGroupRemove.Enabled = False
        mnuGroupEdit.Enabled = False
    Else
        mnuItemAdd.Enabled = True
        mnuGroupRemove.Enabled = True
        mnuGroupEdit.Enabled = True
    End If
    
    If selectedItem Is Nothing Then
        mnuItemRemove.Enabled = False
        mnuItemEdit.Enabled = False
        mnuItemAsyncRead.Enabled = False
        mnuItemAsyncWrite.Enabled = False
    Else
        mnuItemRemove.Enabled = True
        mnuItemEdit.Enabled = True
        mnuItemAsyncRead.Enabled = True
        mnuItemAsyncWrite.Enabled = True
    End If
End Sub

Private Sub mnuServerStatus_Click()
    StatusDlg.Show vbModal
End Sub

Private Sub RefreshGroupTree()
    Dim i As Integer
    Dim nd As Node
    Dim theGroup As OPCGroup
    treeGrps.Nodes.Clear
    If Not theGroups Is Nothing Then
        For i = 1 To theGroups.Count
            Set theGroup = theGroups.Item(i)
            Set nd = treeGrps.Nodes.Add(, , , theGroup.name, "Group", "oGroup")
            If Not selectedGroup Is Nothing Then
                If nd.Text = selectedGroup.name Then
                    nd.Selected = True
                End If
            End If
        Next
    End If
End Sub

Private Sub RefreshItemList()
    Dim i As Long
    Dim li As ListItem
    Dim liSub As ListSubItem
    Dim theItem As OPCItem
    Dim v As Variant
    listItems.listItems.Clear
    If Not selectedGroup Is Nothing Then
        For i = 1 To selectedGroup.OPCItems.Count
            Set theItem = selectedGroup.OPCItems.Item(i)
            Set li = listItems.listItems.Add(i, , theItem.ItemID)
            v = theItem.Value
            Set liSub = li.ListSubItems.Add(, , v)
            Set liSub = li.ListSubItems.Add(, , GetQualityText(theItem.quality))
            Set liSub = li.ListSubItems.Add(, , theItem.TimeStamp)
            li.Tag = CStr(theItem.ClientHandle)
        Next
    End If
End Sub


Private Sub mnuItemAsyncRead_Click()
    Dim errors() As Long
    Dim handle(1) As Long
    handle(1) = selectedItem.ServerHandle
    Dim CancelID As Long
    Dim TransID As Long
    TransID = listItems.selectedItem.Index
    selectedGroup.AsyncRead 1, handle, errors, TransID, CancelID
    If errors(1) Then
        txtMsg = "Async Read Error : " & selectedItem.ItemID
    End If
End Sub


Private Sub selectedGroup_AsyncReadComplete(ByVal TransactionID As Long, ByVal NumItems As Long, ClientHandles() As Long, ItemValues() As Variant, Qualities() As Long, TimeStamps() As Date, errors() As Long)
    ' update the item in the list view use the transaction id
    Dim li As ListItem
    Set li = listItems.listItems(TransactionID)
    With li
        .ListSubItems(1).Text = ItemValues(1)
        .ListSubItems(2).Text = GetQualityText(Qualities(1))
        .ListSubItems(3).Text = TimeStamps(1)
    End With
    ' write a message out
    If errors(1) = 0 Then
        txtMsg = "AsyncRead Complete " & li.Text & " = " & CStr(ItemValues(1)) & " Quality = " & GetQualityText(Qualities(1))
    Else
        txtMsg = "AsyncRead Complete Error Reading: " & li.Text
    End If
End Sub


Private Sub mnuItemAsyncWrite_Click()
    Dim errors() As Long
    Dim handle(1) As Long
    Dim Value(1) As Variant
    Dim TransID As Long
    Dim CancelID As Long
    handle(1) = selectedItem.ServerHandle
    TransID = listItems.selectedItem.Index
    With AsyncWriteDlg
        .txtName = selectedItem.ItemID
        .txtValue = selectedItem.Value
        .Show vbModal
        If .bOK Then
            Value(1) = .txtValue
            selectedGroup.AsyncWrite 1, handle, Value, errors, TransID, CancelID
            If errors(1) Then
                txtMsg = "Async Write Error : " & selectedItem.ItemID
            End If
        End If
    End With
End Sub

Private Sub selectedGroup_AsyncWriteComplete(ByVal TransactionID As Long, ByVal NumItems As Long, ClientHandles() As Long, errors() As Long)
    Dim li As ListItem
    Set li = listItems.listItems(TransactionID)
    If errors(1) = 0 Then
        txtMsg = "AsyncWrite Complete For " & li.Text
    Else
        txtMsg = "Async Write Error : " & li.Text
    End If
End Sub

Private Sub selectedGroup_DataChange(ByVal TransactionID As Long, ByVal NumItems As Long, ClientHandles() As Long, ItemValues() As Variant, Qualities() As Long, TimeStamps() As Date)
    ' of course I could just refresh the whole list but this shows how to just update
    ' those items that have changed
    Dim li As ListItem
    Dim i As Long
   
    For i = 1 To NumItems
        Set li = listItems.FindItem(CStr(ClientHandles(i)), lvwTag)
        If Not li Is Nothing Then
            li.ListSubItems(1).Text = ItemValues(i)
            li.ListSubItems(2).Text = GetQualityText(Qualities(i))
            li.ListSubItems(3).Text = TimeStamps(i)
        End If
    Next
    
End Sub

Private Sub theServerRef_ServerShutDown(ByVal Reason As String)
    txtMsg = "Server Shutdown : " & Reason
    Disconnect
End Sub

Private Sub Disconnect()
    theServer.Disconnect
    Set theServer = Nothing
    Set selectedGroup = Nothing
    Set selectedItem = Nothing
    Set theGroups = Nothing
    RefreshGroupTree
    RefreshItemList
    EnableMenuItems
End Sub

Private Sub treeGrps_NodeClick(ByVal Node As MSComctlLib.Node)
    Dim name As String
    name = Node.Text
    Set selectedGroup = theGroups.GetOPCGroup(name)
    RefreshItemList
    EnableMenuItems
End Sub

Private Function GetQualityText(quality As Long) As String
    Select Case quality
        Case &HC0
            GetQualityText = "Good"
        Case 1
            GetQualityText = "Uncertain"
        Case 0
            GetQualityText = "Bad"
    End Select
End Function
