Public Class Form1
    Inherits System.Windows.Forms.Form
    'Create the OPC Server instance given the ProgID.
    Public OPCCommsCtrl As Type = Type.GetTypeFromProgID("OMRON.OpenDataServer.1")
    Public target As Object = Activator.CreateInstance(OPCCommsCtrl)
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
    Friend WithEvents grpSelection As System.Windows.Forms.GroupBox
    Friend WithEvents AxOPCComms1 As AxCXOPCCLIENTCOMMUNICATIONSLib.AxOPCComms
    Friend WithEvents grpLabel As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents btnStopData As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.grpSelection = New System.Windows.Forms.GroupBox
        Me.cmbGroups = New System.Windows.Forms.ComboBox
        Me.cmbItems = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.grpLabel = New System.Windows.Forms.Label
        Me.grpItemsOperation = New System.Windows.Forms.GroupBox
        Me.btnRead = New System.Windows.Forms.Button
        Me.btnWrite = New System.Windows.Forms.Button
        Me.txtWriteValue = New System.Windows.Forms.TextBox
        Me.txtWriteAsynValue = New System.Windows.Forms.TextBox
        Me.cmbReadAsync = New System.Windows.Forms.Button
        Me.btnWriteAsync = New System.Windows.Forms.Button
        Me.btnStopData = New System.Windows.Forms.Button
        Me.btnGetData = New System.Windows.Forms.Button
        Me.grpValueProperty = New System.Windows.Forms.GroupBox
        Me.btnGetValue = New System.Windows.Forms.Button
        Me.btnSetValue = New System.Windows.Forms.Button
        Me.txtValue = New System.Windows.Forms.TextBox
        Me.btnClearList = New System.Windows.Forms.Button
        Me.cmbExit = New System.Windows.Forms.Button
        Me.lstDisplayValues = New System.Windows.Forms.ListBox
        Me.AxOPCComms1 = New AxCXOPCCLIENTCOMMUNICATIONSLib.AxOPCComms
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.grpSelection.SuspendLayout()
        Me.grpItemsOperation.SuspendLayout()
        Me.grpValueProperty.SuspendLayout()
        CType(Me.AxOPCComms1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSelection
        '
        Me.grpSelection.Controls.Add(Me.cmbGroups)
        Me.grpSelection.Controls.Add(Me.cmbItems)
        Me.grpSelection.Controls.Add(Me.label2)
        Me.grpSelection.Controls.Add(Me.grpLabel)
        Me.grpSelection.Location = New System.Drawing.Point(8, 8)
        Me.grpSelection.Name = "grpSelection"
        Me.grpSelection.Size = New System.Drawing.Size(368, 64)
        Me.grpSelection.TabIndex = 0
        Me.grpSelection.TabStop = False
        Me.grpSelection.Text = "Selection"
        '
        'cmbGroups
        '
        Me.cmbGroups.Location = New System.Drawing.Point(64, 24)
        Me.cmbGroups.Name = "cmbGroups"
        Me.cmbGroups.Size = New System.Drawing.Size(120, 21)
        Me.cmbGroups.TabIndex = 8
        '
        'cmbItems
        '
        Me.cmbItems.Location = New System.Drawing.Point(232, 24)
        Me.cmbItems.Name = "cmbItems"
        Me.cmbItems.Size = New System.Drawing.Size(128, 21)
        Me.cmbItems.TabIndex = 9
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(192, 24)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(40, 23)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Item"
        '
        'grpLabel
        '
        Me.grpLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLabel.Location = New System.Drawing.Point(16, 24)
        Me.grpLabel.Name = "grpLabel"
        Me.grpLabel.Size = New System.Drawing.Size(48, 23)
        Me.grpLabel.TabIndex = 10
        Me.grpLabel.Text = "Group"
        '
        'grpItemsOperation
        '
        Me.grpItemsOperation.Controls.Add(Me.btnRead)
        Me.grpItemsOperation.Controls.Add(Me.btnWrite)
        Me.grpItemsOperation.Controls.Add(Me.txtWriteValue)
        Me.grpItemsOperation.Controls.Add(Me.txtWriteAsynValue)
        Me.grpItemsOperation.Controls.Add(Me.cmbReadAsync)
        Me.grpItemsOperation.Controls.Add(Me.btnWriteAsync)
        Me.grpItemsOperation.Controls.Add(Me.btnStopData)
        Me.grpItemsOperation.Controls.Add(Me.btnGetData)
        Me.grpItemsOperation.Location = New System.Drawing.Point(8, 80)
        Me.grpItemsOperation.Name = "grpItemsOperation"
        Me.grpItemsOperation.Size = New System.Drawing.Size(224, 224)
        Me.grpItemsOperation.TabIndex = 1
        Me.grpItemsOperation.TabStop = False
        Me.grpItemsOperation.Text = "Items Operation"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(16, 24)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(192, 24)
        Me.btnRead.TabIndex = 17
        Me.btnRead.Text = "Read"
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(120, 56)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(88, 24)
        Me.btnWrite.TabIndex = 18
        Me.btnWrite.Text = "Write"
        '
        'txtWriteValue
        '
        Me.txtWriteValue.Location = New System.Drawing.Point(16, 56)
        Me.txtWriteValue.Name = "txtWriteValue"
        Me.txtWriteValue.TabIndex = 23
        Me.txtWriteValue.Text = "123"
        '
        'txtWriteAsynValue
        '
        Me.txtWriteAsynValue.Location = New System.Drawing.Point(16, 120)
        Me.txtWriteAsynValue.Name = "txtWriteAsynValue"
        Me.txtWriteAsynValue.TabIndex = 24
        Me.txtWriteAsynValue.Text = "456"
        '
        'cmbReadAsync
        '
        Me.cmbReadAsync.Location = New System.Drawing.Point(16, 88)
        Me.cmbReadAsync.Name = "cmbReadAsync"
        Me.cmbReadAsync.Size = New System.Drawing.Size(192, 24)
        Me.cmbReadAsync.TabIndex = 19
        Me.cmbReadAsync.Text = "Read Async"
        '
        'btnWriteAsync
        '
        Me.btnWriteAsync.Location = New System.Drawing.Point(120, 120)
        Me.btnWriteAsync.Name = "btnWriteAsync"
        Me.btnWriteAsync.Size = New System.Drawing.Size(88, 24)
        Me.btnWriteAsync.TabIndex = 20
        Me.btnWriteAsync.Text = "Write Async"
        '
        'btnStopData
        '
        Me.btnStopData.Location = New System.Drawing.Point(16, 184)
        Me.btnStopData.Name = "btnStopData"
        Me.btnStopData.Size = New System.Drawing.Size(192, 24)
        Me.btnStopData.TabIndex = 22
        Me.btnStopData.Text = "Stop Data"
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(16, 152)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(192, 24)
        Me.btnGetData.TabIndex = 21
        Me.btnGetData.Text = "Get Data"
        '
        'grpValueProperty
        '
        Me.grpValueProperty.Controls.Add(Me.btnGetValue)
        Me.grpValueProperty.Controls.Add(Me.btnSetValue)
        Me.grpValueProperty.Controls.Add(Me.txtValue)
        Me.grpValueProperty.Location = New System.Drawing.Point(8, 312)
        Me.grpValueProperty.Name = "grpValueProperty"
        Me.grpValueProperty.Size = New System.Drawing.Size(224, 96)
        Me.grpValueProperty.TabIndex = 2
        Me.grpValueProperty.TabStop = False
        Me.grpValueProperty.Text = "Value Property"
        '
        'btnGetValue
        '
        Me.btnGetValue.Location = New System.Drawing.Point(16, 24)
        Me.btnGetValue.Name = "btnGetValue"
        Me.btnGetValue.Size = New System.Drawing.Size(192, 24)
        Me.btnGetValue.TabIndex = 20
        Me.btnGetValue.Text = "Get_Value"
        '
        'btnSetValue
        '
        Me.btnSetValue.Location = New System.Drawing.Point(128, 56)
        Me.btnSetValue.Name = "btnSetValue"
        Me.btnSetValue.Size = New System.Drawing.Size(80, 24)
        Me.btnSetValue.TabIndex = 21
        Me.btnSetValue.Text = "Set_Value"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(16, 56)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(104, 20)
        Me.txtValue.TabIndex = 22
        Me.txtValue.Text = "789"
        '
        'btnClearList
        '
        Me.btnClearList.Location = New System.Drawing.Point(240, 344)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(128, 24)
        Me.btnClearList.TabIndex = 34
        Me.btnClearList.Text = "ClearList"
        '
        'cmbExit
        '
        Me.cmbExit.Location = New System.Drawing.Point(240, 376)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(128, 24)
        Me.cmbExit.TabIndex = 33
        Me.cmbExit.Text = "Exit"
        '
        'lstDisplayValues
        '
        Me.lstDisplayValues.Location = New System.Drawing.Point(240, 88)
        Me.lstDisplayValues.Name = "lstDisplayValues"
        Me.lstDisplayValues.Size = New System.Drawing.Size(128, 238)
        Me.lstDisplayValues.TabIndex = 32
        '
        'AxOPCComms1
        '
        Me.AxOPCComms1.Enabled = True
        Me.AxOPCComms1.Location = New System.Drawing.Point(272, 256)
        Me.AxOPCComms1.Name = "AxOPCComms1"
        Me.AxOPCComms1.OcxState = CType(resources.GetObject("AxOPCComms1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxOPCComms1.Size = New System.Drawing.Size(64, 64)
        Me.AxOPCComms1.TabIndex = 35
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 413)
        Me.Controls.Add(Me.AxOPCComms1)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.cmbExit)
        Me.Controls.Add(Me.lstDisplayValues)
        Me.Controls.Add(Me.grpSelection)
        Me.Controls.Add(Me.grpItemsOperation)
        Me.Controls.Add(Me.grpValueProperty)
        Me.Name = "Form1"
        Me.Text = "OPCComms"
        Me.grpSelection.ResumeLayout(False)
        Me.grpItemsOperation.ResumeLayout(False)
        Me.grpValueProperty.ResumeLayout(False)
        CType(Me.AxOPCComms1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend WithEvents lstDisplayValues As System.Windows.Forms.ListBox
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents btnSetValue As System.Windows.Forms.Button
    Friend WithEvents btnGetValue As System.Windows.Forms.Button
    Friend WithEvents btnWriteAsync As System.Windows.Forms.Button
    Friend WithEvents cmbReadAsync As System.Windows.Forms.Button
    Friend WithEvents txtWriteAsynValue As System.Windows.Forms.TextBox
    Friend WithEvents txtWriteValue As System.Windows.Forms.TextBox
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents cmbItems As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGroups As System.Windows.Forms.ComboBox
    Friend WithEvents grpValueProperty As System.Windows.Forms.GroupBox
    Friend WithEvents grpItemsOperation As System.Windows.Forms.GroupBox

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim obj As Object
        Dim path(0) As Object
        Dim plcs As Object
        Dim points As Object
        If SelectProjectPath() = True Then
            PopulateGroupComboBox()
            PopulatePointsComboBox()
        End If
    End Sub

    Function SelectProjectPath()
        Dim bResult As Boolean = False
        Dim result As DialogResult
        OpenFileDialog1.Filter = "CXServer Project Files(*.opc)|*.opc|All files (*.*)|*.*"
        result = openFileDialog1.ShowDialog()
        If (result = DialogResult.OK) And Not (openFileDialog1.FileName = "") Then
            AxOPCComms1.ProjectName = OpenFileDialog1.FileName.ToString()
            bResult = True
        End If
        Return bResult
    End Function

    Function PopulateGroupComboBox()
        Dim obj As Object
        Dim groups As Object
        cmbGroups.Items.Clear()
        'populate combo box with PLC list
        obj = AxOPCComms1.ListGroups()
        For Each groups In obj
            cmbGroups.Items.Add(groups)
        Next
        cmbGroups.SelectedIndex = 0
    End Function

    Function PopulatePointsComboBox()
        Dim obj As Object
        Dim items As Object
        cmbItems.Items.Clear()
        obj = AxOPCComms1.get_ListItems(cmbGroups.SelectedItem)
        For Each items In obj
            cmbItems.Items.Add(items)
        Next
        cmbItems.SelectedIndex = 0
    End Function

    Private Sub cmbGroups_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroups.SelectedIndexChanged
        PopulatePointsComboBox()
    End Sub

    Private Sub DisplayValue(ByVal obj As Object)
        Dim t As Type
        Dim Value As Object
        If (obj) Is Nothing Then
            Return
        End If
        lstDisplayValues.Items.Clear()
        t = obj.GetType()
        If (t.IsArray) Then
            For Each Value In obj
                lstDisplayValues.Items.Add(Value)
            Next
        Else
            lstDisplayValues.Items.Add(obj)
        End If
    End Sub

    Private Sub btnClearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
        lstDisplayValues.Items.Clear()
    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        Dim obj As Object
        obj = AxOPCComms1.Read(cmbGroups.SelectedItem, cmbItems.SelectedItem, CXOPCCLIENTCOMMUNICATIONSLib.ReadSetting.ReadFromDevice)
        DisplayValue(obj)
    End Sub
    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click
        Dim iValue As Integer
        iValue = Convert.ToInt16(txtWriteValue.Text)
        AxOPCComms1.Write(cmbGroups.Text, cmbItems.Text, iValue, CXOPCCLIENTCOMMUNICATIONSLib.WriteSetting.WaitUntilComplete)
    End Sub

    Private Sub cmbReadAsync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReadAsync.Click
        AxOPCComms1.Read(cmbGroups.SelectedItem, cmbItems.SelectedItem, CXOPCCLIENTCOMMUNICATIONSLib.ReadSetting.ReadFromDeviceAsync)
    End Sub
    Private Sub AxComms1_OnData(ByVal sender As Object, ByVal e As AxCXOPCCLIENTCOMMUNICATIONSLib._ICXOPCClientCommunicationsCtrlEvents_OnDataEvent) Handles AxOPCComms1.OnData
        DisplayValue(e.value)
    End Sub
    Private Sub btnWriteAsync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteAsync.Click
        Dim iValue As Integer
        iValue = Convert.ToInt16(txtWriteAsynValue.Text)
        AxOPCComms1.Write(cmbGroups.Text, cmbItems.Text, iValue, CXOPCCLIENTCOMMUNICATIONSLib.WriteSetting.NoWaiting)
    End Sub
    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        'Dim dblUpdateRate As Double
        'dblUpdateRate = Convert.ToDouble(txtUpdateRate.Text)
        AxOPCComms1.GetData(cmbGroups.Text, cmbItems.Text, CXOPCCLIENTCOMMUNICATIONSLib.UpdateSetting.OnChange)
        btnGetData.Enabled = False
    End Sub

    Private Sub btnStopData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopData.Click
        If btnGetData.Enabled = False Then
            btnGetData.Enabled = True
        End If
        AxOPCComms1.StopData(cmbGroups.Text, cmbItems.Text)
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        Close()
    End Sub

    Private Sub btnGetValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetValue.Click
        Dim obj As Object
        obj = getValue(cmbItems.Text)
        DisplayValue(obj)
    End Sub

    Private Sub btnSetValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetValue.Click
        setValue(cmbItems.Text, Convert.ToInt32(txtValue.Text))
    End Sub
    Function getValue(ByVal PointName As String) As Object
        Dim arg(0) As Object
        arg.SetValue(PointName, 0)
        'Return OPCCommsCtrl.InvokeMember("Value", System.Reflection.BindingFlags.GetProperty, Nothing, target, arg)
        Return AxOPCComms1.Value(cmbGroups.Text, cmbItems.Text)
    End Function
    Function setValue(ByVal PointName As String, ByVal Value As Integer) As Object
        Dim args(1) As Object
        args.SetValue(PointName, 0)
        args.SetValue(Value, 1)
        'Return OPCCommsCtrl.InvokeMember("Value", System.Reflection.BindingFlags.SetProperty, Nothing, target, args)
        AxOPCComms1.Value(cmbGroups.Text, cmbItems.Text) = Value
    End Function
End Class
