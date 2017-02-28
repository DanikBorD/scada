namespace interface_test
{
    partial class termometr_1
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
            this.differenceValue_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelOfNormalize_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.normal_1 = new System.Windows.Forms.Label();
            this.getValueButton_1 = new System.Windows.Forms.Button();
            this.temperatureValue_1 = new System.Windows.Forms.Label();
            this.messegeList_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // differenceValue_1
            // 
            this.differenceValue_1.AutoSize = true;
            this.differenceValue_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.differenceValue_1.Location = new System.Drawing.Point(188, 108);
            this.differenceValue_1.Name = "differenceValue_1";
            this.differenceValue_1.Size = new System.Drawing.Size(0, 31);
            this.differenceValue_1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отклонение от нормы:";
            // 
            // levelOfNormalize_1
            // 
            this.levelOfNormalize_1.AutoSize = true;
            this.levelOfNormalize_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelOfNormalize_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelOfNormalize_1.Location = new System.Drawing.Point(151, 58);
            this.levelOfNormalize_1.Name = "levelOfNormalize_1";
            this.levelOfNormalize_1.Size = new System.Drawing.Size(0, 31);
            this.levelOfNormalize_1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Соответствие норме:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Нормальная температура:";
            // 
            // normal_1
            // 
            this.normal_1.AutoSize = true;
            this.normal_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normal_1.Location = new System.Drawing.Point(188, 155);
            this.normal_1.Name = "normal_1";
            this.normal_1.Size = new System.Drawing.Size(0, 31);
            this.normal_1.TabIndex = 13;
            // 
            // getValueButton_1
            // 
            this.getValueButton_1.Location = new System.Drawing.Point(12, 12);
            this.getValueButton_1.Name = "getValueButton_1";
            this.getValueButton_1.Size = new System.Drawing.Size(103, 32);
            this.getValueButton_1.TabIndex = 14;
            this.getValueButton_1.Text = "GET";
            this.getValueButton_1.UseVisualStyleBackColor = true;
            this.getValueButton_1.Click += new System.EventHandler(this.getValueButton_1_Click);
            // 
            // temperatureValue_1
            // 
            this.temperatureValue_1.AutoSize = true;
            this.temperatureValue_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureValue_1.Location = new System.Drawing.Point(188, 9);
            this.temperatureValue_1.Name = "temperatureValue_1";
            this.temperatureValue_1.Size = new System.Drawing.Size(0, 31);
            this.temperatureValue_1.TabIndex = 15;
            // 
            // messegeList_1
            // 
            this.messegeList_1.Location = new System.Drawing.Point(237, 12);
            this.messegeList_1.Multiline = true;
            this.messegeList_1.Name = "messegeList_1";
            this.messegeList_1.Size = new System.Drawing.Size(246, 178);
            this.messegeList_1.TabIndex = 16;
            // 
            // termometr_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(495, 202);
            this.Controls.Add(this.messegeList_1);
            this.Controls.Add(this.temperatureValue_1);
            this.Controls.Add(this.getValueButton_1);
            this.Controls.Add(this.normal_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.differenceValue_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelOfNormalize_1);
            this.Controls.Add(this.label3);
            this.Name = "termometr_1";
            this.Text = "Термометр 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label differenceValue_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelOfNormalize_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label normal_1;
        private System.Windows.Forms.Button getValueButton_1;
        private System.Windows.Forms.Label temperatureValue_1;
        private System.Windows.Forms.TextBox messegeList_1;
    }
}