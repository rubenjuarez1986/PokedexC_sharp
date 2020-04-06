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
        public static int idActual = 1;// el pokemon que estamos viendo

        public VentanaPrincipal()
        {
            InitializeComponent();
         
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }


        private void izq_Click(object sender, EventArgs e)//paso la imagen a la izquierda
        {
            idActual--;
            if(idActual <= 0) { idActual = 1; }
            misPokemons = miConexion.getPokemonPorId(idActual);
            enseñaPokemon(idActual);

        }

        private void der_Click(object sender, EventArgs e)//paso la imagen a la derecha
        {

            idActual++;
            if (idActual >= 151) { idActual = 151; }
            misPokemons = miConexion.getPokemonPorId(idActual);
            enseñaPokemon(idActual);
           
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

        private void button1_Click_1(object sender, EventArgs e)//pulsando este boton voy a otro form que es un DataGidView
        {
            VentanaSelecccionPokemon eligePokemon = new VentanaSelecccionPokemon();
            eligePokemon.ShowDialog();
            idActual = eligePokemon.idSeleccionado;
           //MessageBox.Show(eligePokemon.idSeleccionado.ToString());
            misPokemons = miConexion.getPokemonPorId(idActual);
            enseñaPokemon(idActual);
           
           
        }

        //Metodo que muestra toda la informacion de los pokemons
        public void enseñaPokemon(int id)//aqui pinto todas las cualidades de los pokemons que quiero que salgan
        {
            misPokemons = miConexion.getPokemonPorId(id);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            areaPokemon.Text = "Area: " + misPokemons.Rows[0]["habitat"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            idPokemon.Text = "Nº: " + misPokemons.Rows[0]["id"].ToString();
            descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();
            ataquePokemon1.Text = "1.- " + misPokemons.Rows[0]["movimiento1"].ToString();
            ataquePokemon2.Text = "2.- " + misPokemons.Rows[0]["movimiento2"].ToString();
            AtaquePokemon3.Text = "3.- " + misPokemons.Rows[0]["movimiento3"].ToString();
            AtaquePokemon4.Text = "4.- " + misPokemons.Rows[0]["movimiento4"].ToString();
            tipoPokemon1.Text = "Tipo 1: " + misPokemons.Rows[0]["tipo1"].ToString();
            tipoPokemon2.Text = "Tipo 2: " + misPokemons.Rows[0]["tipo2"].ToString();
            especiePokemon.Text = "Especie: " + misPokemons.Rows[0]["especie"].ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//pulsando este boton abro una imagen
        {
            ventanaPokemon ventana = new ventanaPokemon();
            ventana.Show();

        }

        private void buscador_Click(object sender, EventArgs e)// pulsando este boton voy al buscador
        {
            BuscadorPokemon ventana = new BuscadorPokemon(this);
            ventana.Show();
        }
    }
}
