namespace Visual.Main
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStripMain;
        private Panel panelContent;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel tsslStatus;

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
            this.panelContent = new System.Windows.Forms.Panel();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
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

            // panelContent
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 24);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(800, 554);
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
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Menú Principal";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}