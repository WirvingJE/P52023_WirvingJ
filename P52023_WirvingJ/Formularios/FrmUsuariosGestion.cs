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
    }
}
