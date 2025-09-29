namespace Sistema_Odonto
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.agendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSuporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.MAjuda,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(296, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDentista,
            this.menuPaciente,
            this.menuConsulta});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuDentista
            // 
            this.menuDentista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuDentista.Image = ((System.Drawing.Image)(resources.GetObject("menuDentista.Image")));
            this.menuDentista.Name = "menuDentista";
            this.menuDentista.Size = new System.Drawing.Size(121, 22);
            this.menuDentista.Text = "Dentista";
            this.menuDentista.Click += new System.EventHandler(this.menuDentista_Click);
            // 
            // menuPaciente
            // 
            this.menuPaciente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuPaciente.Image = ((System.Drawing.Image)(resources.GetObject("menuPaciente.Image")));
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(121, 22);
            this.menuPaciente.Text = "Paciente";
            // 
            // menuConsulta
            // 
            this.menuConsulta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuConsulta.Image = ((System.Drawing.Image)(resources.GetObject("menuConsulta.Image")));
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(121, 22);
            this.menuConsulta.Text = "Consulta";
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgDentistas,
            this.menuAgPacientes,
            this.menuAgConsultas});
            this.agendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendasToolStripMenuItem.Image")));
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.agendasToolStripMenuItem.Text = "Agendas";
            // 
            // menuAgDentistas
            // 
            this.menuAgDentistas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuAgDentistas.Image = ((System.Drawing.Image)(resources.GetObject("menuAgDentistas.Image")));
            this.menuAgDentistas.Name = "menuAgDentistas";
            this.menuAgDentistas.Size = new System.Drawing.Size(126, 22);
            this.menuAgDentistas.Text = "Dentistas";
            this.menuAgDentistas.Click += new System.EventHandler(this.menuAgDentistas_Click);
            // 
            // menuAgPacientes
            // 
            this.menuAgPacientes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuAgPacientes.Image = ((System.Drawing.Image)(resources.GetObject("menuAgPacientes.Image")));
            this.menuAgPacientes.Name = "menuAgPacientes";
            this.menuAgPacientes.Size = new System.Drawing.Size(126, 22);
            this.menuAgPacientes.Text = "Pacientes";
            // 
            // menuAgConsultas
            // 
            this.menuAgConsultas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuAgConsultas.Image = ((System.Drawing.Image)(resources.GetObject("menuAgConsultas.Image")));
            this.menuAgConsultas.Name = "menuAgConsultas";
            this.menuAgConsultas.Size = new System.Drawing.Size(126, 22);
            this.menuAgConsultas.Text = "Consultas";
            // 
            // MAjuda
            // 
            this.MAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSuporte});
            this.MAjuda.Image = ((System.Drawing.Image)(resources.GetObject("MAjuda.Image")));
            this.MAjuda.Name = "MAjuda";
            this.MAjuda.Size = new System.Drawing.Size(66, 20);
            this.MAjuda.Text = "Ajuda";
            // 
            // menuSuporte
            // 
            this.menuSuporte.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuSuporte.Name = "menuSuporte";
            this.menuSuporte.Size = new System.Drawing.Size(115, 22);
            this.menuSuporte.Text = "Suporte";
            // 
            // MSair
            // 
            this.MSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSair});
            this.MSair.Image = ((System.Drawing.Image)(resources.GetObject("MSair.Image")));
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(54, 20);
            this.MSair.Text = "Sair";
            // 
            // menuSair
            // 
            this.menuSair.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(93, 22);
            this.menuSair.Text = "Sair";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema Odonto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAjuda;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.ToolStripMenuItem menuDentista;
        private System.Windows.Forms.ToolStripMenuItem menuPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuAgDentistas;
        private System.Windows.Forms.ToolStripMenuItem menuAgPacientes;
        private System.Windows.Forms.ToolStripMenuItem menuAgConsultas;
        private System.Windows.Forms.ToolStripMenuItem menuSuporte;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
    }
}

