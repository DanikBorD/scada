//******************************************************************************
// 				COMPANY CONFIDENTIAL 
// Organisation: OMRON ETC-UK
//      Project: CX OPC
// 
//-----------------------------------------------------------------------------
//    $Workfile: Form1.cs $
//-----------------------------------------------------------------------------
//  DESCRIPTION: OPC C# Example
//-----------------------------------------------------------------------------
//SourceSafe Generated Information
//    $Author: Raquel $
//    $Revision: 4 $
//    $Date: 6/02/04 8:59 $
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
using CXSOpc;
namespace opcCSharpClient
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnAsyncRead;
		private System.Windows.Forms.Button btnAsyncWrite;
		private System.Windows.Forms.TextBox textMsg;
		private System.Windows.Forms.Button btnGetData;
		private System.Windows.Forms.TextBox textData;
		private System.Windows.Forms.Button btnStopData;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string selectedGroup;
		private string selectedItem;
		private string DataGroup;
		private string DataItem;
		private System.Windows.Forms.TextBox textGDName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textSRead;
		private System.Windows.Forms.Button btnSRead;
		private System.Windows.Forms.Button btnSWrite;
		private System.Windows.Forms.TextBox textSWrite;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textARead;
		private System.Windows.Forms.TextBox textAWrite;
		private System.Windows.Forms.NumericUpDown numElement;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAItem;
		private System.Windows.Forms.Button btnAGroup;
		private System.Windows.Forms.ListBox lbItems;
		private System.Windows.Forms.ListBox lbGroups;
		private System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.Label label4;
		private CXSOpc.CXSOpcCtrl cxsOpcCtrl1;
		private System.Windows.Forms.Label label1;

		public Form1()
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
			this.btnGetData = new System.Windows.Forms.Button();
			this.textData = new System.Windows.Forms.TextBox();
			this.btnSRead = new System.Windows.Forms.Button();
			this.btnSWrite = new System.Windows.Forms.Button();
			this.textSWrite = new System.Windows.Forms.TextBox();
			this.btnAsyncRead = new System.Windows.Forms.Button();
			this.btnAsyncWrite = new System.Windows.Forms.Button();
			this.textMsg = new System.Windows.Forms.TextBox();
			this.btnStopData = new System.Windows.Forms.Button();
			this.textGDName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textSRead = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textAWrite = new System.Windows.Forms.TextBox();
			this.textARead = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numElement = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAItem = new System.Windows.Forms.Button();
			this.btnAGroup = new System.Windows.Forms.Button();
			this.lbItems = new System.Windows.Forms.ListBox();
			this.lbGroups = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cxsOpcCtrl1 = new CXSOpc.CXSOpcCtrl();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numElement)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGetData
			// 
			this.btnGetData.Location = new System.Drawing.Point(16, 32);
			this.btnGetData.Name = "btnGetData";
			this.btnGetData.Size = new System.Drawing.Size(72, 23);
			this.btnGetData.TabIndex = 1;
			this.btnGetData.Text = "GetData";
			this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
			// 
			// textData
			// 
			this.textData.Location = new System.Drawing.Point(16, 64);
			this.textData.Multiline = true;
			this.textData.Name = "textData";
			this.textData.Size = new System.Drawing.Size(384, 40);
			this.textData.TabIndex = 2;
			this.textData.Text = "";
			// 
			// btnSRead
			// 
			this.btnSRead.Location = new System.Drawing.Point(16, 24);
			this.btnSRead.Name = "btnSRead";
			this.btnSRead.Size = new System.Drawing.Size(96, 23);
			this.btnSRead.TabIndex = 7;
			this.btnSRead.Text = "Sync Read";
			this.btnSRead.Click += new System.EventHandler(this.btnSRead_Click);
			// 
			// btnSWrite
			// 
			this.btnSWrite.Location = new System.Drawing.Point(16, 64);
			this.btnSWrite.Name = "btnSWrite";
			this.btnSWrite.Size = new System.Drawing.Size(96, 23);
			this.btnSWrite.TabIndex = 9;
			this.btnSWrite.Text = "Sync Write";
			this.btnSWrite.Click += new System.EventHandler(this.btnSWrite_Click);
			// 
			// textSWrite
			// 
			this.textSWrite.Location = new System.Drawing.Point(136, 64);
			this.textSWrite.Name = "textSWrite";
			this.textSWrite.Size = new System.Drawing.Size(264, 20);
			this.textSWrite.TabIndex = 10;
			this.textSWrite.Text = "";
			// 
			// btnAsyncRead
			// 
			this.btnAsyncRead.Location = new System.Drawing.Point(16, 24);
			this.btnAsyncRead.Name = "btnAsyncRead";
			this.btnAsyncRead.Size = new System.Drawing.Size(80, 24);
			this.btnAsyncRead.TabIndex = 12;
			this.btnAsyncRead.Text = "Async Read";
			this.btnAsyncRead.Click += new System.EventHandler(this.btnAsyncRead_Click);
			// 
			// btnAsyncWrite
			// 
			this.btnAsyncWrite.Location = new System.Drawing.Point(16, 64);
			this.btnAsyncWrite.Name = "btnAsyncWrite";
			this.btnAsyncWrite.Size = new System.Drawing.Size(80, 24);
			this.btnAsyncWrite.TabIndex = 13;
			this.btnAsyncWrite.Text = "Async Write";
			this.btnAsyncWrite.Click += new System.EventHandler(this.btnAsyncWrite_Click);
			// 
			// textMsg
			// 
			this.textMsg.Location = new System.Drawing.Point(136, 96);
			this.textMsg.Name = "textMsg";
			this.textMsg.Size = new System.Drawing.Size(264, 20);
			this.textMsg.TabIndex = 15;
			this.textMsg.Text = "";
			// 
			// btnStopData
			// 
			this.btnStopData.Enabled = false;
			this.btnStopData.Location = new System.Drawing.Point(328, 32);
			this.btnStopData.Name = "btnStopData";
			this.btnStopData.Size = new System.Drawing.Size(72, 23);
			this.btnStopData.TabIndex = 22;
			this.btnStopData.Text = "StopData";
			this.btnStopData.Click += new System.EventHandler(this.btnStopData_Click);
			// 
			// textGDName
			// 
			this.textGDName.Enabled = false;
			this.textGDName.Location = new System.Drawing.Point(112, 32);
			this.textGDName.Name = "textGDName";
			this.textGDName.Size = new System.Drawing.Size(192, 20);
			this.textGDName.TabIndex = 23;
			this.textGDName.Text = "";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textData);
			this.groupBox2.Controls.Add(this.btnGetData);
			this.groupBox2.Controls.Add(this.btnStopData);
			this.groupBox2.Controls.Add(this.textGDName);
			this.groupBox2.Location = new System.Drawing.Point(8, 264);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(416, 120);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Start && Stop Data Gather";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textSRead);
			this.groupBox3.Controls.Add(this.btnSRead);
			this.groupBox3.Controls.Add(this.btnSWrite);
			this.groupBox3.Controls.Add(this.textSWrite);
			this.groupBox3.Location = new System.Drawing.Point(8, 400);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(416, 96);
			this.groupBox3.TabIndex = 25;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Synchronous Operations";
			// 
			// textSRead
			// 
			this.textSRead.Location = new System.Drawing.Point(136, 24);
			this.textSRead.Name = "textSRead";
			this.textSRead.Size = new System.Drawing.Size(264, 20);
			this.textSRead.TabIndex = 8;
			this.textSRead.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textAWrite);
			this.groupBox4.Controls.Add(this.btnAsyncRead);
			this.groupBox4.Controls.Add(this.btnAsyncWrite);
			this.groupBox4.Controls.Add(this.textARead);
			this.groupBox4.Controls.Add(this.textMsg);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new System.Drawing.Point(8, 520);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(416, 128);
			this.groupBox4.TabIndex = 26;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Asynchronous Operations";
			// 
			// textAWrite
			// 
			this.textAWrite.Location = new System.Drawing.Point(136, 64);
			this.textAWrite.Name = "textAWrite";
			this.textAWrite.Size = new System.Drawing.Size(264, 20);
			this.textAWrite.TabIndex = 14;
			this.textAWrite.Text = "";
			// 
			// textARead
			// 
			this.textARead.Location = new System.Drawing.Point(136, 24);
			this.textARead.Name = "textARead";
			this.textARead.Size = new System.Drawing.Size(264, 20);
			this.textARead.TabIndex = 11;
			this.textARead.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 27;
			this.label1.Text = "Message:";
			// 
			// numElement
			// 
			this.numElement.Enabled = false;
			this.numElement.Location = new System.Drawing.Point(352, 24);
			this.numElement.Minimum = new System.Decimal(new int[] {
																	   1,
																	   0,
																	   0,
																	   -2147483648});
			this.numElement.Name = "numElement";
			this.numElement.Size = new System.Drawing.Size(56, 20);
			this.numElement.TabIndex = 8;
			this.numElement.Value = new System.Decimal(new int[] {
																	 1,
																	 0,
																	 0,
																	 -2147483648});
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(296, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Element";
			// 
			// btnAItem
			// 
			this.btnAItem.Location = new System.Drawing.Point(160, 144);
			this.btnAItem.Name = "btnAItem";
			this.btnAItem.Size = new System.Drawing.Size(128, 23);
			this.btnAItem.TabIndex = 5;
			this.btnAItem.Text = "Active";
			this.btnAItem.Click += new System.EventHandler(this.btnAItem_Click);
			// 
			// btnAGroup
			// 
			this.btnAGroup.Location = new System.Drawing.Point(16, 144);
			this.btnAGroup.Name = "btnAGroup";
			this.btnAGroup.Size = new System.Drawing.Size(128, 23);
			this.btnAGroup.TabIndex = 4;
			this.btnAGroup.Text = "Active";
			this.btnAGroup.Click += new System.EventHandler(this.btnAGroup_Click);
			// 
			// lbItems
			// 
			this.lbItems.Location = new System.Drawing.Point(160, 16);
			this.lbItems.Name = "lbItems";
			this.lbItems.Size = new System.Drawing.Size(128, 121);
			this.lbItems.TabIndex = 1;
			this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
			// 
			// lbGroups
			// 
			this.lbGroups.Location = new System.Drawing.Point(16, 16);
			this.lbGroups.Name = "lbGroups";
			this.lbGroups.Size = new System.Drawing.Size(128, 121);
			this.lbGroups.TabIndex = 0;
			this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numElement);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnAItem);
			this.groupBox1.Controls.Add(this.btnAGroup);
			this.groupBox1.Controls.Add(this.lbItems);
			this.groupBox1.Controls.Add(this.lbGroups);
			this.groupBox1.Location = new System.Drawing.Point(8, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(416, 176);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Groups && Items";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label3.Location = new System.Drawing.Point(8, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(240, 23);
			this.label3.TabIndex = 28;
			this.label3.Text = "C# example opc client";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label4.Location = new System.Drawing.Point(8, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(312, 23);
			this.label4.TabIndex = 27;
			this.label4.Text = "Omron Electronics ETC-UK";
			// 
			// cxsOpcCtrl1
			// 
			this.cxsOpcCtrl1.Groups = new string[] {
													   "Group11",
													   "group1"};
			this.cxsOpcCtrl1.Location = new System.Drawing.Point(336, 8);
			this.cxsOpcCtrl1.Name = "cxsOpcCtrl1";
			this.cxsOpcCtrl1.ProjectFile = "C:\\Program Files\\Omron\\CX-Server OPC\\dot net\\Examples\\C#\\OPCC#CLIENT\\C#Client.opx" +
				"";
			this.cxsOpcCtrl1.Size = new System.Drawing.Size(64, 64);
			this.cxsOpcCtrl1.TabIndex = 29;
			this.cxsOpcCtrl1.Text = "cxsOpcCtrl1";
			this.cxsOpcCtrl1.OnDataChange += new CXSOpc.CXSOpcCtrl.OnDataChangeHandler(this.cxsOpcCtrl1_OnDataChange);
			this.cxsOpcCtrl1.OnReadComplete += new CXSOpc.CXSOpcCtrl.OnReadCompleteHandler(this.cxsOpcCtrl1_OnReadComplete);
			this.cxsOpcCtrl1.OnWriteComplete += new CXSOpc.CXSOpcCtrl.OnWriteCompleteHandler(this.cxsOpcCtrl1_OnWriteComplete);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 661);
			this.Controls.Add(this.cxsOpcCtrl1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Name = "Form1";
			this.Text = "C# Example";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.Form1_Closed);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numElement)).EndInit();
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
			Application.Run(new Form1());
		}


		private void Form1_Load(object sender, System.EventArgs e)
		{
			cxsOpcCtrl1.Connect();
			lbGroups.DataSource = cxsOpcCtrl1.Groups;
		}

		private void cxsOpcCtrl1_OnDataChange(object sender, CXSOpc.CXSOpcCtrl.DataChangeArgs e)
		{
			DisplayText(textData, e.Value);
		}

		private void btnAGroup_Click(object sender, System.EventArgs e)
		{
			bool bState = btnAGroup.Text == "Activate" ? false : true;
			bState = !bState;
			cxsOpcCtrl1.Activate(selectedGroup,bState);
			btnAGroup.Text = bState ? "Deactivate" : "Activate";
		}

		private void btnAItem_Click(object sender, System.EventArgs e)
		{
			bool bState = btnAItem.Text == "Activate" ? false : true;
			bState = !bState;
			cxsOpcCtrl1.Activate(selectedGroup, selectedItem, bState);
			btnAItem.Text = bState ? "Deactivate" : "Activate";
		}

		private void btnSRead_Click(object sender, System.EventArgs e)
		{
			object o = null;
			string theItem = selectedItem;
			if(numElement.Enabled && numElement.Value != -1)
				theItem += "[" + numElement.Value.ToString() + "]";
			if(cxsOpcCtrl1.Read(selectedGroup, theItem, out o))
				DisplayText(textSRead, o);
			else
				HandleError("Failed to Read " + selectedGroup + "." + theItem);
		}

		private void btnSWrite_Click(object sender, System.EventArgs e)
		{
			string theItem = selectedItem;
			if(numElement.Enabled && numElement.Value != -1)
				theItem += "[" + numElement.Value.ToString() + "]";
			if(!cxsOpcCtrl1.Write(selectedGroup, theItem, textSWrite.Text))
				HandleError("Failed to Write " + selectedGroup + "." + selectedItem);
		}

		private void btnAsyncRead_Click(object sender, System.EventArgs e)
		{
			string theItem = selectedItem;
			if(numElement.Enabled && numElement.Value != -1)
				theItem += "[" + numElement.Value.ToString() + "]";
			if(!cxsOpcCtrl1.ReadAsync(selectedGroup, theItem))
				HandleError("Failed to Async Read " + selectedGroup + "." + theItem);	
		}

		private void cxsOpcCtrl1_OnReadComplete(object sender, CXSOpc.CXSOpcCtrl.ReadCompleteArgs e)
		{
			DisplayText(textARead, e.Value);
			string msg = "Read complete : ";
			msg += e.Quality == 0 ? "Quality Bad ":"Quality Good ";
			msg += " : " + e.Group + "." + e.Item;
			textMsg.Text = msg;
		}

		private void btnAsyncWrite_Click(object sender, System.EventArgs e)
		{
			string theItem = selectedItem;
			if(numElement.Enabled && numElement.Value != -1)
				theItem += "[" + numElement.Value.ToString() + "]";
			if(!cxsOpcCtrl1.WriteAsync(selectedGroup, theItem ,textAWrite.Text))
				HandleError("Failed to Async Write " + selectedGroup + "." + theItem);
		}

		private void cxsOpcCtrl1_OnWriteComplete(object sender, CXSOpc.CXSOpcCtrl.WriteCompleteArgs e)
		{
			string msg = "Write complete : ";
			msg += (e.Success) ? "Successful " : "Failed ";
			msg += " : " + e.Group + "." + e.Item;
			textMsg.Text = msg;
		}

		private void lbGroups_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			selectedGroup = (string)lbGroups.Items[lbGroups.SelectedIndex];
			lbItems.DataSource = cxsOpcCtrl1.Items(selectedGroup);
			btnAGroup.Text = cxsOpcCtrl1.IsActive(selectedGroup) ? "Deactivate" : "Activate";
		}

		private void lbItems_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			selectedItem = (string)lbItems.Items[lbItems.SelectedIndex];
			btnAItem.Text = cxsOpcCtrl1.IsActive(selectedGroup, selectedItem) ? "Deactivate" : "Activate";
			System.Type theType = cxsOpcCtrl1.GetType(selectedGroup, selectedItem);		
			numElement.Enabled = theType.IsArray;
		}

		private void btnGetData_Click(object sender, System.EventArgs e)
		{
			DataGroup = (string)lbGroups.Items[lbGroups.SelectedIndex];
			DataItem = (string)lbItems.Items[lbItems.SelectedIndex];
			cxsOpcCtrl1.GetData(DataGroup,DataItem);
			textGDName.Text = DataGroup + "." + DataItem;
			btnGetData.Enabled = false;
			btnStopData.Enabled = true;
		}

		private void btnStopData_Click(object sender, System.EventArgs e)
		{
			cxsOpcCtrl1.StopData(DataGroup, DataItem);
			btnGetData.Enabled = true;
			btnStopData.Enabled = false;

		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{
			cxsOpcCtrl1.Disconnect();
		}


		private void DisplayText(TextBox theBox, object value)
		{
			theBox.Clear();
			string text = "";
			if(value.GetType().IsArray)
			{
				foreach(object o in (Array)value)		
					text += o.ToString() + ", ";
				theBox.Text = text.Substring(0, text.Length - 2);
			}
			else
				theBox.Text = value.ToString();
		}

		private void HandleError(string Msg)
		{	
			const string comment = "\nCheck Group and Item Names and Valid Type";
			string theMsg = Msg + comment;
			MessageBox.Show(theMsg);
		}

	}
}
