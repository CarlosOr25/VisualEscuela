namespace Visual
{
    partial class Notas
    {
        private Label lblTitulo;
        private Label lblCI, lblNombre, lblApellido, lblCarrera, lblPeriodo, lblNota;
        private TextBox txtCI, txtNombre, txtApellido, txtCarrera, txtPeriodo, txtNota;
        private Button btnListado, btnPlanilla, btnBuscar, btnSalir;
        private Button btnGuardar;

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCI = new Label(); lblNombre = new Label(); lblApellido = new Label();
            lblCarrera = new Label(); lblPeriodo = new Label(); lblNota = new Label();
            txtCI = new TextBox(); txtNombre = new TextBox(); txtApellido = new TextBox();
            txtCarrera = new TextBox(); txtPeriodo = new TextBox(); txtNota = new TextBox();
            btnListado = new Button(); btnPlanilla = new Button();
            btnBuscar = new Button(); btnSalir = new Button();
            btnGuardar = new Button();

            lblTitulo.Text = "📑 Registro de Notas";
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 60;

            string[] etiquetas = { "C.I.", "Nombre(*)", "Apellido(*)", "Carrera", "Periodo(*)", "Nota(*) ≥" };
            Label[] labels = { lblCI, lblNombre, lblApellido, lblCarrera, lblPeriodo, lblNota };
            TextBox[] boxes = { txtCI, txtNombre, txtApellido, txtCarrera, txtPeriodo, txtNota };

            int baseX = 30, baseY = 80, campoAlto = 30, espacioY = 40, ancho = 250;

            for (int i = 0; i < etiquetas.Length; i++)
            {
                labels[i].Text = etiquetas[i] + ":";
                labels[i].Font = new Font("Segoe UI", 12F);
                labels[i].Location = new Point(baseX, baseY + (i * espacioY));
                labels[i].Size = new Size(120, campoAlto);

                boxes[i].Location = new Point(baseX + 130, baseY + (i * espacioY));
                boxes[i].Size = new Size(ancho, campoAlto);

                Controls.Add(labels[i]);
                Controls.Add(boxes[i]);
            }

            btnListado.Text = "🗂️ Ver listado Notas";
            btnPlanilla.Text = "📄 Ver planilla";
            btnBuscar.Text = "🔍 Buscar";
            btnSalir.Text = "❌ Salir";

            Button[] botones = { btnListado, btnPlanilla, btnBuscar, btnSalir };
            for (int i = 0; i < botones.Length; i++)
            {
                botones[i].Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                botones[i].Size = new Size(170, 40);
                botones[i].Location = new Point(baseX + (i * 180), baseY + etiquetas.Length * espacioY + 20);
                botones[i].BackColor = Color.LightGray;
                Controls.Add(botones[i]);
            }

            // Botón Guardar
            btnGuardar.Text = "💾 Guardar Nota";
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.Size = new Size(200, 40);
            btnGuardar.Location = new Point(30, baseY + etiquetas.Length * espacioY + 80);
            btnGuardar.BackColor = Color.LightBlue;
            Controls.Add(btnGuardar);

            Controls.Add(lblTitulo);
            BackColor = Color.White;
            Size = new Size(800, btnGuardar.Bottom + 30);
        }
    }
}