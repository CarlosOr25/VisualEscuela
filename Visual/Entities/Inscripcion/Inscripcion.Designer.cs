namespace Visual.Entities.Inscripcion
{
    partial class InscripcionControl
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private ComboBox cboEstudiantes;
        private ComboBox cboCursos;
        private Button btnInscribir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cboEstudiantes = new System.Windows.Forms.ComboBox();
            this.cboCursos = new System.Windows.Forms.ComboBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📝 INSCRIPCIÓN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // cboEstudiantes
            this.cboEstudiantes.FormattingEnabled = true;
            this.cboEstudiantes.Location = new System.Drawing.Point(50, 80);
            this.cboEstudiantes.Name = "cboEstudiantes";
            this.cboEstudiantes.Size = new System.Drawing.Size(300, 23);
            this.cboEstudiantes.TabIndex = 1;
            this.cboEstudiantes.DropDownStyle = ComboBoxStyle.DropDownList;

            // cboCursos
            this.cboCursos.FormattingEnabled = true;
            this.cboCursos.Location = new System.Drawing.Point(400, 80);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.Size = new System.Drawing.Size(300, 23);
            this.cboCursos.TabIndex = 2;
            this.cboCursos.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnInscribir
            this.btnInscribir.Location = new System.Drawing.Point(300, 130);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(200, 40);
            this.btnInscribir.TabIndex = 3;
            this.btnInscribir.Text = "🟩 Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;

            // InscripcionControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.cboCursos);
            this.Controls.Add(this.cboEstudiantes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "InscripcionControl";
            this.Size = new System.Drawing.Size(800, 200);
            this.ResumeLayout(false);
        }
    }
}