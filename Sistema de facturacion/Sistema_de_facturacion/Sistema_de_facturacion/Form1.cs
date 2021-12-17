using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LlenaListaClientes();
            MostrarClientes();
            LlenaListaProductos();
            MostrarProductosAgregados();

        }

        List<Cliente> clientes = new List<Cliente>();
        List<Producto> productos = new List<Producto>();
        FacturaDetalle ProductoSeleccionado = new FacturaDetalle();
        List<FacturaDetalle> facturaDetalles =new  List<FacturaDetalle>();
        Factura Factura = new Factura();


        public void LlenaListaClientes() {

            clientes.Add(new Cliente(1, "Jorge", "Matos"));
            clientes.Add(new Cliente(2, "Cristian", "Hernandez"));
            clientes.Add(new Cliente(3, "Adrian", "Lopez"));
        }
        public void MostrarClientes() {

            this.dataGridView1.DataSource = this.clientes;
        
        }

        public void LlenaListaProductos()
        {

            productos.Add(new Producto(1, "Arroz", 250.12f));
            productos.Add(new Producto(2, "ExtraViejo(Jumbo)", 650.00f));
            productos.Add(new Producto(3, "Mabi de bohuco", 25.00f));
            
        }

        public void MostrarProductosAgregados() {


            this.dataGridView2.DataSource = this.productos;
          }

        

        public void MostrarTotalFinal()
        {

            this.Factura.Total = this.facturaDetalles.Sum(x => x.SubTotal);

            this.label8.Text = this.Factura.Total.ToString();

        }

        public void MostrarDetallesAgregados() {

            this.dataGridView3.DataSource = this.facturaDetalles.ToList();
        
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var productoSeleccionado = (Producto)this.dataGridView2.CurrentRow.DataBoundItem;

            this.textBox2.Text = productoSeleccionado.Nombre;
            this.textBox4.Text = "1";
            this.textBox5.Text = productoSeleccionado.Precio.ToString();
            this.textBox6.Text = productoSeleccionado.Precio.ToString();

            this.ProductoSeleccionado = new FacturaDetalle(0,0,productoSeleccionado.ID, productoSeleccionado.Nombre,productoSeleccionado.Precio,1, productoSeleccionado.Precio);

        }

    
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            float cantidad = 1;
            float.TryParse(this.textBox4.Text, out cantidad);

            this.ProductoSeleccionado.Cantidad = cantidad;
            this.ProductoSeleccionado.SubTotal = this.ProductoSeleccionado.Cantidad * this.ProductoSeleccionado.Precio;

            this.textBox6.Text = this.ProductoSeleccionado.SubTotal.ToString();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.facturaDetalles.Add(ProductoSeleccionado);
            this.MostrarDetallesAgregados();
            this.MostrarTotalFinal();
        }

        


    }
}
