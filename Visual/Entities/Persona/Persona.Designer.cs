namespace Visual.Entities.Persona
{
    partial class Persona
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblCI;
        private Label lblNombre;
        private Label lblTipo;
        private TextBox txtCI;
        private TextBox txtNombre;
        private TextBox txtTipo;
        private Button btnGuardar;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvPersonas;
        private TextBox txtBuscar;
        private Label lblBuscar;

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
            this.lblCI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🧾 Gestión de Personas";
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
            this.txtNombre.Size = new System.Drawing.Size(400, 23);
            this.txtNombre.TabIndex = 4;

            // lblTipo
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(30, 160);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 15);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo:";

            // txtTipo
            this.txtTipo.Location = new System.Drawing.Point(120, 157);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(200, 23);
            this.txtTipo.TabIndex = 8;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(30, 200);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(140, 200);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 40);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;

            // btnActualizar
            this.btnActualizar.Location = new System.Drawing.Point(250, 200);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(100, 40);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "🔄 Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(360, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "❌ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(470, 200);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "🧹 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;

            // dgvPersonas
            this.dgvPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(30, 260);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.Size = new System.Drawing.Size(740, 270);
            this.dgvPersonas.TabIndex = 14;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(650, 77);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(120, 23);
            this.txtBuscar.TabIndex = 15;

            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(600, 80);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(45, 15);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "Buscar:";

            // Persona
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCI);
            this.Controls.Add(this.lblCI);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Persona";
            this.Size = new System.Drawing.Size(800, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}