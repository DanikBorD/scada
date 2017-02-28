namespace interface_test
{
    partial class termometr_2
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
            this.temperatureValue_2 = new System.Windows.Forms.Label();
            this.getValueButton_2 = new System.Windows.Forms.Button();
            this.normal_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.differenceValue_2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelOfNormalize_2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.messegeList_2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // temperatureValue_2
            // 
            this.temperatureValue_2.AutoSize = true;
            this.temperatureValue_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureValue_2.Location = new System.Drawing.Point(188, 9);
            this.temperatureValue_2.Name = "temperatureValue_2";
            this.temperatureValue_2.Size = new System.Drawing.Size(0, 31);
            this.temperatureValue_2.TabIndex = 23;
            // 
            // getValueButton_2
            // 
            this.getValueButton_2.Location = new System.Drawing.Point(12, 12);
            this.getValueButton_2.Name = "getValueButton_2";
            this.getValueButton_2.Size = new System.Drawing.Size(103, 32);
            this.getValueButton_2.TabIndex = 22;
            this.getValueButton_2.Text = "GET";
            this.getValueButton_2.UseVisualStyleBackColor = true;
            this.getValueButton_2.Click += new System.EventHandler(this.getValueButton_2_Click);
            // 
            // normal_2
            // 
            this.normal_2.AutoSize = true;
            this.normal_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normal_2.Location = new System.Drawing.Point(188, 155);
            this.normal_2.Name = "normal_2";
            this.normal_2.Size = new System.Drawing.Size(0, 31);
            this.normal_2.TabIndex = 21;
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
            // differenceValue_2
            // 
            this.differenceValue_2.AutoSize = true;
            this.differenceValue_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.differenceValue_2.Location = new System.Drawing.Point(188, 108);
            this.differenceValue_2.Name = "differenceValue_2";
            this.differenceValue_2.Size = new System.Drawing.Size(0, 31);
            this.differenceValue_2.TabIndex = 19;
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
            // levelOfNormalize_2
            // 
            this.levelOfNormalize_2.AutoSize = true;
            this.levelOfNormalize_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelOfNormalize_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelOfNormalize_2.Location = new System.Drawing.Point(151, 55);
            this.levelOfNormalize_2.Name = "levelOfNormalize_2";
            this.levelOfNormalize_2.Size = new System.Drawing.Size(0, 31);
            this.levelOfNormalize_2.TabIndex = 17;
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
            // messegeList_2
            // 
            this.messegeList_2.Location = new System.Drawing.Point(237, 12);
            this.messegeList_2.Multiline = true;
            this.messegeList_2.Name = "messegeList_2";
            this.messegeList_2.Size = new System.Drawing.Size(246, 178);
            this.messegeList_2.TabIndex = 24;
            // 
            // termometr_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(495, 202);
            this.Controls.Add(this.messegeList_2);
            this.Controls.Add(this.temperatureValue_2);
            this.Controls.Add(this.getValueButton_2);
            this.Controls.Add(this.normal_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.differenceValue_2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelOfNormalize_2);
            this.Controls.Add(this.label3);
            this.Name = "termometr_2";
            this.Text = "Термометр 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperatureValue_2;
        private System.Windows.Forms.Button getValueButton_2;
        private System.Windows.Forms.Label normal_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label differenceValue_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelOfNormalize_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox messegeList_2;
    }
}