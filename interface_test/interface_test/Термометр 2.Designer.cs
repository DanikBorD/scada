namespace interface_test
{
    partial class termometrForm_2
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
            this.differenceValue_2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelOfNormalize_2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.termometrValue_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // differenceValue_2
            // 
            this.differenceValue_2.AutoSize = true;
            this.differenceValue_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.differenceValue_2.Location = new System.Drawing.Point(205, 118);
            this.differenceValue_2.Name = "differenceValue_2";
            this.differenceValue_2.Size = new System.Drawing.Size(29, 31);
            this.differenceValue_2.TabIndex = 17;
            this.differenceValue_2.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(29, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Отклонение от нормы:";
            // 
            // levelOfNormalize_2
            // 
            this.levelOfNormalize_2.AutoSize = true;
            this.levelOfNormalize_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelOfNormalize_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelOfNormalize_2.Location = new System.Drawing.Point(205, 68);
            this.levelOfNormalize_2.Name = "levelOfNormalize_2";
            this.levelOfNormalize_2.Size = new System.Drawing.Size(53, 31);
            this.levelOfNormalize_2.TabIndex = 15;
            this.levelOfNormalize_2.Text = "OK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Соответствие норме:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Показатель термометра: ";
            // 
            // termometrValue_2
            // 
            this.termometrValue_2.AutoSize = true;
            this.termometrValue_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termometrValue_2.Location = new System.Drawing.Point(205, 17);
            this.termometrValue_2.Name = "termometrValue_2";
            this.termometrValue_2.Size = new System.Drawing.Size(44, 31);
            this.termometrValue_2.TabIndex = 12;
            this.termometrValue_2.Text = "24";
            // 
            // termometrForm_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.differenceValue_2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelOfNormalize_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.termometrValue_2);
            this.Name = "termometrForm_2";
            this.Text = "Термометр 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label differenceValue_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelOfNormalize_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label termometrValue_2;
    }
}