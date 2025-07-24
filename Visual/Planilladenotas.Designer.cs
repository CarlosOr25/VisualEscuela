namespace Visual
{
    partial class Planilladenotas
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private DataGridView dgvNotas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            dgvNotas = new DataGridView();

            lblTitulo.Text = "📗 Planilla de notas";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 50;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            dgvNotas.Dock = DockStyle.Fill;
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotas.AllowUserToAddRows = true;

            dgvNotas.Columns.Add("Nombre", "Nombre");
            dgvNotas.Columns.Add("Asignatura", "Asignatura");
            dgvNotas.Columns.Add("Notas", "Notas");
            dgvNotas.Columns.Add("Promedio", "Promedio");
            dgvNotas.Columns.Add("Fecha", "Fecha");
            dgvNotas.Columns.Add("Institucion", "Institución");
            dgvNotas.Columns.Add("Docente", "Docente");

            this.Controls.Add(dgvNotas);
            this.Controls.Add(lblTitulo);
            this.BackColor = Color.White;
            this.Size = new Size(800, 500);
        }
    }
}
