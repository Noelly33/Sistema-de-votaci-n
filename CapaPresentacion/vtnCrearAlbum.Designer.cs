namespace CapaPresentacion
{
    partial class vtnCrearAlbum
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
            this.tablaCandidata = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasatiempos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aspiraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCandidata
            // 
            this.tablaCandidata.AllowUserToAddRows = false;
            this.tablaCandidata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCandidata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.ID,
            this.Cedula,
            this.Nombres_Completo,
            this.Carrera,
            this.Semestre,
            this.Pasatiempos,
            this.Habilidades,
            this.Intereses,
            this.Aspiraciones});
            this.tablaCandidata.Location = new System.Drawing.Point(41, 169);
            this.tablaCandidata.MultiSelect = false;
            this.tablaCandidata.Name = "tablaCandidata";
            this.tablaCandidata.ReadOnly = true;
            this.tablaCandidata.Size = new System.Drawing.Size(844, 141);
            this.tablaCandidata.TabIndex = 16;
            this.tablaCandidata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCandidata_CellContentClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Text = "";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombres_Completo
            // 
            this.Nombres_Completo.HeaderText = "Nombres_Completo";
            this.Nombres_Completo.Name = "Nombres_Completo";
            this.Nombres_Completo.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            // 
            // Semestre
            // 
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.Name = "Semestre";
            this.Semestre.ReadOnly = true;
            // 
            // Pasatiempos
            // 
            this.Pasatiempos.HeaderText = "Pasatiempos";
            this.Pasatiempos.Name = "Pasatiempos";
            this.Pasatiempos.ReadOnly = true;
            // 
            // Habilidades
            // 
            this.Habilidades.HeaderText = "Habilidades";
            this.Habilidades.Name = "Habilidades";
            this.Habilidades.ReadOnly = true;
            // 
            // Intereses
            // 
            this.Intereses.HeaderText = "Intereses";
            this.Intereses.Name = "Intereses";
            this.Intereses.ReadOnly = true;
            // 
            // Aspiraciones
            // 
            this.Aspiraciones.HeaderText = "Aspiraciones";
            this.Aspiraciones.Name = "Aspiraciones";
            this.Aspiraciones.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Crear Albúm ";
            // 
            // vtnCrearAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 420);
            this.Controls.Add(this.tablaCandidata);
            this.Controls.Add(this.label1);
            this.Name = "vtnCrearAlbum";
            this.Text = "vtnAlbum";
            this.Load += new System.EventHandler(this.vtnAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCandidata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasatiempos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aspiraciones;
    }
}