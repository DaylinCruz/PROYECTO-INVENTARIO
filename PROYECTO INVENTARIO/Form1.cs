namespace PROYECTO_INVENTARIO
{
    public partial class Form1 : Form
    {
        //private List<Clase1> listaIdatos = new List<Clase1>();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnagregar_Click(object sender, EventArgs e)
        { DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvtabla);
            fila.Cells[0].Value = txtcodigo.Text;
            //fila.Cells[0].Value = txtfecha.Text;
            fila.Cells[1].Value = txtproducto.Text;
            fila.Cells[2].Value = txtcosto.Text;
            fila.Cells[2].Value = txtcantidad.Text;
            //fila.Cells[2].Value = txtpreciodeventa.Text;


            dgvtabla.Rows.Add(fila);


            //    using (BinaryWriter archivo = new BinaryWriter(File.Open("inventarios.bin", FileMode.Create)))
            //    {
            //        archivo.Write(txtcodigo.Text);
            //        archivo.Write(txtproducto.Text);
            //        foreach (Clase1 clase1 in listaIdatos)
            //        {
            //            txtproducto.Text = clase1.Producto;
            //            txtcodigo.Text = clase1.Codigo;
            //            archivo.Write(clase1.Producto);
            //            archivo.Write(clase1.Codigo);
            //        }
            //        txtproducto.Clear();
            //        txtcodigo.Clear();
            //    }
            //    using (BinaryReader lector = new BinaryReader(File.Open("inventarios.bin", FileMode.Open)))
            //    {
            //        listaIdatos.Clear();
            //        while (lector.PeekChar() > -1)
            //        {
            //            string producto = lector.ReadString();
            //            string codigo = lector.ReadString();

            //            listaIdatos.Add(new Clase1 (producto,codigo));
            //        }
            //        dgvtabla.DataSource = null;
            //        dgvtabla.DataSource = listaIdatos;

            //    }
        }
    }
}