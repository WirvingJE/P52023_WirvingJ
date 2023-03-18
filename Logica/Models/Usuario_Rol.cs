using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario_Rol
    {
        //Primero se digitan las prpiedades de la clase

        public int UsarioRolID { get; set; }

        //  public int MyProperty { get; set; }

        //private int usuarioRolID;

        //public int UsuarioRolID
        //{
        //    get { return usuarioRolID; }
        //    set { usuarioRolID = value; }
        //}

        public string UsuarioRolDescripcion { get; set; }   

        // luego de escribir las propiedades simples sedigitan
        //las propiedades compuestas (en este caso no hay )
        // por ultimo se escriben las funciones y metodos 


        public DataTable Listar()
        { 
             DataTable R = new DataTable();

            Services.Conexion MiCnn = new Services.Conexion();

            R = MiCnn.EjecutarSELECT("SPUsuarioRolListar");


            return R;
            
        
        }





    }
}
