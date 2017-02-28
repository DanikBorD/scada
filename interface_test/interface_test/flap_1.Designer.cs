namespace interface_test
{
    partial class flap_1
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
            this.openButton_1 = new System.Windows.Forms.Button();
            this.closeButton_1 = new System.Windows.Forms.Button();
            this.conditionLabel_1 = new System.Windows.Forms.Label();
            this.autoButton_1 = new System.Windows.Forms.Button();
            this.getConditionButton_1 = new System.Windows.Forms.Button();
            this.messegeListFlap_1 = new System.Windows.Forms.TextBox();
            this.flapValue_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openButton_1
            // 
            this.openButton_1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.openButton_1.Location = new System.Drawing.Point(12, 83);
            this.openButton_1.Name = "openButton_1";
            this.openButton_1.Size = new System.Drawing.Size(75, 23);
            this.openButton_1.TabIndex = 0;
            this.openButton_1.Text = "Открыть";
            this.openButton_1.UseVisualStyleBackColor = false;
            this.openButton_1.Click += new System.EventHandler(this.openButton_1_Click);
            // 
            // closeButton_1
            // 
            this.closeButton_1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.closeButton_1.Location = new System.Drawing.Point(112, 83);
            this.closeButton_1.Name = "closeButton_1";
            this.closeButton_1.Size = new System.Drawing.Size(75, 23);
            this.closeButton_1.TabIndex = 1;
            this.closeButton_1.Text = "Закрыть";
            this.closeButton_1.UseVisualStyleBackColor = false;
            this.closeButton_1.Click += new System.EventHandler(this.closeButton_1_Click);
            // 
            // conditionLabel_1
            // 
            this.conditionLabel_1.AutoSize = true;
            this.conditionLabel_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conditionLabel_1.Location = new System.Drawing.Point(12, 9);
            this.conditionLabel_1.Name = "conditionLabel_1";
            this.conditionLabel_1.Size = new System.Drawing.Size(0, 42);
            this.conditionLabel_1.TabIndex = 2;
            // 
            // autoButton_1
            // 
            this.autoButton_1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.autoButton_1.Location = new System.Drawing.Point(12, 157);
            this.autoButton_1.Name = "autoButton_1";
            this.autoButton_1.Size = new System.Drawing.Size(175, 23);
            this.autoButton_1.TabIndex = 3;
            this.autoButton_1.Text = "Автоматическое действие";
            this.autoButton_1.UseVisualStyleBackColor = false;
            this.autoButton_1.Click += new System.EventHandler(this.autoButton_1_Click);
            // 
            // getConditionButton_1
            // 
            this.getConditionButton_1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.getConditionButton_1.Location = new System.Drawing.Point(12, 128);
            this.getConditionButton_1.Name = "getConditionButton_1";
            this.getConditionButton_1.Size = new System.Drawing.Size(75, 23);
            this.getConditionButton_1.TabIndex = 4;
            this.getConditionButton_1.Text = "Значение";
            this.getConditionButton_1.UseVisualStyleBackColor = false;
            this.getConditionButton_1.Click += new System.EventHandler(this.getConditionButton_1_Click);
            // 
            // messegeListFlap_1
            // 
            this.messegeListFlap_1.Location = new System.Drawing.Point(233, 9);
            this.messegeListFlap_1.Multiline = true;
            this.messegeListFlap_1.Name = "messegeListFlap_1";
            this.messegeListFlap_1.Size = new System.Drawing.Size(246, 178);
            this.messegeListFlap_1.TabIndex = 17;
            // 
            // flapValue_1
            // 
            this.flapValue_1.Location = new System.Drawing.Point(112, 131);
            this.flapValue_1.Name = "flapValue_1";
            this.flapValue_1.Size = new System.Drawing.Size(75, 20);
            this.flapValue_1.TabIndex = 18;
            // 
            // flap_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(491, 192);
            this.Controls.Add(this.flapValue_1);
            this.Controls.Add(this.messegeListFlap_1);
            this.Controls.Add(this.getConditionButton_1);
            this.Controls.Add(this.autoButton_1);
            this.Controls.Add(this.conditionLabel_1);
            this.Controls.Add(this.closeButton_1);
            this.Controls.Add(this.openButton_1);
            this.Name = "flap_1";
            this.Text = "Заслонка 1";
            this.Load += new System.EventHandler(this.flap_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openButton_1;
        private System.Windows.Forms.Button closeButton_1;
        private System.Windows.Forms.Label conditionLabel_1;
        private System.Windows.Forms.Button autoButton_1;
        private System.Windows.Forms.Button getConditionButton_1;
        private System.Windows.Forms.TextBox messegeListFlap_1;
        private System.Windows.Forms.TextBox flapValue_1;
    }
}