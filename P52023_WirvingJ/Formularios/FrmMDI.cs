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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 

        }

        private void sAÑIRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //control para que el formulario de gestion de usuarios 
            // se muestre una sola vez

            if (!Globales.MiFormGestionUsuarios.Visible)
            {
                Globales.MiFormGestionUsuarios = new FrmUsuariosGestion();

                Globales.MiFormGestionUsuarios.Show();

            }





        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {

            //mostrar el usuario logeado
            string InfoUsuario = string.Format("{0}-{1}({2})",
                                                             Globales.MiUsuarioGlobal.UsuarioNombre,
                                                             Globales.MiUsuarioGlobal.UsuarioCorreo,
                                                             Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolDescripcion);


            LblUsuario.Text = InfoUsuario;  

            switch (Globales.MiUsuarioGlobal.MiRolTipo.UsuarioRolID)
            {
                case 1:
                    
                    break;  

                    case 2:
                    gestiónDeUsuariosToolStripMenuItem.Visible= false;
                    rolesDeUsuarioToolStripMenuItem.Visible = false;
                    tiposDeProveedorToolStripMenuItem.Visible = false;
                    tiposDeProveedorToolStripMenuItem.Visible = false;
                    break;

                       
            }



        }
    }
}
