//******************************************************************************
// 				COMPANY CONFIDENTIAL 
// Organisation: OMRON ETC-UK
//      Project: OPCApplication
// 
//-----------------------------------------------------------------------------
//    $Workfile: OPCComms.cs $
//-----------------------------------------------------------------------------
//  DESCRIPTION: OPC C# Example
//-----------------------------------------------------------------------------
//SourceSafe Generated Information
//    $Author: Raquel $
//    $Revision: 4 $
//    $Date: 3/12/03 12:50 $
//-----------------------------------------------------------------------------
//                   Copyright (c) Omron Corporation 2003
//                            All Rights Reserved.
//******************************************************************************
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CXOPCCLIENTCOMMUNICATIONSLib;
using System.Reflection;

namespace OPCApplication
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class OPCCommsForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ComboBox cmbItems;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbGroups;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.Button cmbReadAsync;
		private System.Windows.Forms.Button btnWriteAsync;
		private System.Windows.Forms.Button btnStopData;
		private System.Windows.Forms.Button btnGetData;
		private System.Windows.Forms.TextBox txtWriteValue;
		private System.Windows.Forms.TextBox txtWriteAsynValue;
		private System.Windows.Forms.ListBox lstDisplayValues;
		private System.Windows.Forms.GroupBox grpSelection;
		private System.Windows.Forms.GroupBox grpItemsOperation;
		private AxCXOPCCLIENTCOMMUNICATIONSLib.AxOPCComms axOPCComms1;
		//		NOTE:Dispatch interfaces in unmanaged COM that have a default property with more 
		//		than one parameter are not always currently referenced correctly by 
		//		Visual Studio .Net when a wrapper is automatically created for ActiveX components.
		//		The effect of this is that the  ‘Value’ property will not be exposed when inserting
		//		or referencing the CX-Server OPC ActiveX Communications control in your WinApp C# 
		//		or VB.Net application. For further information check the manual "Guide to using CX-Server 
		//		OPC in Microsoft .Net" (appendix C).
		//		there is a work around, first get the class type associated with the specified program 
		//		identifier and then create an instance of the class.
		public static Type OPCcomms = Type.GetTypeFromProgID("CXOPCClientCommunications.CXOPCClientCommunicationsCtrl.1");
		public static object target = Activator.CreateInstance(OPCcomms);

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string Group = "";
		private System.Windows.Forms.Button cmbExit;
		private System.Windows.Forms.Button btnClearList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnGetValue;
		private System.Windows.Forms.Button btnSetValue;
		private System.Windows.Forms.TextBox txtValue;
		private string Item = "";

		public OPCCommsForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OPCCommsForm));
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnRead = new System.Windows.Forms.Button();
			this.cmbGroups = new System.Windows.Forms.ComboBox();
			this.cmbItems = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnWrite = new System.Windows.Forms.Button();
			this.cmbReadAsync = new System.Windows.Forms.Button();
			this.btnWriteAsync = new System.Windows.Forms.Button();
			this.btnStopData = new System.Windows.Forms.Button();
			this.btnGetData = new System.Windows.Forms.Button();
			this.txtWriteValue = new System.Windows.Forms.TextBox();
			this.txtWriteAsynValue = new System.Windows.Forms.TextBox();
			this.lstDisplayValues = new System.Windows.Forms.ListBox();
			this.grpSelection = new System.Windows.Forms.GroupBox();
			this.axOPCComms1 = new AxCXOPCCLIENTCOMMUNICATIONSLib.AxOPCComms();
			this.grpItemsOperation = new System.Windows.Forms.GroupBox();
			this.cmbExit = new System.Windows.Forms.Button();
			this.btnClearList = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGetValue = new System.Windows.Forms.Button();
			this.btnSetValue = new System.Windows.Forms.Button();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.grpSelection.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axOPCComms1)).BeginInit();
			this.grpItemsOperation.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(16, 24);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(192, 24);
			this.btnRead.TabIndex = 1;
			this.btnRead.Text = "Read";
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// cmbGroups
			// 
			this.cmbGroups.Location = new System.Drawing.Point(64, 24);
			this.cmbGroups.Name = "cmbGroups";
			this.cmbGroups.Size = new System.Drawing.Size(120, 21);
			this.cmbGroups.TabIndex = 2;
			this.cmbGroups.SelectedIndexChanged += new System.EventHandler(this.cmbGroups_SelectedIndexChanged);
			// 
			// cmbItems
			// 
			this.cmbItems.Location = new System.Drawing.Point(232, 24);
			this.cmbItems.Name = "cmbItems";
			this.cmbItems.Size = new System.Drawing.Size(112, 21);
			this.cmbItems.TabIndex = 3;
			this.cmbItems.TextChanged += new System.EventHandler(this.cmbItems_TextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(192, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Item";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "PLC";
			// 
			// btnWrite
			// 
			this.btnWrite.Location = new System.Drawing.Point(120, 56);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.Size = new System.Drawing.Size(88, 24);
			this.btnWrite.TabIndex = 8;
			this.btnWrite.Text = "Write";
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// cmbReadAsync
			// 
			this.cmbReadAsync.Location = new System.Drawing.Point(16, 88);
			this.cmbReadAsync.Name = "cmbReadAsync";
			this.cmbReadAsync.Size = new System.Drawing.Size(192, 24);
			this.cmbReadAsync.TabIndex = 9;
			this.cmbReadAsync.Text = "Read Async";
			this.cmbReadAsync.Click += new System.EventHandler(this.cmbReadAsync_Click);
			// 
			// btnWriteAsync
			// 
			this.btnWriteAsync.Location = new System.Drawing.Point(120, 120);
			this.btnWriteAsync.Name = "btnWriteAsync";
			this.btnWriteAsync.Size = new System.Drawing.Size(88, 24);
			this.btnWriteAsync.TabIndex = 10;
			this.btnWriteAsync.Text = "Write Async";
			this.btnWriteAsync.Click += new System.EventHandler(this.btnWriteAsync_Click);
			// 
			// btnStopData
			// 
			this.btnStopData.Location = new System.Drawing.Point(16, 184);
			this.btnStopData.Name = "btnStopData";
			this.btnStopData.Size = new System.Drawing.Size(192, 24);
			this.btnStopData.TabIndex = 12;
			this.btnStopData.Text = "Stop Data";
			this.btnStopData.Click += new System.EventHandler(this.btnStopData_Click);
			// 
			// btnGetData
			// 
			this.btnGetData.Location = new System.Drawing.Point(16, 152);
			this.btnGetData.Name = "btnGetData";
			this.btnGetData.Size = new System.Drawing.Size(192, 24);
			this.btnGetData.TabIndex = 11;
			this.btnGetData.Text = "Get Data";
			this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
			// 
			// txtWriteValue
			// 
			this.txtWriteValue.Location = new System.Drawing.Point(16, 56);
			this.txtWriteValue.Name = "txtWriteValue";
			this.txtWriteValue.TabIndex = 14;
			this.txtWriteValue.Text = "123";
			// 
			// txtWriteAsynValue
			// 
			this.txtWriteAsynValue.Location = new System.Drawing.Point(16, 120);
			this.txtWriteAsynValue.Name = "txtWriteAsynValue";
			this.txtWriteAsynValue.TabIndex = 16;
			this.txtWriteAsynValue.Text = "456";
			// 
			// lstDisplayValues
			// 
			this.lstDisplayValues.Location = new System.Drawing.Point(248, 80);
			this.lstDisplayValues.Name = "lstDisplayValues";
			this.lstDisplayValues.Size = new System.Drawing.Size(128, 238);
			this.lstDisplayValues.TabIndex = 27;
			// 
			// grpSelection
			// 
			this.grpSelection.Controls.Add(this.cmbGroups);
			this.grpSelection.Controls.Add(this.cmbItems);
			this.grpSelection.Controls.Add(this.label2);
			this.grpSelection.Controls.Add(this.label1);
			this.grpSelection.Controls.Add(this.axOPCComms1);
			this.grpSelection.Location = new System.Drawing.Point(16, 8);
			this.grpSelection.Name = "grpSelection";
			this.grpSelection.Size = new System.Drawing.Size(360, 56);
			this.grpSelection.TabIndex = 28;
			this.grpSelection.TabStop = false;
			this.grpSelection.Text = "Selection";
			// 
			// axOPCComms1
			// 
			this.axOPCComms1.ContainingControl = this;
			this.axOPCComms1.Enabled = true;
			this.axOPCComms1.Location = new System.Drawing.Point(0, 0);
			this.axOPCComms1.Name = "axOPCComms1";
			this.axOPCComms1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPCComms1.OcxState")));
			this.axOPCComms1.Size = new System.Drawing.Size(64, 64);
			this.axOPCComms1.TabIndex = 30;
			this.axOPCComms1.OnData += new AxCXOPCCLIENTCOMMUNICATIONSLib._ICXOPCClientCommunicationsCtrlEvents_OnDataEventHandler(this.axOPCComms1_OnData);
			// 
			// grpItemsOperation
			// 
			this.grpItemsOperation.Controls.Add(this.btnRead);
			this.grpItemsOperation.Controls.Add(this.btnWrite);
			this.grpItemsOperation.Controls.Add(this.txtWriteValue);
			this.grpItemsOperation.Controls.Add(this.txtWriteAsynValue);
			this.grpItemsOperation.Controls.Add(this.cmbReadAsync);
			this.grpItemsOperation.Controls.Add(this.btnWriteAsync);
			this.grpItemsOperation.Controls.Add(this.btnStopData);
			this.grpItemsOperation.Controls.Add(this.btnGetData);
			this.grpItemsOperation.Location = new System.Drawing.Point(16, 72);
			this.grpItemsOperation.Name = "grpItemsOperation";
			this.grpItemsOperation.Size = new System.Drawing.Size(224, 216);
			this.grpItemsOperation.TabIndex = 29;
			this.grpItemsOperation.TabStop = false;
			this.grpItemsOperation.Text = "Items Operation";
			// 
			// cmbExit
			// 
			this.cmbExit.Location = new System.Drawing.Point(248, 360);
			this.cmbExit.Name = "cmbExit";
			this.cmbExit.Size = new System.Drawing.Size(128, 24);
			this.cmbExit.TabIndex = 30;
			this.cmbExit.Text = "Exit";
			this.cmbExit.Click += new System.EventHandler(this.cmbExit_Click);
			// 
			// btnClearList
			// 
			this.btnClearList.Location = new System.Drawing.Point(248, 328);
			this.btnClearList.Name = "btnClearList";
			this.btnClearList.Size = new System.Drawing.Size(128, 24);
			this.btnClearList.TabIndex = 31;
			this.btnClearList.Text = "ClearList";
			this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnGetValue);
			this.groupBox1.Controls.Add(this.btnSetValue);
			this.groupBox1.Controls.Add(this.txtValue);
			this.groupBox1.Location = new System.Drawing.Point(16, 296);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 88);
			this.groupBox1.TabIndex = 32;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Value Property";
			// 
			// btnGetValue
			// 
			this.btnGetValue.Location = new System.Drawing.Point(16, 24);
			this.btnGetValue.Name = "btnGetValue";
			this.btnGetValue.Size = new System.Drawing.Size(192, 24);
			this.btnGetValue.TabIndex = 17;
			this.btnGetValue.Text = "Get_Value";
			this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
			// 
			// btnSetValue
			// 
			this.btnSetValue.Location = new System.Drawing.Point(128, 56);
			this.btnSetValue.Name = "btnSetValue";
			this.btnSetValue.Size = new System.Drawing.Size(80, 24);
			this.btnSetValue.TabIndex = 18;
			this.btnSetValue.Text = "Set_Value";
			this.btnSetValue.Click += new System.EventHandler(this.btnSetValue_Click);
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(16, 56);
			this.txtValue.Name = "txtValue";
			this.txtValue.TabIndex = 19;
			this.txtValue.Text = "789";
			// 
			// OPCCommsForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 397);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnClearList);
			this.Controls.Add(this.cmbExit);
			this.Controls.Add(this.grpSelection);
			this.Controls.Add(this.grpItemsOperation);
			this.Controls.Add(this.lstDisplayValues);
			this.Name = "OPCCommsForm";
			this.Text = "OPCComms";
			this.Load += new System.EventHandler(this.OPCCommsForm_Load);
			this.grpSelection.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axOPCComms1)).EndInit();
			this.grpItemsOperation.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new OPCCommsForm());
		}

		private void OPCCommsForm_Load(object sender, System.EventArgs e)
		{
			if (SelectProjectPath()== true)
			{	
				object [] path = {openFileDialog1.FileName.ToString()};
				OPCcomms.InvokeMember("ProjectName",BindingFlags.SetProperty,null,target,path);
				object [] servername = {"OMRON.OpenDataServer.1"};
				OPCcomms.InvokeMember("ServerName",BindingFlags.SetProperty,null,target,servername);
				axOPCComms1.ServerName = "OMRON.OpenDataServer.1";
				PopulateGroupList();
			}
		}

		private bool SelectProjectPath()
		{
			bool bResult = false;
			openFileDialog1.Filter = "CXServer OPC Project Files(*.opc)|*.opc|All files (*.*)|*.*";
			DialogResult result = openFileDialog1.ShowDialog();
			if (result == DialogResult.OK && openFileDialog1.FileName != "")
			{
				axOPCComms1.ProjectName = openFileDialog1.FileName.ToString();
				bResult = true;
			}
			return bResult;
		}

		private void PopulateGroupList()
		{
			//add Groups
			cmbGroups.Items.Clear();
			object o = axOPCComms1.ListGroups;
			foreach(object Groups in (System.Array)o)
				cmbGroups.Items.Add((string)Groups);
			cmbGroups.SelectedIndex = 0;
		}

		private void PopulateItemList()
		{
			if (cmbItems.Items.Count < 0)
				return;
			//add the points for the corresponding PLC
			cmbItems.Items.Clear();
			object obj = axOPCComms1.get_ListItems(cmbGroups.SelectedItem.ToString());
			foreach(object Items in (System.Array)obj)
				cmbItems.Items.Add((string)Items);
			cmbItems.SelectedIndex = 0;
		}

		private void DisplayValue(object obj)
		{
			lstDisplayValues.Items.Clear();
			if (obj == null) 
				return;
			Type t = obj.GetType();
			if(t.IsArray)
			{
				foreach(object Value in (System.Array)obj)
					lstDisplayValues.Items.Add(Value);
			}
			else
				lstDisplayValues.Items.Add(obj);
		}

		private void cmbGroups_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Group = cmbGroups.SelectedItem.ToString();
			PopulateItemList();
		}

		private void btnRead_Click(object sender, System.EventArgs e)
		{
			object val = axOPCComms1.Read(Group,Item,ReadSetting.ReadFromDevice);
			DisplayValue(val);
		}

		private void cmbReadAsync_Click(object sender, System.EventArgs e)
		{
			axOPCComms1.Read(Group,Item,ReadSetting.ReadFromDeviceAsync);
		}

		private void axOPCComms1_OnData(object sender, AxCXOPCCLIENTCOMMUNICATIONSLib._ICXOPCClientCommunicationsCtrlEvents_OnDataEvent e)
		{
			DisplayValue((object)e.value);
		}

		private void btnGetData_Click(object sender, System.EventArgs e)
		{
			axOPCComms1.GetData(Group,Item,UpdateSetting.Continuous);
		}

		private void btnStopData_Click(object sender, System.EventArgs e)
		{
			axOPCComms1.StopData(Group,Item);
		}

		private void btnWrite_Click(object sender, System.EventArgs e)
		{
			object val = (object)Convert.ToInt16(txtWriteValue.Text);
			if (val == null)
				return;
			axOPCComms1.Write(Group,Item,val,WriteSetting.WaitUntilComplete);
		}

		private void btnWriteAsync_Click(object sender, System.EventArgs e)
		{
			object val = (object)Convert.ToInt16(txtWriteAsynValue.Text);
			if (val == null)
				return;
			axOPCComms1.Write(Group,Item,val, WriteSetting.NoWaiting);
		}

		private void cmbItems_TextChanged(object sender, System.EventArgs e)
		{
			Item = cmbItems.Text;
		}

		private void cmbExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		static object getValue(string Group, string Item)
		{
			object [] args = {Group, Item};
			return OPCcomms.InvokeMember("Value", BindingFlags.GetProperty, null, target, args);
		}

		static object setValue(string Group, string Item, int Value)
		{
			object [] args = {Group, Item, Value};
			return OPCcomms.InvokeMember("Value", BindingFlags.SetProperty, null, target, args);
		}

		private void btnGetValue_Click(object sender, System.EventArgs e)
		{
			object obj = getValue(Group, Item);
			DisplayValue(obj);
		}

		private void btnSetValue_Click(object sender, System.EventArgs e)
		{
			setValue(Group, Item, Convert.ToInt32(txtValue.Text));
		}

		private void btnClearList_Click(object sender, System.EventArgs e)
		{
			lstDisplayValues.Items.Clear();
		}

		
	}
}
