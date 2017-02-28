namespace interface_test
{
    partial class termometr_4
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
            this.temperatureValue_4 = new System.Windows.Forms.Label();
            this.getValueButton_4 = new System.Windows.Forms.Button();
            this.normal_4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.differenceValue_4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelOfNormalize_4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.messegeList_4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // temperatureValue_4
            // 
            this.temperatureValue_4.AutoSize = true;
            this.temperatureValue_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureValue_4.Location = new System.Drawing.Point(188, 9);
            this.temperatureValue_4.Name = "temperatureValue_4";
            this.temperatureValue_4.Size = new System.Drawing.Size(0, 31);
            this.temperatureValue_4.TabIndex = 23;
            // 
            // getValueButton_4
            // 
            this.getValueButton_4.Location = new System.Drawing.Point(12, 12);
            this.getValueButton_4.Name = "getValueButton_4";
            this.getValueButton_4.Size = new System.Drawing.Size(103, 32);
            this.getValueButton_4.TabIndex = 22;
            this.getValueButton_4.Text = "GET";
            this.getValueButton_4.UseVisualStyleBackColor = true;
            this.getValueButton_4.Click += new System.EventHandler(this.getValueButton_4_Click);
            // 
            // normal_4
            // 
            this.normal_4.AutoSize = true;
            this.normal_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normal_4.Location = new System.Drawing.Point(188, 155);
            this.normal_4.Name = "normal_4";
            this.normal_4.Size = new System.Drawing.Size(0, 31);
            this.normal_4.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Нормальная температура:";
            // 
            // differenceValue_4
            // 
            this.differenceValue_4.AutoSize = true;
            this.differenceValue_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.differenceValue_4.Location = new System.Drawing.Point(188, 108);
            this.differenceValue_4.Name = "differenceValue_4";
            this.differenceValue_4.Size = new System.Drawing.Size(0, 31);
            this.differenceValue_4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Отклонение от нормы:";
            // 
            // levelOfNormalize_4
            // 
            this.levelOfNormalize_4.AutoSize = true;
            this.levelOfNormalize_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelOfNormalize_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelOfNormalize_4.Location = new System.Drawing.Point(151, 58);
            this.levelOfNormalize_4.Name = "levelOfNormalize_4";
            this.levelOfNormalize_4.Size = new System.Drawing.Size(0, 31);
            this.levelOfNormalize_4.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Соответствие норме:";
            // 
            // messegeList_4
            // 
            this.messegeList_4.Location = new System.Drawing.Point(237, 12);
            this.messegeList_4.Multiline = true;
            this.messegeList_4.Name = "messegeList_4";
            this.messegeList_4.Size = new System.Drawing.Size(246, 178);
            this.messegeList_4.TabIndex = 24;
            // 
            // termometr_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(495, 202);
            this.Controls.Add(this.messegeList_4);
            this.Controls.Add(this.temperatureValue_4);
            this.Controls.Add(this.getValueButton_4);
            this.Controls.Add(this.normal_4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.differenceValue_4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelOfNormalize_4);
            this.Controls.Add(this.label3);
            this.Name = "termometr_4";
            this.Text = "Термометр 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperatureValue_4;
        private System.Windows.Forms.Button getValueButton_4;
        private System.Windows.Forms.Label normal_4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label differenceValue_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelOfNormalize_4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messegeList_4;
    }
}