namespace Visual
{
    partial class Seccion
    {
        private Label lblTitulo;
        private Label lblEstudiantes;
        private Label lblSec;
        private TextBox txtSec;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblEstudiantes = new Label();
            lblSec = new Label();
            txtSec = new TextBox();

            // Título
            lblTitulo.Text = "📋 Sección";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 60;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // Campo lista de estudiantes (solo texto en este diseño)
            lblEstudiantes.Text = "🧑‍🎓 Lista de estudiantes";
            lblEstudiantes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEstudiantes.Location = new Point(30, 80);
            lblEstudiantes.Size = new Size(250, 30);

            // Campo Sec
            lblSec.Text = "Sec:";
            lblSec.Font = new Font("Segoe UI", 12F);
            lblSec.Location = new Point(30, 130);
            lblSec.Size = new Size(100, 30);

            txtSec.Location = new Point(80, 130);
            txtSec.Size = new Size(250, 30);

            // UserControl
            Controls.Add(lblTitulo);
            Controls.Add(lblEstudiantes);
            Controls.Add(lblSec);
            Controls.Add(txtSec);
            BackColor = Color.White;
            Size = new Size(400, 200);
        }
    }
}
