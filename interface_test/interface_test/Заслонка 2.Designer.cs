﻿namespace interface_test
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
            this.trackOfDevation_2 = new System.Windows.Forms.TrackBar();
            this.angleOfDevation_2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackOfDevation_2)).BeginInit();
            this.SuspendLayout();
            // 
            // trackOfDevation_2
            // 
            this.trackOfDevation_2.Location = new System.Drawing.Point(2, 73);
            this.trackOfDevation_2.Name = "trackOfDevation_2";
            this.trackOfDevation_2.Size = new System.Drawing.Size(270, 45);
            this.trackOfDevation_2.TabIndex = 14;
            // 
            // angleOfDevation_2
            // 
            this.angleOfDevation_2.AutoSize = true;
            this.angleOfDevation_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.angleOfDevation_2.Location = new System.Drawing.Point(188, 22);
            this.angleOfDevation_2.Name = "angleOfDevation_2";
            this.angleOfDevation_2.Size = new System.Drawing.Size(44, 31);
            this.angleOfDevation_2.TabIndex = 13;
            this.angleOfDevation_2.Text = "30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Угол отклонения:";
            // 
            // flap_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.trackOfDevation_2);
            this.Controls.Add(this.angleOfDevation_2);
            this.Controls.Add(this.label1);
            this.Name = "flap_2";
            this.Text = "Заслонка 2";
            ((System.ComponentModel.ISupportInitialize)(this.trackOfDevation_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackOfDevation_2;
        private System.Windows.Forms.Label angleOfDevation_2;
        private System.Windows.Forms.Label label1;
    }
}