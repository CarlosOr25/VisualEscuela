namespace Visual
{
    partial class Persona
    {
        private Label lblTitulo;
        private Label lblCI;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipo;
        private Label lblSeccion;
        private Label lblMateria;
        private Label lblEdad;
        private TextBox txtCI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTipo;
        private TextBox txtSeccion;
        private TextBox txtMateria;
        private TextBox txtEdad;
        private Button btnGuardar;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCI = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipo = new Label();
            lblSeccion = new Label();
            lblMateria = new Label();
            lblEdad = new Label();
            txtCI = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTipo = new TextBox();
            txtSeccion = new TextBox();
            txtMateria = new TextBox();
            txtEdad = new TextBox();
            btnGuardar = new Button();

            // Título
            lblTitulo.Text = "🧾 Persona";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 60;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            // Posición base
            int baseX = 30, baseY = 80, campoAlto = 30, espacioY = 40, ancho = 250;
            string[] etiquetas = { "C.I.", "Nombre", "Apellido", "Tipo persona", "Sección", "Materia", "Edad" };
            Label[] labels = { lblCI, lblNombre, lblApellido, lblTipo, lblSeccion, lblMateria, lblEdad };
            TextBox[] boxes = { txtCI, txtNombre, txtApellido, txtTipo, txtSeccion, txtMateria, txtEdad };

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

            // Botón Guardar
            btnGuardar.Text = "💾 Guardar";
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.Location = new Point(30, baseY + etiquetas.Length * espacioY + 10);
            btnGuardar.BackColor = Color.LightBlue;

            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            BackColor = Color.White;
            Size = new Size(500, btnGuardar.Bottom + 20);
        }
    }
}