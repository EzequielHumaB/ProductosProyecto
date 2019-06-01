using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductosProyecto.BLL;
using ProductosProyecto.DAL;
using ProductosProyecto.Entidades;

namespace ProductosProyecto.UI.Registros
{
    public partial class ProductoRegistros : Form
    {
        public ProductoRegistros()
        {
            InitializeComponent();
        }

       private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CostonumericUpDown.Value = 0;
            ExistencianumericUpDow.Value = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Productos llenarClase()
        {
            Productos productos = new Productos();
            productos.ProductoID = (int)IDnumericUpDown.Value;
            productos.Descripcion = DescripciontextBox.Text;
            productos.existencia = (int)ExistencianumericUpDow.Value;
            productos.costo = (int)CostonumericUpDown.Value;
            int convertor = Convert.ToInt32(TotalInventariotextBox);
            productos.ValorInventario = convertor;
            return productos;
        }

        private void llenarCampo(Productos productos)
        {
            productos.ProductoID = (int)IDnumericUpDown.Value;
            productos.Descripcion = DescripciontextBox.Text;
            productos.costo = (int)CostonumericUpDown.Value;
            productos.existencia = (int)ExistencianumericUpDow.Value;
            int convertor = Convert.ToInt32(TotalInventariotextBox);
            productos.ValorInventario = convertor;
        }




       
    }
}
