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

        // por orden es mejor crear objetos locales que permitan
        //la gestion del tema dde estados tratando
        //usar objetos indivudiales en las funcin pueda provocar desorden y
        //complilar mas la lectura el codigo fuente 

        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        private DataTable ListaUsuario { get; set; }    


        public FrmUsuariosGestion()
        {
            InitializeComponent();
            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuario= new DataTable();

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {

            //defidimos el padre mdi 
            MdiParent = Globales.MiFormPrincipal;

            CargarListaRoles();
            
            CargarListaPorUsuarios();


        }

        private void CargarListaPorUsuarios() 
        
        { 
         ListaUsuario= new DataTable();

            if (CboxVerActivos.Checked)
            {
                ListaUsuario = MiUsuarioLocal.ListarActivos();
            }
            else
            {
                ListaUsuario = MiUsuarioLocal.ListarInactivos();
            }

            DgLista.DataSource= ListaUsuario;

     
        
        
        
        
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

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();   
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando seleciones una fia del daragidrd sedebe cargar la info de dicho usuario
            //en el ususario y leufo esta info en kloscontrploes

            if (DgLista.SelectedRows.Count == 1)
                {

                DataGridViewRow Mifila = DgLista.SelectedRows[0];

                //lo que se necisito es el valo rID del Ususario para realizae la cosuta
                //y traaer los datos lenel objeto de usuario local
                int IdUsuario = Convert.ToInt32(Mifila.Cells["CUsuarioID"].Value);


                MiUsuarioLocal = new Logica.Models.Usuario();

                //le agregamos el valoe obrenodo por la fia+la ik dekn usuario local
                MiUsuarioLocal.UsuarioID = IdUsuario;


                //una vexz que tengo el objeto local cone el valoer

                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0 )
                {
                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);

                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;

                    TxtCedula.Text = MiUsuarioLocal.UsuarioCedula;

                    TxtTelefono.Text = MiUsuarioLocal.UsuarioTelefono;

                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;

                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;


                    //combobox
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;

                    //tod dessativar botones 


                }



            }



        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularios();
        }

        private void LimpiarFormularios()
        {
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtCedula.Clear();  
            TxtTelefono.Clear();    
            TxtUsuarioCorreo.Clear();
            TxtUsuarioContrasennia.Clear();

            CbRolesUsuario .SelectedIndex = -1;

            TxtUsuarioDireccion.Clear();


        }

        private bool ValidarDatosDigitados()
        {
            bool  R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtCedula.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtTelefono.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                 !string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()) &&
                 CbRolesUsuario.SelectedIndex > -1
                 )
            {
                R = true;
            }
            else
            {
                //que pasa cuando algo falta 

                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre de ususario", "", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula para el ususario", "✘", MessageBoxButtons.OK);
                    TxtCedula.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono para el ususario", "✘", MessageBoxButtons.OK);
                    TxtTelefono.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el ususario", "✘", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una contraseña para el ususario", "✘", MessageBoxButtons.OK);
                    TxtUsuarioContrasennia.Focus();
                    return false;
                }

                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol para el ususario", "✘", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }


            


        }



            return R;


        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(ValidarDatosDigitados())
            {

            

            bool CedulaOk;
            bool EmailOk;

            MiUsuarioLocal = new Logica.Models.Usuario();

            MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
            MiUsuarioLocal.UsuarioCedula = TxtCedula.Text.Trim();   
            MiUsuarioLocal.UsuarioTelefono = TxtTelefono.Text.Trim();   
            MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();    
            MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasennia.Text.Trim();

            MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);
            MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();
            //1.3 y 1.3.6
            CedulaOk = MiUsuarioLocal.ConsultarPorCedula();

          //  1.4 y 1.4.6

            EmailOk = MiUsuarioLocal.ConsultarPorEmail();

            //1.5

            //see puede agregar el usuario ya que no existe 

            if (CedulaOk == false && EmailOk == false)
            {


                string msg = string.Format("¿Esta seguro que desea agregar al usuario {0}?", MiUsuarioLocal.UsuarioNombre);

                DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {

                    bool ok = MiUsuarioLocal.Agregar();

                    if (ok)
                    {
                        MessageBox.Show("Usuario guardado correctamente!", ":)", MessageBoxButtons.OK);

                        LimpiarFormularios();
                        CargarListaPorUsuarios();

                    }
                    else
                    {
                        MessageBox.Show("El Usuario no se pudo guardar  ", ":/", MessageBoxButtons.OK);

                    }

                }
            
            }
            if (CedulaOk)
            {
                MessageBox.Show("Ya existe un usuario con la cedula digitada", "Error de Validacion", MessageBoxButtons.OK);
                return;
            }
            if (EmailOk)
            {
                MessageBox.Show("Ya existe un usuario con el correo digitado ", "Error de Validacion", MessageBoxButtons.OK);
                return;
            }
        
        




        }







    }
    }

}