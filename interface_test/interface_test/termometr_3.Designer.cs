namespace interface_test
{
    partial class termometr_3
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
            this.temperatureValue_3 = new System.Windows.Forms.Label();
            this.getValueButton_3 = new System.Windows.Forms.Button();
            this.normal_3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.differenceValue_3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelOfNormalize_3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.messegeList_3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // temperatureValue_3
            // 
            this.temperatureValue_3.AutoSize = true;
            this.temperatureValue_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureValue_3.Location = new System.Drawing.Point(188, 9);
            this.temperatureValue_3.Name = "temperatureValue_3";
            this.temperatureValue_3.Size = new System.Drawing.Size(0, 31);
            this.temperatureValue_3.TabIndex = 23;
            // 
            // getValueButton_3
            // 
            this.getValueButton_3.Location = new System.Drawing.Point(12, 12);
            this.getValueButton_3.Name = "getValueButton_3";
            this.getValueButton_3.Size = new System.Drawing.Size(103, 32);
            this.getValueButton_3.TabIndex = 22;
            this.getValueButton_3.Text = "GET";
            this.getValueButton_3.UseVisualStyleBackColor = true;
            this.getValueButton_3.Click += new System.EventHandler(this.getValueButton_3_Click);
            // 
            // normal_3
            // 
            this.normal_3.AutoSize = true;
            this.normal_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normal_3.Location = new System.Drawing.Point(188, 155);
            this.normal_3.Name = "normal_3";
            this.normal_3.Size = new System.Drawing.Size(0, 31);
            this.normal_3.TabIndex = 21;
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
            // differenceValue_3
            // 
            this.differenceValue_3.AutoSize = true;
            this.differenceValue_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.differenceValue_3.Location = new System.Drawing.Point(188, 108);
            this.differenceValue_3.Name = "differenceValue_3";
            this.differenceValue_3.Size = new System.Drawing.Size(0, 31);
            this.differenceValue_3.TabIndex = 19;
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
            // levelOfNormalize_3
            // 
            this.levelOfNormalize_3.AutoSize = true;
            this.levelOfNormalize_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelOfNormalize_3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelOfNormalize_3.Location = new System.Drawing.Point(151, 58);
            this.levelOfNormalize_3.Name = "levelOfNormalize_3";
            this.levelOfNormalize_3.Size = new System.Drawing.Size(0, 31);
            this.levelOfNormalize_3.TabIndex = 17;
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
            // messegeList_3
            // 
            this.messegeList_3.Location = new System.Drawing.Point(237, 12);
            this.messegeList_3.Multiline = true;
            this.messegeList_3.Name = "messegeList_3";
            this.messegeList_3.Size = new System.Drawing.Size(246, 178);
            this.messegeList_3.TabIndex = 24;
            // 
            // termometr_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(495, 202);
            this.Controls.Add(this.messegeList_3);
            this.Controls.Add(this.temperatureValue_3);
            this.Controls.Add(this.getValueButton_3);
            this.Controls.Add(this.normal_3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.differenceValue_3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelOfNormalize_3);
            this.Controls.Add(this.label3);
            this.Name = "termometr_3";
            this.Text = "Термометр 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperatureValue_3;
        private System.Windows.Forms.Button getValueButton_3;
        private System.Windows.Forms.Label normal_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label differenceValue_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelOfNormalize_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messegeList_3;
    }
}