namespace interface_test
{
    partial class termometrForm_4
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
            this.differenceValue_4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.levelOfNormalize_4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.termometrValue_4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // differenceValue_4
            // 
            this.differenceValue_4.AutoSize = true;
            this.differenceValue_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.differenceValue_4.Location = new System.Drawing.Point(204, 129);
            this.differenceValue_4.Name = "differenceValue_4";
            this.differenceValue_4.Size = new System.Drawing.Size(29, 31);
            this.differenceValue_4.TabIndex = 17;
            this.differenceValue_4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(28, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Отклонение от нормы:";
            // 
            // levelOfNormalize_4
            // 
            this.levelOfNormalize_4.AutoSize = true;
            this.levelOfNormalize_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelOfNormalize_4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelOfNormalize_4.Location = new System.Drawing.Point(204, 79);
            this.levelOfNormalize_4.Name = "levelOfNormalize_4";
            this.levelOfNormalize_4.Size = new System.Drawing.Size(53, 31);
            this.levelOfNormalize_4.TabIndex = 15;
            this.levelOfNormalize_4.Text = "OK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Соответствие норме:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Показатель термометра: ";
            // 
            // termometrValue_4
            // 
            this.termometrValue_4.AutoSize = true;
            this.termometrValue_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termometrValue_4.Location = new System.Drawing.Point(204, 28);
            this.termometrValue_4.Name = "termometrValue_4";
            this.termometrValue_4.Size = new System.Drawing.Size(44, 31);
            this.termometrValue_4.TabIndex = 12;
            this.termometrValue_4.Text = "24";
            // 
            // termometrForm_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.differenceValue_4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelOfNormalize_4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.termometrValue_4);
            this.Name = "termometrForm_4";
            this.Text = "Термометр 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label differenceValue_4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelOfNormalize_4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label termometrValue_4;
    }
}