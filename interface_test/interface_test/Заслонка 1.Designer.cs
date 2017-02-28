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
            this.trackOfDevation_1 = new System.Windows.Forms.TrackBar();
            this.angleOfDevation_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackOfDevation_1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackOfDevation_1
            // 
            this.trackOfDevation_1.Location = new System.Drawing.Point(7, 84);
            this.trackOfDevation_1.Name = "trackOfDevation_1";
            this.trackOfDevation_1.Size = new System.Drawing.Size(270, 45);
            this.trackOfDevation_1.TabIndex = 11;
            // 
            // angleOfDevation_1
            // 
            this.angleOfDevation_1.AutoSize = true;
            this.angleOfDevation_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleOfDevation_1.Location = new System.Drawing.Point(193, 33);
            this.angleOfDevation_1.Name = "angleOfDevation_1";
            this.angleOfDevation_1.Size = new System.Drawing.Size(44, 31);
            this.angleOfDevation_1.TabIndex = 10;
            this.angleOfDevation_1.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Угол отклонения:";
            // 
            // flap_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.trackOfDevation_1);
            this.Controls.Add(this.angleOfDevation_1);
            this.Controls.Add(this.label1);
            this.Name = "flap_1";
            this.Text = "Заслонка 1";
            ((System.ComponentModel.ISupportInitialize)(this.trackOfDevation_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackOfDevation_1;
        private System.Windows.Forms.Label angleOfDevation_1;
        private System.Windows.Forms.Label label1;
    }
}