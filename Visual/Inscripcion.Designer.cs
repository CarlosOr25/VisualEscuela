namespace Visual
{
    partial class Inscripcion
    {
        private Label lblTitulo;
        private Label lblCI, lblCarrera, lblNombre, lblApellido, lblHC;
        private TextBox txtCI, txtCarrera, txtNombre, txtApellido, txtHC;
        private DataGridView dgvMaterias;
        private Button btnInscribir, btnLimpiar, btnBuscar, btnSalir;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCI = new Label(); lblCarrera = new Label(); lblNombre = new Label();
            lblApellido = new Label(); lblHC = new Label();

            txtCI = new TextBox(); txtCarrera = new TextBox(); txtNombre = new TextBox();
            txtApellido = new TextBox(); txtHC = new TextBox();

            btnInscribir = new Button(); btnLimpiar = new Button();
            btnBuscar = new Button(); btnSalir = new Button();

            dgvMaterias = new DataGridView();

            lblTitulo.Text = "📝 INSCRIPCIÓN";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 60;
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;

            string[] etiquetas = { "C.I", "Carrera", "Nombre", "Apellido" };
            Label[] labels = { lblCI, lblCarrera, lblNombre, lblApellido };
            TextBox[] boxes = { txtCI, txtCarrera, txtNombre, txtApellido };

            int baseX = 30, baseY = 80, campoAlto = 30, espacioY = 40, ancho = 250;

            for (int i = 0; i < etiquetas.Length; i++)
            {
                labels[i].Text = etiquetas[i] + ":";
                labels[i].Font = new Font("Segoe UI", 12F);
                labels[i].Location = new Point(baseX, baseY + i * espacioY);
                labels[i].Size = new Size(120, campoAlto);

                boxes[i].Location = new Point(baseX + 130, baseY + i * espacioY);
                boxes[i].Size = new Size(ancho, campoAlto);

                Controls.Add(labels[i]);
                Controls.Add(boxes[i]);
            }

            dgvMaterias.Location = new Point(30, baseY + etiquetas.Length * espacioY + 10);
            dgvMaterias.Size = new Size(720, 180);
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Columns.Add("Semestre", "Semestre");
            dgvMaterias.Columns.Add("Codigo", "Código");
            dgvMaterias.Columns.Add("Materia", "Materia");
            dgvMaterias.Columns.Add("Sec", "Sec");
            dgvMaterias.Columns.Add("HC", "HC");
            dgvMaterias.Columns.Add("Cupo", "Cupo");
            dgvMaterias.Columns.Add("Profesor", "Profesor");

            lblHC.Text = "HC:";
            lblHC.Font = new Font("Segoe UI", 12F);
            lblHC.Location = new Point(610, dgvMaterias.Bottom + 10);
            lblHC.Size = new Size(40, campoAlto);

            txtHC.Location = new Point(650, dgvMaterias.Bottom + 10);
            txtHC.Size = new Size(100, campoAlto);

            btnInscribir.Text = "🟩 Inscribir";
            btnLimpiar.Text = "🧹 Limpiar";
            btnBuscar.Text = "🔍 Buscar";
            btnSalir.Text = "❌ Salir";

            Button[] botones = { btnInscribir, btnLimpiar, btnBuscar, btnSalir };
            for (int i = 0; i < botones.Length; i++)
            {
                botones[i].Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                botones[i].Size = new Size(150, 40);
                botones[i].Location = new Point(30 + i * 160, txtHC.Bottom + 20);
                botones[i].BackColor = Color.LightGray;
                Controls.Add(botones[i]);
            }

            Controls.Add(lblTitulo);
            Controls.Add(dgvMaterias);
            Controls.Add(lblHC);
            Controls.Add(txtHC);
            BackColor = Color.White;
            Size = new Size(800, btnSalir.Bottom + 30);
        }
    }
}
