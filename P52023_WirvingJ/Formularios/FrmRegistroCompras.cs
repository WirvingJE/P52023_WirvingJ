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

            CargarTiposDeCompra();

            LimpiarForm();



        }

        private void CargarTiposDeCompra()
        {
            DataTable dtTiposCompra = new DataTable();

            dtTiposCompra = MiCompraLocal.MiTipoCompra.Listar();

            CboxCompraTipo .ValueMember = "id";
            CboxCompraTipo.DisplayMember = "descripcion";

            CboxCompraTipo.DataSource = dtTiposCompra;

            CboxCompraTipo.SelectedIndex = -1;

        }


        private void LimpiarForm()
        {
            TxTProveedorNombre.Clear();
            TxtNotas.Clear();
            TxtTotal.Text = "0";
            TxtTotalCantidad.Text = "0";
            CboxCompraTipo.SelectedIndex = -1;
            ListaProductos = new DataTable();

            ListaProductos = MiCompraLocal.CargarEsquemaDetalle();

            DgvLista.DataSource = ListaProductos;

        }

        private void BtnProveedorBusccar_Click(object sender, EventArgs e)
        {

            //se abre un nuevo formulario de busqueda de proveedor  
            //este formulario no es necesario definirlo en los globales (aunque es posible) 

            Form FormBusquedaProveedor = new FrmProveedorBuscar();

            DialogResult respuesta = FormBusquedaProveedor.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                //usamos las composiciones a proveedor para extraer el valor del nombre 
                //del proveedor 
                TxTProveedorNombre.Text = MiCompraLocal.MiProveedor.ProveedorNombre;
            }

        }


        private void Totalizar()
        {
            //Se usa para mostrar los totales en la parte inferior del form 
            if (ListaProductos.Rows.Count > 0)
            {
               

                decimal totalItems = 0;
                decimal totalMonto = 0;

                foreach (DataRow row in ListaProductos.Rows)
                {
                    totalItems += Convert.ToDecimal(row["Cantidad"]);
                   

                    totalMonto += Convert.ToDecimal(row["PrecioVentaUnitario"]) * Convert.ToDecimal(row["Cantidad"]);

                }

                TxtTotalCantidad.Text = totalItems.ToString();

              
                TxtTotal.Text = string.Format("{0:C2}", totalMonto);

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

        private void BtnCrearCompra_Click(object sender, EventArgs e)
        {

           
            if (ValidarCompra())
            {
                
                MiCompraLocal.MiTipoCompra.CompraTipoID = Convert.ToInt32(CboxCompraTipo.SelectedValue);
                MiCompraLocal.CompraNotas = TxtNotas.Text.Trim();

                MiCompraLocal.MiUsuario.UsuarioID = 2;

                TrasladoDetalleListaVisualAObjetoCompra();

               

                if (MiCompraLocal.Agregar())
                {
                    MessageBox.Show("Compra creada correctamente!!", ":)", MessageBoxButtons.OK);

                   

                    LimpiarForm();

                }

            }

        }

        private void TrasladoDetalleListaVisualAObjetoCompra()
        {
            
            foreach (DataRow fila in ListaProductos.Rows)
            {
                CompraDetalle nuevodetalle = new CompraDetalle();

                nuevodetalle.MiProducto.ProductoID = Convert.ToInt32(fila["ProductoID"]);
                nuevodetalle.Cantidad = Convert.ToDecimal(fila["Cantidad"]);
                nuevodetalle.PrecioUnitario = Convert.ToDecimal(fila["PrecioVentaUnitario"]);

                 
                MiCompraLocal.ListaDetalles.Add(nuevodetalle);

            }
        }


        private void VboxCompraTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarCompra()
        {
            bool R = false;

            if (!string.IsNullOrEmpty(TxTProveedorNombre.Text.Trim()) &&
                CboxCompraTipo.SelectedIndex >= 0 &&
                ListaProductos.Rows.Count > 0)
            {
                R = true;
            }
            else
            {
                if (string.IsNullOrEmpty(TxTProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Se debe seleccionar un proveedor", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                if (CboxCompraTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Se debe seleccionar un tipo de compra", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                if (ListaProductos.Rows.Count == 0)
                {
                    MessageBox.Show("Debe haber al menos una fila en el detalle", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;

        }


    }
}
