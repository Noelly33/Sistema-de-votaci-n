namespace CapaPresentacion
{
    partial class vtnMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vtnMenu));
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBoxVoto = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCandidata = new System.Windows.Forms.ToolStripMenuItem();
            this.verCandidatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVisitaCandidata = new System.Windows.Forms.ToolStripMenuItem();
            this.visitaDeCandidatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAlbúmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVotacion = new System.Windows.Forms.ToolStripMenuItem();
            this.missFotogeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reinaDeLaFacultadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResultado = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoto)).BeginInit();
            this.menuPrincipal.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.AutoSize = false;
            this.menu1.BackColor = System.Drawing.Color.White;
            this.menu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menu1.Size = new System.Drawing.Size(951, 72);
            this.menu1.TabIndex = 3;
            this.menu1.Text = "menuStrip1";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.White;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(863, 27);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(41, 17);
            this.lblHora.TabIndex = 20;
            this.lblHora.Text = "hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(9, 7);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 17);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.White;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(9, 41);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(107, 17);
            this.lblNombres.TabIndex = 26;
            this.lblNombres.Text = "usuarioActual";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(150, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.pictureBoxVoto);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 131);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(951, 473);
            this.panelPrincipal.TabIndex = 24;
            // 
            // pictureBoxVoto
            // 
            this.pictureBoxVoto.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVoto.Image")));
            this.pictureBoxVoto.Location = new System.Drawing.Point(315, 75);
            this.pictureBoxVoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxVoto.Name = "pictureBoxVoto";
            this.pictureBoxVoto.Size = new System.Drawing.Size(314, 342);
            this.pictureBoxVoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVoto.TabIndex = 0;
            this.pictureBoxVoto.TabStop = false;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.AutoSize = false;
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCandidata,
            this.menuVisitaCandidata,
            this.menuAlbum,
            this.menuVotacion,
            this.menuResultado,
            this.menuAcercaDe});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 72);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(951, 59);
            this.menuPrincipal.TabIndex = 23;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCandidata
            // 
            this.menuCandidata.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCandidatasToolStripMenuItem});
            this.menuCandidata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCandidata.Image = ((System.Drawing.Image)(resources.GetObject("menuCandidata.Image")));
            this.menuCandidata.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCandidata.Name = "menuCandidata";
            this.menuCandidata.Size = new System.Drawing.Size(73, 55);
            this.menuCandidata.Text = "Candidata";
            this.menuCandidata.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuCandidata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // verCandidatasToolStripMenuItem
            // 
            this.verCandidatasToolStripMenuItem.Name = "verCandidatasToolStripMenuItem";
            this.verCandidatasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.verCandidatasToolStripMenuItem.Text = "Registrar candidata";
            this.verCandidatasToolStripMenuItem.Click += new System.EventHandler(this.verCandidatasToolStripMenuItem_Click_1);
            // 
            // menuVisitaCandidata
            // 
            this.menuVisitaCandidata.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitaDeCandidatasToolStripMenuItem});
            this.menuVisitaCandidata.Image = ((System.Drawing.Image)(resources.GetObject("menuVisitaCandidata.Image")));
            this.menuVisitaCandidata.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVisitaCandidata.Name = "menuVisitaCandidata";
            this.menuVisitaCandidata.Size = new System.Drawing.Size(84, 55);
            this.menuVisitaCandidata.Text = "Información";
            this.menuVisitaCandidata.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuVisitaCandidata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // visitaDeCandidatasToolStripMenuItem
            // 
            this.visitaDeCandidatasToolStripMenuItem.Name = "visitaDeCandidatasToolStripMenuItem";
            this.visitaDeCandidatasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.visitaDeCandidatasToolStripMenuItem.Text = "Visita de candidatas";
            this.visitaDeCandidatasToolStripMenuItem.Click += new System.EventHandler(this.visitaDeCandidatasToolStripMenuItem_Click_1);
            // 
            // menuAlbum
            // 
            this.menuAlbum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearAlbúmToolStripMenuItem});
            this.menuAlbum.Image = ((System.Drawing.Image)(resources.GetObject("menuAlbum.Image")));
            this.menuAlbum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAlbum.Name = "menuAlbum";
            this.menuAlbum.Size = new System.Drawing.Size(55, 55);
            this.menuAlbum.Text = "Albúm";
            this.menuAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // crearAlbúmToolStripMenuItem
            // 
            this.crearAlbúmToolStripMenuItem.Name = "crearAlbúmToolStripMenuItem";
            this.crearAlbúmToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.crearAlbúmToolStripMenuItem.Text = "Crear albúm";
            this.crearAlbúmToolStripMenuItem.Click += new System.EventHandler(this.crearAlbúmToolStripMenuItem_Click_1);
            // 
            // menuVotacion
            // 
            this.menuVotacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.missFotogeniaToolStripMenuItem,
            this.reinaDeLaFacultadToolStripMenuItem});
            this.menuVotacion.Image = ((System.Drawing.Image)(resources.GetObject("menuVotacion.Image")));
            this.menuVotacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVotacion.Name = "menuVotacion";
            this.menuVotacion.Size = new System.Drawing.Size(65, 55);
            this.menuVotacion.Text = "Votación";
            this.menuVotacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuVotacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // missFotogeniaToolStripMenuItem
            // 
            this.missFotogeniaToolStripMenuItem.Name = "missFotogeniaToolStripMenuItem";
            this.missFotogeniaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.missFotogeniaToolStripMenuItem.Text = "Miss Fotogenia";
            this.missFotogeniaToolStripMenuItem.Click += new System.EventHandler(this.missFotogeniaToolStripMenuItem_Click_1);
            // 
            // reinaDeLaFacultadToolStripMenuItem
            // 
            this.reinaDeLaFacultadToolStripMenuItem.Name = "reinaDeLaFacultadToolStripMenuItem";
            this.reinaDeLaFacultadToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.reinaDeLaFacultadToolStripMenuItem.Text = "Reina de la Facultad";
            this.reinaDeLaFacultadToolStripMenuItem.Click += new System.EventHandler(this.reinaDeLaFacultadToolStripMenuItem_Click_1);
            // 
            // menuResultado
            // 
            this.menuResultado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resultadoFinalToolStripMenuItem});
            this.menuResultado.Image = ((System.Drawing.Image)(resources.GetObject("menuResultado.Image")));
            this.menuResultado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuResultado.Name = "menuResultado";
            this.menuResultado.Size = new System.Drawing.Size(76, 55);
            this.menuResultado.Text = "Resultados";
            this.menuResultado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuResultado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // resultadoFinalToolStripMenuItem
            // 
            this.resultadoFinalToolStripMenuItem.Name = "resultadoFinalToolStripMenuItem";
            this.resultadoFinalToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.resultadoFinalToolStripMenuItem.Text = "Resultado Final ";
            this.resultadoFinalToolStripMenuItem.Click += new System.EventHandler(this.resultadoFinalToolStripMenuItem_Click_1);
            // 
            // menuAcercaDe
            // 
            this.menuAcercaDe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem});
            this.menuAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("menuAcercaDe.Image")));
            this.menuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcercaDe.Name = "menuAcercaDe";
            this.menuAcercaDe.Size = new System.Drawing.Size(71, 55);
            this.menuAcercaDe.Text = "Acerca de";
            this.menuAcercaDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 151);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegresar.Image = global::CapaPresentacion.Properties.Resources.salir;
            this.btnRegresar.Location = new System.Drawing.Point(874, 72);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(77, 59);
            this.btnRegresar.TabIndex = 29;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoresToolStripMenuItem.Text = "Autores";
            this.autoresToolStripMenuItem.Click += new System.EventHandler(this.autoresToolStripMenuItem_Click);
            // 
            // vtnMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 604);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menu1);
            this.Name = "vtnMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.Load += new System.EventHandler(this.vtnMenu_Load);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoto)).EndInit();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;    
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxVoto;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem resultadoFinalToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem menuResultado;
        private System.Windows.Forms.ToolStripMenuItem missFotogeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVotacion;
        private System.Windows.Forms.ToolStripMenuItem reinaDeLaFacultadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAlbúmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAlbum;
        private System.Windows.Forms.ToolStripMenuItem visitaDeCandidatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVisitaCandidata;
        private System.Windows.Forms.ToolStripMenuItem verCandidatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCandidata;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
    }
}