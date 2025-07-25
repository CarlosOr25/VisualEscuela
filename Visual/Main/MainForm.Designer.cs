namespace Visual.Main
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        // Controles principales
        private MenuStrip menuStripMain;
        private ToolStrip toolStripMain;
        private Panel panelContent;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel tsslStatus;

        // Botones del ToolStrip
        private ToolStripButton btnReportes;
        private ToolStripButton btnMantenimiento;
        private ToolStripButton btnInscripcion;
        private ToolStripButton btnNotas;

        // Elementos del menú
        private ToolStripMenuItem reportesMenuItem;
        private ToolStripMenuItem mantenimientoMenuItem;
        private ToolStripMenuItem materiaMenuItem;
        private ToolStripMenuItem seccionMenuItem;
        private ToolStripMenuItem personaMenuItem;
        private ToolStripMenuItem cursoMenuItem;
        private ToolStripMenuItem inscripcionMenuItem;
        private ToolStripMenuItem notasMenuItem;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.reportesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seccionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnReportes = new System.Windows.Forms.ToolStripButton();
            this.btnMantenimiento = new System.Windows.Forms.ToolStripButton();
            this.btnInscripcion = new System.Windows.Forms.ToolStripButton();
            this.btnNotas = new System.Windows.Forms.ToolStripButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();

            // menuStripMain
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesMenuItem,
            this.mantenimientoMenuItem,
            this.inscripcionMenuItem,
            this.notasMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";

            // reportesMenuItem
            this.reportesMenuItem.Name = "reportesMenuItem";
            this.reportesMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesMenuItem.Text = "Reportes";

            // mantenimientoMenuItem
            this.mantenimientoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaMenuItem,
            this.seccionMenuItem,
            this.personaMenuItem,
            this.cursoMenuItem});
            this.mantenimientoMenuItem.Name = "mantenimientoMenuItem";
            this.mantenimientoMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoMenuItem.Text = "Mantenimiento";

            // materiaMenuItem
            this.materiaMenuItem.Name = "materiaMenuItem";
            this.materiaMenuItem.Size = new System.Drawing.Size(120, 22);
            this.materiaMenuItem.Text = "Materia";

            // seccionMenuItem
            this.seccionMenuItem.Name = "seccionMenuItem";
            this.seccionMenuItem.Size = new System.Drawing.Size(120, 22);
            this.seccionMenuItem.Text = "Sección";

            // personaMenuItem
            this.personaMenuItem.Name = "personaMenuItem";
            this.personaMenuItem.Size = new System.Drawing.Size(120, 22);
            this.personaMenuItem.Text = "Persona";

            // cursoMenuItem
            this.cursoMenuItem.Name = "cursoMenuItem";
            this.cursoMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cursoMenuItem.Text = "Curso";

            // inscripcionMenuItem
            this.inscripcionMenuItem.Name = "inscripcionMenuItem";
            this.inscripcionMenuItem.Size = new System.Drawing.Size(79, 20);
            this.inscripcionMenuItem.Text = "Inscripción";

            // notasMenuItem
            this.notasMenuItem.Name = "notasMenuItem";
            this.notasMenuItem.Size = new System.Drawing.Size(49, 20);
            this.notasMenuItem.Text = "Notas";

            // toolStripMain
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReportes,
            this.btnMantenimiento,
            this.btnInscripcion,
            this.btnNotas});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";

            // btnReportes
            this.btnReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(57, 22);
            this.btnReportes.Text = "Reportes";

            // btnMantenimiento
            this.btnMantenimiento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(93, 22);
            this.btnMantenimiento.Text = "Mantenimiento";

            // btnInscripcion
            this.btnInscripcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("btnInscripcion.Image")));
            this.btnInscripcion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(71, 22);
            this.btnInscripcion.Text = "Inscripción";

            // btnNotas
            this.btnNotas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNotas.Image = ((System.Drawing.Image)(resources.GetObject("btnNotas.Image")));
            this.btnNotas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(41, 22);
            this.btnNotas.Text = "Notas";

            // panelContent
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 49);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 529);
            this.panelContent.TabIndex = 2;

            // statusStripMain
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 578);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(800, 22);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";

            // tsslStatus
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(38, 17);
            this.tsslStatus.Text = "Listo";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Menú Principal";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}