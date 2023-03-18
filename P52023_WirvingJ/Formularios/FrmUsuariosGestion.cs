using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_WirvingJ.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        public FrmUsuariosGestion()
        {
            InitializeComponent();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {

            //defidimos el padre mdi 
            MdiParent = Globales.MiFormPrincipal;

            CargarListaRoles();


        }

        private void CargarListaRoles()
        {

            Logica.Models.Usuario_Rol Mirol  = new Logica.Models.Usuario_Rol();

            DataTable dt = new DataTable();
            dt = Mirol.Listar();

            {
            if (dt != null && dt.Rows.Count > 0)
                {

                    CbRolesUsuario.ValueMember = "ID";
                    CbRolesUsuario.DisplayMember= "Descrip";
                    CbRolesUsuario.DataSource = dt;
                    CbRolesUsuario.SelectedIndex= -1;



                }

            }

        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
