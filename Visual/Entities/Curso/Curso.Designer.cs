namespace Visual.Entities.Curso
{
    partial class Curso
    {
        private Label lblTitulo;
        private Label lblMateria;
        private Label lblSeccion;
        private ComboBox cboMateria;
        private ComboBox cboSeccion;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvCursos;
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
            this.lblSeccion = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📚 Gestión de Cursos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblMateria
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(30, 80);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(50, 15);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia:";

            // cboMateria
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(90, 77);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(300, 23);
            this.cboMateria.TabIndex = 2;
            this.cboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblSeccion
            this.lblSeccion.AutoSize = true;
            this.lblSeccion.Location = new System.Drawing.Point(30, 120);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(51, 15);
            this.lblSeccion.TabIndex = 3;
            this.lblSeccion.Text = "Sección:";

            // cboSeccion
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Location = new System.Drawing.Point(90, 117);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(300, 23);
            this.cboSeccion.TabIndex = 4;
            this.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(30, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(140, 160);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 40);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // btnActualizar
            this.btnActualizar.Location = new System.Drawing.Point(250, 160);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 40);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(360, 160);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "❌ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(470, 160);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;

            // dgvCursos
            this.dgvCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(30, 220);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(740, 310);
            this.dgvCursos.TabIndex = 10;

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(650, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(120, 23);
            this.txtBuscar.TabIndex = 11;

            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(600, 80);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar:";

            // Curso
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboSeccion);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Curso";
            this.Size = new System.Drawing.Size(800, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}