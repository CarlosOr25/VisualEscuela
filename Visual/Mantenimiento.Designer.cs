namespace Visual
{
    partial class Mantenimiento
    {
        private Label lblTitulo;
        private Button btnMateria;
        private Button btnSeccion;
        private Button btnPersona;
        private Button btnCurso;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnMateria = new Button();
            btnSeccion = new Button();
            btnPersona = new Button();
            btnCurso = new Button();

            lblTitulo.Text = "🛠️ Mantenimiento";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 60;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            int ancho = 140, alto = 60, espaciado = 20, izquierda = 30, fila1 = 80, fila2 = 160;

            btnMateria.Text = "📘 Materia";
            btnSeccion.Text = "📗 Sección";
            btnPersona.Text = "🧑 Persona";
            btnCurso.Text = "📚 Curso";

            foreach (var btn in new[] { btnMateria, btnSeccion, btnPersona, btnCurso })
            {
                btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                btn.Size = new Size(ancho, alto);
                btn.BackColor = Color.LightSteelBlue;
            }

            btnMateria.Location = new Point(izquierda, fila1);
            btnSeccion.Location = new Point(izquierda + ancho + espaciado, fila1);
            btnPersona.Location = new Point(izquierda, fila2);
            btnCurso.Location = new Point(izquierda + ancho + espaciado, fila2);

            Controls.AddRange(new Control[] {
                lblTitulo, btnMateria, btnSeccion, btnPersona, btnCurso
            });

            BackColor = Color.White;
            Size = new Size(400, 260);
        }
    }
}