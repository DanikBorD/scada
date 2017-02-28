namespace interface_test
{
    partial class flap_2
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
            this.getConditionButton_2 = new System.Windows.Forms.Button();
            this.autoButton_2 = new System.Windows.Forms.Button();
            this.conditionLabel_2 = new System.Windows.Forms.Label();
            this.closeButton_2 = new System.Windows.Forms.Button();
            this.openButton_2 = new System.Windows.Forms.Button();
            this.flapValue_2 = new System.Windows.Forms.TextBox();
            this.messegeListFlap_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getConditionButton_2
            // 
            this.getConditionButton_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.getConditionButton_2.Location = new System.Drawing.Point(12, 125);
            this.getConditionButton_2.Name = "getConditionButton_2";
            this.getConditionButton_2.Size = new System.Drawing.Size(75, 23);
            this.getConditionButton_2.TabIndex = 9;
            this.getConditionButton_2.Text = "Значение";
            this.getConditionButton_2.UseVisualStyleBackColor = false;
            this.getConditionButton_2.Click += new System.EventHandler(this.getConditionButton_2_Click);
            // 
            // autoButton_2
            // 
            this.autoButton_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.autoButton_2.Location = new System.Drawing.Point(12, 154);
            this.autoButton_2.Name = "autoButton_2";
            this.autoButton_2.Size = new System.Drawing.Size(170, 23);
            this.autoButton_2.TabIndex = 8;
            this.autoButton_2.Text = "Автоматическое действие";
            this.autoButton_2.UseVisualStyleBackColor = false;
            this.autoButton_2.Click += new System.EventHandler(this.autoButton_2_Click);
            // 
            // conditionLabel_2
            // 
            this.conditionLabel_2.AutoSize = true;
            this.conditionLabel_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conditionLabel_2.Location = new System.Drawing.Point(12, 9);
            this.conditionLabel_2.Name = "conditionLabel_2";
            this.conditionLabel_2.Size = new System.Drawing.Size(0, 42);
            this.conditionLabel_2.TabIndex = 7;
            // 
            // closeButton_2
            // 
            this.closeButton_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.closeButton_2.Location = new System.Drawing.Point(107, 80);
            this.closeButton_2.Name = "closeButton_2";
            this.closeButton_2.Size = new System.Drawing.Size(75, 23);
            this.closeButton_2.TabIndex = 6;
            this.closeButton_2.Text = "Закрыть";
            this.closeButton_2.UseVisualStyleBackColor = false;
            this.closeButton_2.Click += new System.EventHandler(this.closeButton_2_Click);
            // 
            // openButton_2
            // 
            this.openButton_2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.openButton_2.Location = new System.Drawing.Point(12, 80);
            this.openButton_2.Name = "openButton_2";
            this.openButton_2.Size = new System.Drawing.Size(75, 23);
            this.openButton_2.TabIndex = 5;
            this.openButton_2.Text = "Открыть";
            this.openButton_2.UseVisualStyleBackColor = false;
            this.openButton_2.Click += new System.EventHandler(this.openButton_2_Click);
            // 
            // flapValue_2
            // 
            this.flapValue_2.Location = new System.Drawing.Point(107, 125);
            this.flapValue_2.Name = "flapValue_2";
            this.flapValue_2.Size = new System.Drawing.Size(75, 20);
            this.flapValue_2.TabIndex = 10;
            // 
            // messegeListFlap_2
            // 
            this.messegeListFlap_2.Location = new System.Drawing.Point(233, 9);
            this.messegeListFlap_2.Multiline = true;
            this.messegeListFlap_2.Name = "messegeListFlap_2";
            this.messegeListFlap_2.Size = new System.Drawing.Size(246, 178);
            this.messegeListFlap_2.TabIndex = 18;
            // 
            // flap_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(491, 192);
            this.Controls.Add(this.messegeListFlap_2);
            this.Controls.Add(this.flapValue_2);
            this.Controls.Add(this.getConditionButton_2);
            this.Controls.Add(this.autoButton_2);
            this.Controls.Add(this.conditionLabel_2);
            this.Controls.Add(this.closeButton_2);
            this.Controls.Add(this.openButton_2);
            this.Name = "flap_2";
            this.Text = "Заслонка 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getConditionButton_2;
        private System.Windows.Forms.Button autoButton_2;
        private System.Windows.Forms.Label conditionLabel_2;
        private System.Windows.Forms.Button closeButton_2;
        private System.Windows.Forms.Button openButton_2;
        private System.Windows.Forms.TextBox flapValue_2;
        private System.Windows.Forms.TextBox messegeListFlap_2;
    }
}