using System;
using System.Windows.Forms;

namespace Visual.Entities.Mantenimiento
{
    public partial class Mantenimiento : UserControl
    {
        public event EventHandler? MostrarMateria;
        public event EventHandler? MostrarSeccion;
        public event EventHandler? MostrarPersona;
        public event EventHandler? MostrarCurso;

        public Mantenimiento()
        {
            InitializeComponent();

            btnMateria.Click += (s, e) => MostrarMateria?.Invoke(this, EventArgs.Empty);
            btnSeccion.Click += (s, e) => MostrarSeccion?.Invoke(this, EventArgs.Empty);
            btnPersona.Click += (s, e) => MostrarPersona?.Invoke(this, EventArgs.Empty);
            btnCurso.Click += (s, e) => MostrarCurso?.Invoke(this, EventArgs.Empty);
        }
    }
}