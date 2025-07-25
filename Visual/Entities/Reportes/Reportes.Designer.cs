namespace Visual.Entities.Reportes
{
    partial class Reportes
    {
        private Button btnReportes;
        private Button btnPlanillaNotas;
        private Button btnListadoNotas;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnPlanillaNotas = new System.Windows.Forms.Button();
            this.btnListadoNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnReportes
            this.btnReportes.BackColor = System.Drawing.Color.LightGray;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.Location = new System.Drawing.Point(30, 30);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(240, 60);
            this.btnReportes.TabIndex = 0;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;

            // btnPlanillaNotas
            this.btnPlanillaNotas.BackColor = System.Drawing.Color.LightGreen;
            this.btnPlanillaNotas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlanillaNotas.Location = new System.Drawing.Point(30, 110);
            this.btnPlanillaNotas.Name = "btnPlanillaNotas";
            this.btnPlanillaNotas.Size = new System.Drawing.Size(240, 60);
            this.btnPlanillaNotas.TabIndex = 1;
            this.btnPlanillaNotas.Text = "📗 Planilla de notas";
            this.btnPlanillaNotas.UseVisualStyleBackColor = false;

            // btnListadoNotas
            this.btnListadoNotas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListadoNotas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListadoNotas.Location = new System.Drawing.Point(30, 190);
            this.btnListadoNotas.Name = "btnListadoNotas";
            this.btnListadoNotas.Size = new System.Drawing.Size(240, 60);
            this.btnListadoNotas.TabIndex = 2;
            this.btnListadoNotas.Text = "📝 Listado de Notas";
            this.btnListadoNotas.UseVisualStyleBackColor = false;

            // Reportes
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnListadoNotas);
            this.Controls.Add(this.btnPlanillaNotas);
            this.Controls.Add(this.btnReportes);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(300, 270);
            this.ResumeLayout(false);
        }
    }
}