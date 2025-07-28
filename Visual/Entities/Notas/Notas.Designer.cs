namespace Visual.Entities.Notas
{
    partial class Notas
    {
        private Label lblTitulo;
        private Label lblMateria;
        private ComboBox cboMaterias;
        private Label lblEstudiante;
        private ComboBox cboEstudiantes;
        private Label lblNota;
        private TextBox txtNota;
        private Button btnListado;
        private Button btnBuscar;
        private Button btnSalir;
        private Button btnGuardar;
        private DataGridView dgvNotas;
        private TextBox txtBuscar;
        private Label lblBuscar;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.cboEstudiantes = new System.Windows.Forms.ComboBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📑 Registro de Notas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblMateria
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(30, 80);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia:";

            // cboMaterias
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(120, 77);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(300, 23);
            this.cboMaterias.TabIndex = 2;

            // lblEstudiante
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Location = new System.Drawing.Point(30, 120);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(62, 15);
            this.lblEstudiante.TabIndex = 3;
            this.lblEstudiante.Text = "Estudiante:";

            // cboEstudiantes
            this.cboEstudiantes.FormattingEnabled = true;
            this.cboEstudiantes.Location = new System.Drawing.Point(120, 117);
            this.cboEstudiantes.Name = "cboEstudiantes";
            this.cboEstudiantes.Size = new System.Drawing.Size(300, 23);
            this.cboEstudiantes.TabIndex = 4;

            // lblNota
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(30, 160);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(36, 15);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "Nota:";

            // txtNota
            this.txtNota.Location = new System.Drawing.Point(120, 157);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 23);
            this.txtNota.TabIndex = 6;

            // btnListado
            this.btnListado.Location = new System.Drawing.Point(30, 200);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(240, 40);
            this.btnListado.TabIndex = 7;
            this.btnListado.Text = "🗂️ Ver listado Notas";
            this.btnListado.UseVisualStyleBackColor = true;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(290, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(240, 40);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(550, 200);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 40);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.UseVisualStyleBackColor = true;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(30, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 40);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "💾 Guardar Nota";
            this.btnGuardar.UseVisualStyleBackColor = true;

            // dgvNotas
            this.dgvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(30, 320);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(740, 320);
            this.dgvNotas.TabIndex = 12;

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(650, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(120, 23);
            this.txtBuscar.TabIndex = 13;

            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(600, 80);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 14;
            this.lblBuscar.Text = "Buscar:";

            // Notas
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.cboEstudiantes);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Notas";
            this.Size = new System.Drawing.Size(800, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}