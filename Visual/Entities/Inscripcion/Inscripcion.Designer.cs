namespace Visual.Entities.Inscripcion
{
    partial class Inscripcion
    {
        private Label lblTitulo;
        private Label lblCI;
        private Label lblCarrera;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblHC;
        private TextBox txtCI;
        private TextBox txtCarrera;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtHC;
        private DataGridView dgvMaterias;
        private Button btnInscribir;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCI = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblHC = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtHC = new System.Windows.Forms.TextBox();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
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

            // lblCI
            this.lblCI.AutoSize = true;
            this.lblCI.Location = new System.Drawing.Point(30, 80);
            this.lblCI.Name = "lblCI";
            this.lblCI.Size = new System.Drawing.Size(22, 15);
            this.lblCI.TabIndex = 1;
            this.lblCI.Text = "CI:";

            // txtCI
            this.txtCI.Location = new System.Drawing.Point(60, 77);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(200, 23);
            this.txtCI.TabIndex = 2;

            // lblCarrera
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(30, 120);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(48, 15);
            this.lblCarrera.TabIndex = 3;
            this.lblCarrera.Text = "Carrera:";

            // txtCarrera
            this.txtCarrera.Location = new System.Drawing.Point(90, 117);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(200, 23);
            this.txtCarrera.TabIndex = 4;

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 160);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(90, 157);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 6;

            // lblApellido
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 200);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";

            // txtApellido
            this.txtApellido.Location = new System.Drawing.Point(90, 197);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 23);
            this.txtApellido.TabIndex = 8;

            // dgvMaterias
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(30, 240);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.Size = new System.Drawing.Size(740, 180);
            this.dgvMaterias.TabIndex = 9;

            // lblHC
            this.lblHC.AutoSize = true;
            this.lblHC.Location = new System.Drawing.Point(30, 440);
            this.lblHC.Name = "lblHC";
            this.lblHC.Size = new System.Drawing.Size(28, 15);
            this.lblHC.TabIndex = 10;
            this.lblHC.Text = "HC:";

            // txtHC
            this.txtHC.Location = new System.Drawing.Point(60, 437);
            this.txtHC.Name = "txtHC";
            this.txtHC.Size = new System.Drawing.Size(100, 23);
            this.txtHC.TabIndex = 11;

            // btnInscribir
            this.btnInscribir.Location = new System.Drawing.Point(30, 480);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(150, 40);
            this.btnInscribir.TabIndex = 12;
            this.btnInscribir.Text = "🟩 Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(190, 480);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(350, 480);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 40);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // btnSalir
            this.btnSalir.Location = new System.Drawing.Point(510, 480);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 40);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "❌ Salir";
            this.btnSalir.UseVisualStyleBackColor = true;

            // Inscripcion
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.txtHC);
            this.Controls.Add(this.lblHC);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Inscripcion";
            this.Size = new System.Drawing.Size(800, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}