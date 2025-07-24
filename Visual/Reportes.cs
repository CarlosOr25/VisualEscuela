using System;
using System.Windows.Forms;

namespace Visual
{
    public partial class Reportes : UserControl
    {
        public event EventHandler MostrarPlanillaNotas;
        public event EventHandler MostrarListadoNotas;

        public Reportes()
        {
            InitializeComponent();
            btnPlanillaNotas.Click += (s, e) => MostrarPlanillaNotas?.Invoke(this, EventArgs.Empty);
            btnListadoNotas.Click += (s, e) => MostrarListadoNotas?.Invoke(this, EventArgs.Empty);
        }
    }
}