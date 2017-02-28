namespace interface_test
{
    partial class Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect_ip = new System.Windows.Forms.TextBox();
            this.connect_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.connectionDataRead = new System.Windows.Forms.Button();
            this.messegeList_connect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connect_ip
            // 
            this.connect_ip.Location = new System.Drawing.Point(63, 15);
            this.connect_ip.Name = "connect_ip";
            this.connect_ip.Size = new System.Drawing.Size(100, 20);
            this.connect_ip.TabIndex = 0;
            // 
            // connect_port
            // 
            this.connect_port.Location = new System.Drawing.Point(63, 59);
            this.connect_port.Name = "connect_port";
            this.connect_port.Size = new System.Drawing.Size(100, 20);
            this.connect_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(12, 120);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(151, 23);
            this.connect_button.TabIndex = 4;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;

            // 
            // connectionDataRead
            // 
            this.connectionDataRead.Location = new System.Drawing.Point(12, 164);
            this.connectionDataRead.Name = "connectionDataRead";
            this.connectionDataRead.Size = new System.Drawing.Size(151, 23);
            this.connectionDataRead.TabIndex = 5;
            this.connectionDataRead.Text = "Connection Data Read";
            this.connectionDataRead.UseVisualStyleBackColor = true;

            // 
            // messegeList_connect
            // 
            this.messegeList_connect.Location = new System.Drawing.Point(183, 12);
            this.messegeList_connect.Multiline = true;
            this.messegeList_connect.Name = "messegeList_connect";
            this.messegeList_connect.Size = new System.Drawing.Size(251, 175);
            this.messegeList_connect.TabIndex = 6;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 199);
            this.Controls.Add(this.messegeList_connect);
            this.Controls.Add(this.connectionDataRead);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect_port);
            this.Controls.Add(this.connect_ip);
            this.Name = "Connect";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox connect_ip;
        private System.Windows.Forms.TextBox connect_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button connectionDataRead;
        private System.Windows.Forms.TextBox messegeList_connect;
    }
}