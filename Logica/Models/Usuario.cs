﻿using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;

namespace Logica.Models
{
    public class Usuario
    {

        public int UsuarioID { get; set; } 
        
        public string UsuarioCorreo { get; set; }

        public string UsuarioContrasennia { get;set; }  

        public string UsuarioNombre { get; set; }

        public string UsuarioCedula { get; set; }

        public string UsuarioTelefono { get; set; }

        public string UsuarioDireccion { get; set; }


        public bool Activo { get; set; }    


        //propiedades compuestas
        public Usuario_Rol MiRolTipo { get; set; }

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

        public Usuario ConsultarPorIDRetornaUsuario()
        {

            Usuario R = new Usuario();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID", this.UsuarioID));

            DataTable dt= new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorID");

            if(dt != null && dt.Rows.Count > 0 )
            {
                DataRow dr = dt.Rows[0];

                R.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                R.UsuarioNombre = Convert.ToString(dr["UsuarioNombre"]);


                R.UsuarioCedula = Convert.ToString(dr["UsuarioCedula"]);
                R.UsuarioCorreo = Convert.ToString(dr["UsuarioCorreo"]);
                R.UsuarioTelefono = Convert.ToString(dr["UsuarioTelefono"]);
                R.UsuarioDireccion = Convert.ToString(dr["UsuarioDireccion"]);

                R.UsuarioContrasennia = string.Empty;

                //composiciones 
                R.MiRolTipo.UsuarioRolID = Convert.ToInt32(dr["UsuarioRolID"]);
                R.MiRolTipo.UsuarioRolDescripcion = Convert.ToString(dr["UsuarioRolDescripcion"]);






            }




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

            Conexion MiCnn = new Conexion();
            //este caso como sp tiene parametro,debemos por lo tanto defineir ese parametro
            //en la 
            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", true));

            R = MiCnn.EjecutarSELECT("SPUsuarioListar ");


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
