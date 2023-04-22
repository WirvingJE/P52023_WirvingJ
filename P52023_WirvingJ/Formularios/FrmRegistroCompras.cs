using Logica.Models;
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
    public partial class FrmRegistroCompras : Form
    {

        //tem para para probar
        

        //crear el objeto de compra local

        public Compra MiCompraLocal { get; set; }
        public DataTable ListaProductos { get; set; }  

        public FrmRegistroCompras()
        {
            InitializeComponent();
            MiCompraLocal = new Compra();
            ListaProductos= new DataTable();
        }

        private void FrmRegistroCompras_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.MiFormPrincipal;





        }

        private void BtnProveedorBusccar_Click(object sender, EventArgs e)
        {

            Form FormBusquedaProveedor = new FrmProveedorBuscar();

           DialogResult respuesta = FormBusquedaProveedor.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                //usamos las composicionea a provvedor para extraer el valor del nombd¿re del porveedor
                TxTProveedorNombre.Text = MiCompraLocal.MiProveedor.ProveedorNombre;

            }

        }

        private void TxTProveedorNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {

            Form MiFormBusquedaItem = new FrmCompraAgregarProducto();

            DialogResult repuesta = MiFormBusquedaItem.ShowDialog();

            if(repuesta == DialogResult.OK)
            {
                DgvLista.DataSource = ListaProductos;


            }


        }
    }
}
