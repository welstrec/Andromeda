using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Andromeda
{
    public partial class VentanaMensajesCorreo : Form
    {
        private List<string> mensajes=new List<string>();
        private bool completo = false;
        public VentanaMensajesCorreo()
        {
            InitializeComponent();
            ListaCorreo.ClearSelected();
        }
        internal void actualizar(List<string> listaRecividostemp, List<string> mensajex)
        {
            Console.WriteLine("Entro1");
            ListaCorreo.DataSource = listaRecividostemp;
            mensajes = mensajex;
            completo = true;     
            Console.WriteLine("Entro2");
        }
    }
}
