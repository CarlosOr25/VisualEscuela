namespace Visual.Entities.Mantenimiento
{
    partial class Mantenimiento
    {
        private Label lblTitulo;
        private Button btnMateria;
        private Button btnSeccion;
        private Button btnPersona;
        private Button btnCurso;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnSeccion = new System.Windows.Forms.Button();
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();

            // lblTitulo
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(400, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🛠️ Mantenimiento";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnMateria
            this.btnMateria.BackColor = System.Drawing.Color.LightBlue;
            this.btnMateria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMateria.Location = new System.Drawing.Point(30, 80);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(150, 60);
            this.btnMateria.TabIndex = 1;
            this.btnMateria.Text = "📘 Materia";
            this.btnMateria.UseVisualStyleBackColor = false;

            // btnSeccion
            this.btnSeccion.BackColor = System.Drawing.Color.LightGreen;
            this.btnSeccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSeccion.Location = new System.Drawing.Point(200, 80);
            this.btnSeccion.Name = "btnSeccion";
            this.btnSeccion.Size = new System.Drawing.Size(150, 60);
            this.btnSeccion.TabIndex = 2;
            this.btnSeccion.Text = "📗 Sección";
            this.btnSeccion.UseVisualStyleBackColor = false;

            // btnPersona
            this.btnPersona.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPersona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPersona.Location = new System.Drawing.Point(30, 160);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(150, 60);
            this.btnPersona.TabIndex = 3;
            this.btnPersona.Text = "🧑 Persona";
            this.btnPersona.UseVisualStyleBackColor = false;

            // btnCurso
            this.btnCurso.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnCurso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCurso.Location = new System.Drawing.Point(200, 160);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(150, 60);
            this.btnCurso.TabIndex = 4;
            this.btnCurso.Text = "📚 Curso";
            this.btnCurso.UseVisualStyleBackColor = false;

            // Mantenimiento
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCurso);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.btnSeccion);
            this.Controls.Add(this.btnMateria);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Mantenimiento";
            this.Size = new System.Drawing.Size(400, 260);
            this.ResumeLayout(false);
        }
    }
}