using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcurrencia
{
    public partial class FrmPatronSingleton : Form
    {
        public FrmPatronSingleton()
        {
            InitializeComponent();
        }

        private void FrmPatronSingleton_Load(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Singlenton cadenaConeccion = Singlenton.Instance;
            cadenaConeccion.CadenaConexion = txtCadenaConexion.Text;
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Singlenton cadenaConexion = Singlenton.Instance;
            LblCadenaDeConeccionRecuperada.Text = cadenaConexion.CadenaConexion;
        }
    }
}
