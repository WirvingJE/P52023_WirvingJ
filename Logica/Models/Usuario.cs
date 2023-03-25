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
            // pasos 1.6.1 y 1.6.2
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", this.UsuarioContrasennia));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.UsuarioNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.UsuarioTelefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.UsuarioDireccion));

            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdRol", this.MiRolTipo.UsuarioRolID));


            // paso 1.6.3 y 1.6.4

            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPUsuarioAgregar");
            //paso1.6.5

            if(resultado > 0)
            {
                R = true;
            }

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

            // paso 131 132
            Conexion MiCnn= new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.UsuarioCedula));

            DataTable consulta = new DataTable();

            //paso 1.3.3 y 1.3.4
            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorCedula");

            //paso 1.3.5
            if(consulta != null && consulta.Rows.Count > 0)
                {
                R = true;

            }



            return R;
        }

        public bool ConsultarPorEmail()
        {

            bool R = false;

            // paso 141 142
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.UsuarioCorreo));

            DataTable consulta = new DataTable();

            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPUsuarioConsultarPorEmail");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;

            }





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
