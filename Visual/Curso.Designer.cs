namespace Visual
{
    partial class Curso
    {
        private Label lblTitulo;
        private Label lblSeccion;
        private Label lblMateria;
        private Label lblCupos;
        private Label lblHorario;
        private Label lblDocente;
        private Button btnLista;
        private TextBox txtSeccion;
        private TextBox txtMateria;
        private TextBox txtCupos;
        private TextBox txtHorario;
        private TextBox txtDocente;
        private Button btnGuardar;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSeccion = new Label();
            lblMateria = new Label();
            lblCupos = new Label();
            lblHorario = new Label();
            lblDocente = new Label();
            btnLista = new Button();
            txtSeccion = new TextBox();
            txtMateria = new TextBox();
            txtCupos = new TextBox();
            txtHorario = new TextBox();
            txtDocente = new TextBox();
            btnGuardar = new Button();

            lblTitulo.Text = "📘 Curso";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 60;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            string[] etiquetas = { "Sección", "Materia", "Cupos", "Horario", "Docente" };
            Label[] labels = { lblSeccion, lblMateria, lblCupos, lblHorario, lblDocente };
            TextBox[] boxes = { txtSeccion, txtMateria, txtCupos, txtHorario, txtDocente };

            int baseX = 30, baseY = 80, campoAlto = 30, espacioY = 40, ancho = 250;

            for (int i = 0; i < etiquetas.Length; i++)
            {
                labels[i].Text = etiquetas[i] + ":";
                labels[i].Font = new Font("Segoe UI", 12F);
                labels[i].Location = new Point(baseX, baseY + (i * espacioY));
                labels[i].Size = new Size(150, campoAlto);

                boxes[i].Location = new Point(baseX + 150, baseY + (i * espacioY));
                boxes[i].Size = new Size(ancho, campoAlto);

                Controls.Add(labels[i]);
                Controls.Add(boxes[i]);
            }

            btnLista.Text = "🟩 Lista de estudiantes";
            btnLista.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLista.Size = new Size(300, 40);
            btnLista.Location = new Point(baseX, baseY + etiquetas.Length * espacioY + 20);
            btnLista.BackColor = Color.LightGreen;

            // Botón Guardar
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.Location = new Point(30, btnLista.Bottom + 20);
            btnGuardar.BackColor = Color.LightBlue;

            Controls.Add(lblTitulo);
            Controls.Add(btnLista);
            Controls.Add(btnGuardar);
            BackColor = Color.White;
            Size = new Size(520, btnGuardar.Bottom + 20);
        }
    }
}