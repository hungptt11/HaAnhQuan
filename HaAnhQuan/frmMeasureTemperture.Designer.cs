
namespace HaAnhQuan
{
    partial class frmCoolingReport
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
            this.btnProgress = new System.Windows.Forms.Button();
            this.lblStartingTemp = new System.Windows.Forms.Label();
            this.txtStartingTemp = new System.Windows.Forms.TextBox();
            this.txtCurrentTemp = new System.Windows.Forms.TextBox();
            this.lblCurrentTemp = new System.Windows.Forms.Label();
            this.lblProgressReport = new System.Windows.Forms.Label();
            this.lblHeighest = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblZero = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressTemp = new HaAnhQuan.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(35, 207);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(82, 43);
            this.btnProgress.TabIndex = 0;
            this.btnProgress.Text = "Progress";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // lblStartingTemp
            // 
            this.lblStartingTemp.AutoSize = true;
            this.lblStartingTemp.Location = new System.Drawing.Point(32, 60);
            this.lblStartingTemp.Name = "lblStartingTemp";
            this.lblStartingTemp.Size = new System.Drawing.Size(143, 17);
            this.lblStartingTemp.TabIndex = 2;
            this.lblStartingTemp.Text = "Starting Temperature";
            // 
            // txtStartingTemp
            // 
            this.txtStartingTemp.Location = new System.Drawing.Point(35, 84);
            this.txtStartingTemp.Name = "txtStartingTemp";
            this.txtStartingTemp.Size = new System.Drawing.Size(157, 22);
            this.txtStartingTemp.TabIndex = 3;
            this.txtStartingTemp.Text = "95";
            this.txtStartingTemp.Leave += new System.EventHandler(this.txtStartingTemp_Leave);
            // 
            // txtCurrentTemp
            // 
            this.txtCurrentTemp.Location = new System.Drawing.Point(35, 153);
            this.txtCurrentTemp.Name = "txtCurrentTemp";
            this.txtCurrentTemp.Size = new System.Drawing.Size(157, 22);
            this.txtCurrentTemp.TabIndex = 3;
            this.txtCurrentTemp.Text = "42";
            // 
            // lblCurrentTemp
            // 
            this.lblCurrentTemp.AutoSize = true;
            this.lblCurrentTemp.Location = new System.Drawing.Point(32, 133);
            this.lblCurrentTemp.Name = "lblCurrentTemp";
            this.lblCurrentTemp.Size = new System.Drawing.Size(141, 17);
            this.lblCurrentTemp.TabIndex = 2;
            this.lblCurrentTemp.Text = "Current Temperature";
            // 
            // lblProgressReport
            // 
            this.lblProgressReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressReport.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProgressReport.Location = new System.Drawing.Point(30, 279);
            this.lblProgressReport.Name = "lblProgressReport";
            this.lblProgressReport.Size = new System.Drawing.Size(259, 157);
            this.lblProgressReport.TabIndex = 4;
            this.lblProgressReport.Text = "Progress Report :";
            // 
            // lblHeighest
            // 
            this.lblHeighest.AutoSize = true;
            this.lblHeighest.Location = new System.Drawing.Point(401, 49);
            this.lblHeighest.Name = "lblHeighest";
            this.lblHeighest.Size = new System.Drawing.Size(24, 17);
            this.lblHeighest.TabIndex = 2;
            this.lblHeighest.Text = "95";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.BackColor = System.Drawing.SystemColors.Control;
            this.lblMiddle.Location = new System.Drawing.Point(401, 189);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(24, 17);
            this.lblMiddle.TabIndex = 2;
            this.lblMiddle.Text = "47";
            // 
            // lblZero
            // 
            this.lblZero.AutoSize = true;
            this.lblZero.Location = new System.Drawing.Point(401, 325);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(16, 17);
            this.lblZero.TabIndex = 2;
            this.lblZero.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(327, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 293);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // progressTemp
            // 
            this.progressTemp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.progressTemp.Location = new System.Drawing.Point(344, 49);
            this.progressTemp.Name = "progressTemp";
            this.progressTemp.Size = new System.Drawing.Size(37, 293);
            this.progressTemp.TabIndex = 1;
            // 
            // frmCoolingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 483);
            this.Controls.Add(this.lblProgressReport);
            this.Controls.Add(this.txtCurrentTemp);
            this.Controls.Add(this.txtStartingTemp);
            this.Controls.Add(this.lblCurrentTemp);
            this.Controls.Add(this.lblZero);
            this.Controls.Add(this.lblMiddle);
            this.Controls.Add(this.lblHeighest);
            this.Controls.Add(this.lblStartingTemp);
            this.Controls.Add(this.progressTemp);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCoolingReport";
            this.Text = "Cooling Report";
            this.Load += new System.EventHandler(this.frmCoolingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProgress;
        private VerticalProgressBar progressTemp;
        private System.Windows.Forms.Label lblStartingTemp;
        private System.Windows.Forms.TextBox txtStartingTemp;
        private System.Windows.Forms.TextBox txtCurrentTemp;
        private System.Windows.Forms.Label lblCurrentTemp;
        private System.Windows.Forms.Label lblProgressReport;
        private System.Windows.Forms.Label lblHeighest;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

