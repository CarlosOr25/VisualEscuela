using System;
using System.Windows.Forms;

namespace Visual.Entities.Reportes
{
    public partial class Reportes : UserControl
    {
        public event EventHandler? MostrarProfesores;
        public event EventHandler? MostrarListadoNotas;

        public Reportes()
        {
            InitializeComponent();
            btnProfesores.Click += (s, e) => MostrarProfesores?.Invoke(this, EventArgs.Empty);
            btnListadoNotas.Click += (s, e) => MostrarListadoNotas?.Invoke(this, EventArgs.Empty);
        }
    }
}