namespace Visual.Entities.Notas
{
    partial class Notas
    {
        private Label lblTitulo;
        private Label lblCI;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblCarrera;
        private Label lblPeriodo;
        private Label lblNota;
        private TextBox txtCI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCarrera;
        private TextBox txtPeriodo;
        private TextBox txtNota;
        private Button btnListado;
        private Button btnPlanilla;
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
            this.lblCI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnPlanilla = new System.Windows.Forms.Button();
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

            // lblCI
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(30, 80);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(22, 15);
            this.lblCI.TabIndex = 1;
            this.lblCI.Text = "CI:";

            // txtCI
            this.txtCI.Location = new System.Drawing.Point(120, 77);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(200, 23);
            this.txtCI.TabIndex = 2;

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(120, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 4;

            // lblApellido
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 160);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";

            // txtApellido
            this.txtApellido.Location = new System.Drawing.Point(120, 157);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 23);
            this.txtApellido.TabIndex = 6;

            // lblCarrera
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(30, 200);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(48, 15);
            this.lblCarrera.TabIndex = 7;
            this.lblCarrera.Text = "Carrera:";

            // txtCarrera
            this.txtCarrera.Location = new System.Drawing.Point(120, 197);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(200, 23);
            this.txtCarrera.TabIndex = 8;

            // lblPeriodo
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(30, 240);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(50, 15);
            this.lblPeriodo.TabIndex = 9;
            this.lblPeriodo.Text = "Periodo:";

            // txtPeriodo
            this.txtPeriodo.Location = new System.Drawing.Point(120, 237);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(200, 23);
            this.txtPeriodo.TabIndex = 10;

            // lblNota
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(30, 280);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(36, 15);
            this.lblNota.TabIndex = 11;
            this.lblNota.Text = "Nota:";

            // txtNota
            this.txtNota.Location = new System.Drawing.Point(120, 277);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 23);
            this.txtNota.TabIndex = 12;

            // btnListado
            this.btnListado.Location = new System.Drawing.Point(30, 320);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(170, 40);
            this.btnListado.TabIndex = 13;
            this.btnListado.Text = "🗂️ Ver listado Notas";
            this.btnListado.UseVisualStyleBackColor = true;

            // btnPlanilla
            this.btnPlanilla.Location = new System.Drawing.Point(210, 320);
            this.btnPlanilla.Name = "btnPlanilla";
            this.btnPlanilla.Size = new System.Drawing.Size(170, 40);
            this.btnPlanilla.TabIndex = 14;
            this.btnPlanilla.Text = "📄 Ver planilla";
            this.btnPlanilla.UseVisualStyleBackColor = true;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(390, 320);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 40);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(570, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 40);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.UseVisualStyleBackColor = true;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(30, 380);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 40);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "💾 Guardar Nota";
            this.btnGuardar.UseVisualStyleBackColor = true;

            // dgvNotas
            this.dgvNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(30, 440);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(740, 200);
            this.dgvNotas.TabIndex = 18;

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(650, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(120, 23);
            this.txtBuscar.TabIndex = 19;

            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(600, 80);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 20;
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
            this.Controls.Add(this.btnPlanilla);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Notas";
            this.Size = new System.Drawing.Size(800, 650);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}