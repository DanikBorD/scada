namespace interface_test
{
    partial class termometrForm_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.termometrValue_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // differenceValue_1
            // 
            this.differenceValue_1.AutoSize = true;
            this.differenceValue_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.differenceValue_1.Location = new System.Drawing.Point(205, 131);
            this.differenceValue_1.Name = "differenceValue_1";
            this.differenceValue_1.Size = new System.Drawing.Size(29, 31);
            this.differenceValue_1.TabIndex = 11;
            this.differenceValue_1.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(29, 146);
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
            this.levelOfNormalize_1.Location = new System.Drawing.Point(205, 81);
            this.levelOfNormalize_1.Name = "levelOfNormalize_1";
            this.levelOfNormalize_1.Size = new System.Drawing.Size(53, 31);
            this.levelOfNormalize_1.TabIndex = 9;
            this.levelOfNormalize_1.Text = "OK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Соответствие норме:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Показатель термометра: ";
            // 
            // termometrValue_1
            // 
            this.termometrValue_1.AutoSize = true;
            this.termometrValue_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.termometrValue_1.Location = new System.Drawing.Point(205, 30);
            this.termometrValue_1.Name = "termometrValue_1";
            this.termometrValue_1.Size = new System.Drawing.Size(44, 31);
            this.termometrValue_1.TabIndex = 6;
            this.termometrValue_1.Text = "24";
            // 
            // termometrForm_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.differenceValue_1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelOfNormalize_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.termometrValue_1);
            this.Name = "termometrForm_1";
            this.Text = "Термометр 1";
            this.Load += new System.EventHandler(this.Температура_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label differenceValue_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelOfNormalize_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label termometrValue_1;
    }
}