'******************************************************************************
' 				COMPANY CONFIDENTIAL 
' Organisation: OMRON ETC-UK
'      Project: CX OPC
' 
'-----------------------------------------------------------------------------
'    $Workfile: $
'-----------------------------------------------------------------------------
'  DESCRIPTION: OPC VB.net Example
'-----------------------------------------------------------------------------
'SourceSafe Generated Information
'    $Author: $
'    $Revision: $
'    $Date: $
'-----------------------------------------------------------------------------
'                   Copyright (c) Omron Corporation 2003
'                            All Rights Reserved.
'******************************************************************************

Public Class Form1
    Inherits System.Windows.Forms.Form
    Const closedGroup As Integer = 0
    Const openGroup As Integer = 1
    Const closedItem As Integer = 2
    Const subValue As Integer = 2
    Const subActive as Integer = 3
    Const subQuality As Integer = 4

    Private selectedGroup As String = ""
    Private selectedItem As String = ""
    Private itemTable As Hashtable = New Hashtable
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tvGroups As System.Windows.Forms.TreeView
    Friend WithEvents lvItems As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents clName As System.Windows.Forms.ColumnHeader
    Friend WithEvents clType As System.Windows.Forms.ColumnHeader
    Friend WithEvents clValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents clQuality As System.Windows.Forms.ColumnHeader
    Friend WithEvents clActive As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents CxsOpcCtrl1 As CXSOpc.CXSOpcCtrl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.tvGroups = New System.Windows.Forms.TreeView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lvItems = New System.Windows.Forms.ListView
        Me.clName = New System.Windows.Forms.ColumnHeader
        Me.clType = New System.Windows.Forms.ColumnHeader
        Me.clValue = New System.Windows.Forms.ColumnHeader
        Me.clActive = New System.Windows.Forms.ColumnHeader
        Me.clQuality = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnActivate = New System.Windows.Forms.Button
        Me.CxsOpcCtrl1 = New CXSOpc.CXSOpcCtrl
        Me.SuspendLayout()
        '
        'tvGroups
        '
        Me.tvGroups.ImageList = Me.ImageList1
        Me.tvGroups.Location = New System.Drawing.Point(16, 80)
        Me.tvGroups.Name = "tvGroups"
        Me.tvGroups.Size = New System.Drawing.Size(128, 272)
        Me.tvGroups.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'lvItems
        '
        Me.lvItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clName, Me.clType, Me.clValue, Me.clActive, Me.clQuality})
        Me.lvItems.Location = New System.Drawing.Point(160, 80)
        Me.lvItems.MultiSelect = False
        Me.lvItems.Name = "lvItems"
        Me.lvItems.Size = New System.Drawing.Size(416, 272)
        Me.lvItems.SmallImageList = Me.ImageList1
        Me.lvItems.TabIndex = 1
        Me.lvItems.View = System.Windows.Forms.View.Details
        '
        'clName
        '
        Me.clName.Text = "Name"
        Me.clName.Width = 82
        '
        'clType
        '
        Me.clType.Text = "Type"
        Me.clType.Width = 62
        '
        'clValue
        '
        Me.clValue.Text = "Value"
        Me.clValue.Width = 127
        '
        'clActive
        '
        Me.clActive.Text = "Active"
        '
        'clQuality
        '
        Me.clQuality.Text = "Quality"
        Me.clQuality.Width = 78
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Omron Electronics ETC-UK"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "VB.net example opc client"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(504, 360)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(160, 360)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.TabIndex = 7
        Me.btnActivate.Text = "Deactivate"
        '
        'CxsOpcCtrl1
        '
        Me.CxsOpcCtrl1.Groups = New String() {"group1", "group2", "Group3"}
        Me.CxsOpcCtrl1.Location = New System.Drawing.Point(448, 8)
        Me.CxsOpcCtrl1.Name = "CxsOpcCtrl1"
        Me.CxsOpcCtrl1.ProjectFile = "C:\Program Files\Omron\CX-Server OPC\dot net\Examples\VB.net\OPCVBCLIENT\vbclient" & _
        ".opx"
        Me.CxsOpcCtrl1.Size = New System.Drawing.Size(64, 64)
        Me.CxsOpcCtrl1.TabIndex = 8
        Me.CxsOpcCtrl1.Text = "CxsOpcCtrl1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 389)
        Me.Controls.Add(Me.CxsOpcCtrl1)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvItems)
        Me.Controls.Add(Me.tvGroups)
        Me.Name = "Form1"
        Me.Text = "VB.net Example"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CxsOpcCtrl1.Connect()
        PopulateTree()
    End Sub


    Private Sub PopulateTree()
        Dim i As Integer
        Dim groups As String()
        Dim node As TreeNode
        groups = CxsOpcCtrl1.Groups
        For i = 0 To UBound(groups)
            node = New TreeNode(groups(i), closedGroup, openGroup)
            tvGroups.Nodes.Add(node)
        Next
    End Sub

    Private Sub PopulateList(ByVal group As String)
        Dim i As Integer
        Dim items As String()
        Dim lvItem As ListViewItem
        Dim theType As System.Type
        items = CxsOpcCtrl1.Items(group)

        itemTable.Clear()
        lvItems.Items.Clear()
        For i = 0 To UBound(items)
            Dim name As String = items(i)
            lvItem = New ListViewItem(name, closedItem)
            theType = CxsOpcCtrl1.GetType(group, name)
            lvItem.SubItems.Add(theType.Name)  ' type
            lvItem.SubItems.Add("") ' value
            lvItem.SubItems.Add(CxsOpcCtrl1.IsActive(group, name).ToString)  ' active state
            lvItem.SubItems.Add("") ' quality
            lvItems.Items.Add(lvItem)
            itemTable.Add(items(i), lvItem)
            CxsOpcCtrl1.GetData(group, name)
        Next
        CxsOpcCtrl1.Activate(group, True)

    End Sub



    Private Sub tvGroups_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvGroups.AfterSelect
        If (selectedGroup.Length > 0) Then
            CxsOpcCtrl1.Activate(selectedGroup, False)
        End If
        If selectedGroup <> e.Node.Text Then
            selectedGroup = e.Node.Text
            PopulateList(selectedGroup)
        End If
    End Sub

    Private Sub CxsOpcCtrl1_OnDataChange(ByVal sender As Object, ByVal e As CXSOpc.CXSOpcCtrl.DataChangeArgs) Handles CxsOpcCtrl1.OnDataChange
        Dim lvItem As ListViewItem
        lvItem = itemTable(e.Item)
        If (Not e.Value Is Nothing) Then
            lvItem.SubItems(subValue).Text = GetValue(e.Value)
            If e.Quality = 0 Then
                lvItem.SubItems(subQuality).Text = "Bad"
            Else
                lvItem.SubItems(subQuality).Text = "Good"
            End If
        End If
    End Sub

    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        CxsOpcCtrl1.Disconnect()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Function GetValue(ByRef value As Object) As String
        Dim i As Integer = 0
        Dim theType As Type = value.GetType()
        If (theType.IsArray()) Then
            For i = LBound(value) To UBound(value)
                GetValue = GetValue + value(i).ToString() + ", "
            Next
            GetValue = GetValue.Substring(0, GetValue.Length - 2)
        Else
            GetValue = value.ToString()
        End If
    End Function

    Private Sub btnActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivate.Click
        If CxsOpcCtrl1.Activate(selectedGroup, selectedItem, btnActivate.Text = "Activate") Then
            If btnActivate.Text = "Activate" Then
                lvItems.SelectedItems(0).SubItems(subActive).Text = "True"
                btnActivate.Text = "Deactivate"
            Else
                lvItems.SelectedItems(0).SubItems(subActive).Text = "False"
                btnActivate.Text = "Activate"
            End If
        End If
    End Sub

    Private Sub lvItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvItems.SelectedIndexChanged
        If lvItems.SelectedItems.Count > 0 Then
            selectedItem = lvItems.SelectedItems(0).Text
            If CxsOpcCtrl1.IsActive(selectedGroup, selectedItem) Then
                btnActivate.Text = "Deactivate"
            Else
                btnActivate.Text = "Activate"
            End If
        End If
    End Sub
End Class
