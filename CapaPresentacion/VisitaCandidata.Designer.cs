namespace CapaPresentacion
{
    partial class VisitaCandidata
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
            this.flwVisitaCandidata = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCandidata = new System.Windows.Forms.Label();
            this.btnPortafolio = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.flwVisitaCandidata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flwVisitaCandidata
            // 
            this.flwVisitaCandidata.BackColor = System.Drawing.Color.White;
            this.flwVisitaCandidata.Controls.Add(this.pictureBox1);
            this.flwVisitaCandidata.Controls.Add(this.lblCandidata);
            this.flwVisitaCandidata.Controls.Add(this.btnPortafolio);
            this.flwVisitaCandidata.Controls.Add(this.btnAlbum);
            this.flwVisitaCandidata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwVisitaCandidata.Location = new System.Drawing.Point(0, 0);
            this.flwVisitaCandidata.Name = "flwVisitaCandidata";
            this.flwVisitaCandidata.Size = new System.Drawing.Size(948, 600);
            this.flwVisitaCandidata.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCandidata
            // 
            this.lblCandidata.AutoSize = true;
            this.lblCandidata.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidata.Location = new System.Drawing.Point(166, 0);
            this.lblCandidata.Name = "lblCandidata";
            this.lblCandidata.Size = new System.Drawing.Size(41, 17);
            this.lblCandidata.TabIndex = 1;
            this.lblCandidata.Text = "label1";
            // 
            // btnPortafolio
            // 
            this.btnPortafolio.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPortafolio.Location = new System.Drawing.Point(213, 3);
            this.btnPortafolio.Name = "btnPortafolio";
            this.btnPortafolio.Size = new System.Drawing.Size(75, 23);
            this.btnPortafolio.TabIndex = 2;
            this.btnPortafolio.Text = "Portafolio";
            this.btnPortafolio.UseVisualStyleBackColor = false;
            // 
            // btnAlbum
            // 
            this.btnAlbum.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAlbum.Location = new System.Drawing.Point(294, 3);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnAlbum.TabIndex = 3;
            this.btnAlbum.Text = "Album";
            this.btnAlbum.UseVisualStyleBackColor = false;
            // 
            // VisitaCandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 600);
            this.Controls.Add(this.flwVisitaCandidata);
            this.Name = "VisitaCandidata";
            this.Text = "VisitaCandidata";
            this.Load += new System.EventHandler(this.VisitaCandidata_Load);
            this.flwVisitaCandidata.ResumeLayout(false);
            this.flwVisitaCandidata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwVisitaCandidata;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCandidata;
        private System.Windows.Forms.Button btnPortafolio;
        private System.Windows.Forms.Button btnAlbum;
    }
}