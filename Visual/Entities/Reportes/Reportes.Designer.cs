namespace Visual.Entities.Reportes
{
    partial class Reportes
    {
        private Button btnProfesores;
        private Button btnListadoNotas;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnListadoNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnProfesores
            this.btnProfesores.BackColor = System.Drawing.Color.LightGreen;
            this.btnProfesores.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnProfesores.Location = new System.Drawing.Point(30, 30);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(240, 60);
            this.btnProfesores.TabIndex = 0;
            this.btnProfesores.Text = "👨‍🏫 Profesores";
            this.btnProfesores.UseVisualStyleBackColor = false;

            // btnListadoNotas
            this.btnListadoNotas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListadoNotas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnListadoNotas.Location = new System.Drawing.Point(30, 110);
            this.btnListadoNotas.Name = "btnListadoNotas";
            this.btnListadoNotas.Size = new System.Drawing.Size(240, 60);
            this.btnListadoNotas.TabIndex = 1;
            this.btnListadoNotas.Text = "📝 Listado de Notas";
            this.btnListadoNotas.UseVisualStyleBackColor = false;

            // Reportes
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnListadoNotas);
            this.Controls.Add(this.btnProfesores);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(300, 200);
            this.ResumeLayout(false);
        }
    }
}