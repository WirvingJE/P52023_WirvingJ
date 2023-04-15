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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            // cierra la app 
            Application.Exit();

        }

        private void BtnVerContrasennia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;


        }

        private void BtnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar=true; 
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
           
            //validar que se haya digitado un usuario y contraseña

            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                string usuario = TxtEmail.Text.Trim();
                string contrasennia = TxtContrasennia.Text.Trim();

                //tratar de validar que los datos digitados sean correctos

                Globales.MiUsuarioGlobal  = Globales.MiUsuarioGlobal.ValidarUsuario(usuario, contrasennia);

                if (Globales.MiUsuarioGlobal.UsuarioID > 0)
                {
                    Globales.MiFormPrincipal.Show();

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectas...", "Eror de validacion", MessageBoxButtons.OK);

                    TxtContrasennia.Focus();
                    TxtContrasennia.SelectAll();
                }




            }
            else
            {
                MessageBox.Show("Faltan datos requeridos", "Error de validacion", MessageBoxButtons.OK);
            }



          
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {

            //al presionar cierta cominscion el btoen de ingredi directo aparece 
            if (e.Shift & e.Alt & e.KeyCode == Keys.A)
            { 

                BtnIngresarDirecto.Visible = true;


            }






        }

        private void BtnIngresarDirecto_Click(object sender, EventArgs e)
        {

            Globales.MiFormPrincipal.Show();
            this.Hide();    



        }
    }
}
