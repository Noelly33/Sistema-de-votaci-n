namespace CapaPresentacion
{
    partial class vtnResultados
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lblResultados = new System.Windows.Forms.Label();
            this.resultadoFotogenia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultadoReina = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoFotogenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoReina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(371, 29);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(191, 21);
            this.lblResultados.TabIndex = 1;
            this.lblResultados.Text = "Resultados de votación ";
            // 
            // resultadoFotogenia
            // 
            chartArea1.Name = "ChartArea1";
            this.resultadoFotogenia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resultadoFotogenia.Legends.Add(legend1);
            this.resultadoFotogenia.Location = new System.Drawing.Point(66, 128);
            this.resultadoFotogenia.Name = "resultadoFotogenia";
            this.resultadoFotogenia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.resultadoFotogenia.Size = new System.Drawing.Size(300, 300);
            this.resultadoFotogenia.TabIndex = 2;
            this.resultadoFotogenia.Text = "Miss Fotogenia";
            // 
            // resultadoReina
            // 
            chartArea2.Name = "ChartArea1";
            this.resultadoReina.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.resultadoReina.Legends.Add(legend2);
            this.resultadoReina.Location = new System.Drawing.Point(567, 128);
            this.resultadoReina.Name = "resultadoReina";
            this.resultadoReina.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.resultadoReina.Size = new System.Drawing.Size(300, 300);
            this.resultadoReina.TabIndex = 3;
            this.resultadoReina.Text = "Reina de la Facultad";
            // 
            // vtnResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 482);
            this.Controls.Add(this.resultadoReina);
            this.Controls.Add(this.resultadoFotogenia);
            this.Controls.Add(this.lblResultados);
            this.Name = "vtnResultados";
            this.Text = "vtnResultados";
            this.Load += new System.EventHandler(this.vtnResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoFotogenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoReina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultadoFotogenia;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultadoReina;
    }
}