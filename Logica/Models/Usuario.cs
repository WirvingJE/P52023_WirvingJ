using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {

        public int UsurioID { get; set; } 
        
        public string UsuarioCorreo { get; set; }

        public string UsuarioContrasennia { get;set; }  

        public string UsarioNombre { get; set; }

        public string UsarioCedula { get; set; }

        public string UsarioTelefono { get; set; }

        public string UsarioDireccion { get; set; }


        public bool Activo { get; set; }    


        //propiedades compuestas
        Usuario_Rol MiRolTipo { get; set; }

        //normalmente cuando tenemos propiedades compuestas contipos
        // hemos programado nosotros mismos , den¿bemos instaciar dichas propiedades 
        //ya que son objetos
        //para esto recomiento hacerlo en el constructor de la clase

        public Usuario()
        {//al crear una nueva instancia de la clase Usaio, se ejecuta el codigi 
            // de este  constructor y tambien crear una nueva instancia de a clase 
            // usario_rol para el objweto Miroltipo

            MiRolTipo= new Usuario_Rol();


        }


        //funciones y metodos 

        public bool Agregar()
        {
            // cuando a funcio devuelve un boll me gusta inicializa la variablr de
            //retorno en false (tiende a negativo el resultado de la fn)
            //y solo si la opreciopn (en este caso insert) sale corecta 
            //se cambia el valor de R a true
            bool R = false;

            //aca ca el codigo funciional que invoca a un procedimiento almacenado
            //que contine el dml

            return R;
        }

        public  bool Editar()
        {

            bool R = false;
            return R;
        }

        public bool Eliminar()
        {

            bool R = false;
            return R;
        }

        public bool ConsultarPorID()
        {

            bool R = false;
            return R;
        }

        public bool ConsultarPorCedula()
        {

            bool R = false;
            return R;
        }

        public bool ConsultarPorEmail()
        {

            bool R = false;
            return R;
        }

     

        public DataTable ListarActivos()
        {

            DataTable R = new DataTable();

            return R;
        }

        public DataTable ListarInactivos()
        {

            DataTable R = new DataTable();

            return R;
        }

        public Usuario ValidarUsuario(string pEmail,string PContrasennia)
        {

            Usuario R = new Usuario();

            return R;

        }





    }






}
