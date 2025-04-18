namespace CapaPresentacion
{
    partial class votacionReina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTipoVotacion = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.Aspiraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habilidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasatiempos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres_Completo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tablaCandidata = new System.Windows.Forms.DataGridView();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblCandidata = new System.Windows.Forms.Label();
            this.btnVotar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBoxCandidata = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipoVotacion
            // 
            this.txtTipoVotacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoVotacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVotacion.Location = new System.Drawing.Point(424, 31);
            this.txtTipoVotacion.Name = "txtTipoVotacion";
            this.txtTipoVotacion.Size = new System.Drawing.Size(84, 20);
            this.txtTipoVotacion.TabIndex = 162;
            this.txtTipoVotacion.Text = "Reina FCMF";
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(138, 54);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(24, 20);
            this.txtIndice.TabIndex = 161;
            this.txtIndice.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(65, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 160;
            this.lblID.Text = "ID";
            // 
            // Aspiraciones
            // 
            this.Aspiraciones.HeaderText = "Aspiraciones";
            this.Aspiraciones.MinimumWidth = 6;
            this.Aspiraciones.Name = "Aspiraciones";
            this.Aspiraciones.ReadOnly = true;
            this.Aspiraciones.Width = 110;
            // 
            // Habilidades
            // 
            this.Habilidades.HeaderText = "Habilidades";
            this.Habilidades.MinimumWidth = 6;
            this.Habilidades.Name = "Habilidades";
            this.Habilidades.ReadOnly = true;
            this.Habilidades.Width = 125;
            // 
            // Intereses
            // 
            this.Intereses.HeaderText = "Intereses";
            this.Intereses.MinimumWidth = 6;
            this.Intereses.Name = "Intereses";
            this.Intereses.ReadOnly = true;
            this.Intereses.Width = 125;
            // 
            // Pasatiempos
            // 
            this.Pasatiempos.FillWeight = 180F;
            this.Pasatiempos.HeaderText = "Pasatiempos";
            this.Pasatiempos.MinimumWidth = 6;
            this.Pasatiempos.Name = "Pasatiempos";
            this.Pasatiempos.ReadOnly = true;
            this.Pasatiempos.Width = 198;
            // 
            // Semestre
            // 
            this.Semestre.FillWeight = 120F;
            this.Semestre.HeaderText = "Semestre";
            this.Semestre.MinimumWidth = 6;
            this.Semestre.Name = "Semestre";
            this.Semestre.ReadOnly = true;
            this.Semestre.Width = 131;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 6;
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 125;
            // 
            // Nombres_Completo
            // 
            this.Nombres_Completo.FillWeight = 150F;
            this.Nombres_Completo.HeaderText = "Nombres_Completo";
            this.Nombres_Completo.MinimumWidth = 6;
            this.Nombres_Completo.Name = "Nombres_Completo";
            this.Nombres_Completo.ReadOnly = true;
            this.Nombres_Completo.Width = 164;
            // 
            // Cedula
            // 
            this.Cedula.FillWeight = 120F;
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 132;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id Candidata";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 50;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FillWeight = 30F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 6;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 33;
            // 
            // tablaCandidata
            // 
            this.tablaCandidata.AllowUserToAddRows = false;
            this.tablaCandidata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCandidata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablaCandidata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCandidata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.ID,
            this.Cedula,
            this.Nombres_Completo,
            this.Imagen,
            this.Carrera,
            this.Semestre,
            this.Pasatiempos,
            this.Intereses,
            this.Habilidades,
            this.Aspiraciones});
            this.tablaCandidata.Location = new System.Drawing.Point(68, 288);
            this.tablaCandidata.Margin = new System.Windows.Forms.Padding(2);
            this.tablaCandidata.MultiSelect = false;
            this.tablaCandidata.Name = "tablaCandidata";
            this.tablaCandidata.ReadOnly = true;
            this.tablaCandidata.RowHeadersWidth = 51;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaCandidata.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tablaCandidata.RowTemplate.Height = 28;
            this.tablaCandidata.Size = new System.Drawing.Size(788, 176);
            this.tablaCandidata.TabIndex = 159;
            this.tablaCandidata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCandidata_CellContentClick_1);
            this.tablaCandidata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.tablaCandidata_CellPainting_1);
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Image = global::CapaPresentacion.Properties.Resources.visto;
            this.Imagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagen.MinimumWidth = 6;
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Width = 150;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(575, 144);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(65, 21);
            this.lblCarrera.TabIndex = 156;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblCandidata
            // 
            this.lblCandidata.AutoSize = true;
            this.lblCandidata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidata.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCandidata.Location = new System.Drawing.Point(575, 79);
            this.lblCandidata.Name = "lblCandidata";
            this.lblCandidata.Size = new System.Drawing.Size(73, 21);
            this.lblCandidata.TabIndex = 155;
            this.lblCandidata.Text = "Nombre";
            // 
            // btnVotar
            // 
            this.btnVotar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVotar.Location = new System.Drawing.Point(757, 231);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(75, 23);
            this.btnVotar.TabIndex = 158;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = false;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click_1);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Imagen";
            this.dataGridViewImageColumn1.Image = global::CapaPresentacion.Properties.Resources.visto;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // pictureBoxCandidata
            // 
            this.pictureBoxCandidata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCandidata.Location = new System.Drawing.Point(717, 79);
            this.pictureBoxCandidata.Name = "pictureBoxCandidata";
            this.pictureBoxCandidata.Size = new System.Drawing.Size(139, 131);
            this.pictureBoxCandidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCandidata.TabIndex = 157;
            this.pictureBoxCandidata.TabStop = false;
            // 
            // votacionReina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 600);
            this.Controls.Add(this.txtTipoVotacion);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pictureBoxCandidata);
            this.Controls.Add(this.tablaCandidata);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblCandidata);
            this.Controls.Add(this.btnVotar);
            this.Name = "votacionReina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votacion de Reina de la Facultad";
            this.Load += new System.EventHandler(this.votacionReina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCandidata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTipoVotacion;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pictureBoxCandidata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aspiraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habilidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasatiempos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres_Completo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridView tablaCandidata;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblCandidata;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnVotar;
    }
}