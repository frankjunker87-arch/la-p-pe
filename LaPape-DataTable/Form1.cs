using System;
using System.Windows.Forms;
using System.Data;

namespace LaPape_DataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable tablaVentas;

        private void btnCrearTabla_Click(object sender, EventArgs e)
        {
            tablaVentas = new DataTable("TablaVentas");

        }

        private void CrearEsquemaVentas()
        {
            DataColumn columna = new DataColumn("FolioVenta", typeof(int));
            columna.Unique = true;
            columna.AutoIncrement = true;
            columna.AutoIncrementStep = 1;
            columna.AutoIncrementSeed = 1;
            columna.AllowDBNull = false;
            tablaVentas.Columns.Add(columna);

            tablaVentas.Columns.Add(columna);
            columna = new DataColumn("Vendedor", typeof(string));
            columna.MaxLength = 100;
            columna.AllowDBNull = false;
            tablaVentas.Columns.Add(columna);

            tablaVentas.Columns.Add(columna);
            columna = new DataColumn("Fecha-Hora", typeof(string));
            columna.MaxLength = 100;
            columna.AllowDBNull = false;
            tablaVentas.Columns.Add(columna);

            tablaVentas.Columns.Add(columna);
            columna = new DataColumn("Cantidad total", typeof(int));
            columna.AllowDBNull = false;
            tablaVentas.Columns.Add(columna);

            tablaVentas.Columns.Add(columna);
            columna = new DataColumn("Descuento", typeof(int));
            columna.AllowDBNull = false;
            tablaVentas.Columns.Add(columna);

            tablaVentas.PrimaryKey = new DataColumn[] {tablaVentas.Columns[0], tablaVentas.Columns[1] };

        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            DataRow nuevaVenta = tablaVentas.NewRow();
            nuevaVenta[0] = 0000001;
            nuevaVenta[1] = "Jose Perez";
            nuevaVenta[2] = "08-08-2015";
            nuevaVenta[3] = 189;
            nuevaVenta[4] = 0;

            tablaVentas.Rows.Add(nuevaVenta);
            tablaVentas.LoadDataRow(new object[] { 0000002, "Jose Perez", "09-08-2015", 378, 0 }, LoadOption.OverwriteChanges);
            tablaVentas.Rows.Add(0000003, "Jose Perez", "10-08-2015", 598, 0);
        }
    }
}
