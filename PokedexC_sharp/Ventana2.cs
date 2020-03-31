using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaSelecccionPokemon : Form
    {

        public int idSeleccionado;

        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();

        public VentanaSelecccionPokemon()
        {
            InitializeComponent();

            dataGridView2.DataSource = miConexion.getTodosPokemons();
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionado = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["id"].Value.ToString());
            this.Close();


        }
    }
}




