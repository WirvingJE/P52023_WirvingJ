using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P52023_WirvingJ
{
    public static class Globales
    {
        //Estas propiedades al prerenecer a la case 

        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        //Debemos tener un objeto de tipo usuario que perita almacenar los datos del ususrio que se haya logiago crrectmente

        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Formularios.FrmRegistroCompras MiFormRegistroCompra = new Formularios.FrmRegistroCompras();






    }
}
