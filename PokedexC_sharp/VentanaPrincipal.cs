using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1;// el pokemon que estamos viendo

        public VentanaPrincipal()
        {
            InitializeComponent();
         
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }


        private void izq_Click(object sender, EventArgs e)
        {
            idActual--;
            if(idActual <= 0) { idActual = 1; }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void der_Click(object sender, EventArgs e)
        {

            idActual++;
            if (idActual >= 151) { idActual = 151; }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // VentanaSelecccionPokemon v = new VentanaSelecccionPokemon();
            //v.cambiaNombrePokemon("Bulbasaur");
            //v.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //nombrePokemon.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            //pictureBox1.Image = convierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value);
           

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           // String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            //String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

           // MessageBox.Show(miConexion.actualizaPokemon(id, nombre));
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nombrePokemon_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VentanaSelecccionPokemon eligePokemon = new VentanaSelecccionPokemon();
            eligePokemon.ShowDialog();
            idActual = eligePokemon.idSeleccionado;
            // MessageBox.Show(eligePokemon.idSeleccionado.ToString());
            misPokemons = miConexion.getPokemonPorId(eligePokemon.idSeleccionado);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }
    }
}
