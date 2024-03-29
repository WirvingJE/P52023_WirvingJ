﻿using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Compra
    {
        //propiedades
        public int CompraID { get; set; }
        public DateTime CompraFecha { get; set; }   
        public int CompraNumero { get; set; }

        public string CompraNotas { get;set; }

        public bool Activo { get; set; }    

        public Usuario MiUsuario { get; set; }
        public Proveedor MiProveedor { get; set; }

        public TipoCompra MiTipoCompra { get; set; }    

        //complejas
        public List<CompraDetalle> ListaDetalles { get; set; }

        //constructor
        public Compra()
        {
            MiUsuario= new Usuario();
            MiProveedor= new Proveedor();
            MiTipoCompra= new TipoCompra();
            ListaDetalles= new List<CompraDetalle>();

        }

        public DataTable CargarEsquemaDetalle()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPCompraDetalleEsquema", true);

            R.PrimaryKey = null;

            return R;

        }




        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            //lista de parametros 
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDProveedor", this.MiProveedor.ProveedorID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDTipoCompra", this.MiTipoCompra.CompraTipoID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IDUsuario", this.MiUsuario.UsuarioID));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.CompraNotas));

            Object retorno = MiCnn.EjecutarSELECTEscalar("SPCompraAgregar");

          

            int IDCreada;

            if (retorno != null)
            {
                try
                {
                    IDCreada = Convert.ToInt32(retorno.ToString());

                    this.CompraID = IDCreada;

                

                    foreach (CompraDetalle item in this.ListaDetalles)
                    {
                        Conexion MiCnnDetalle = new Conexion();

                        
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDCompra", IDCreada));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@IDProducto", item.MiProducto.ProductoID));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Cantidad", item.Cantidad));
                        MiCnnDetalle.ListaDeParametros.Add(new SqlParameter("@Precio", item.PrecioUnitario));

                        MiCnnDetalle.EjecutarInsertUpdateDelete("SPCompraDetalleAgregar");

                    }

                    R = true;

                }
                catch (Exception)
                {

                    throw;
                }


            }



            return R;

        }



    }
}
