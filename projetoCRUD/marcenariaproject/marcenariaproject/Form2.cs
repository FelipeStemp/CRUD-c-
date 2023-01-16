using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlConnection = System.Data.SqlClient.SqlConnection;

namespace marcenariaproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGNJ7NB;Initial Catalog=marcenaria;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into clientes values(@nome,@numero,@nf," +
                "@valor,@entrada,@despesas,@parcelas,@pagas,@data,@descricao)", con);
            cmd.Parameters.AddWithValue("@nome", textNome.Text);
            cmd.Parameters.AddWithValue("@numero", Int64.Parse(texteTel.Text));
            cmd.Parameters.AddWithValue("@nf", textNF.Text);
            cmd.Parameters.AddWithValue("@valor", Int64.Parse(textValor.Text));
            cmd.Parameters.AddWithValue("@entrada", Int64.Parse(textEntrada.Text));
            cmd.Parameters.AddWithValue("@despesas", Int64.Parse(textDespesas.Text));
            cmd.Parameters.AddWithValue("@parcelas", Int64.Parse(cbParcelas.Text));
            cmd.Parameters.AddWithValue("@pagas", Int64.Parse(cbPagas.Text));
            cmd.Parameters.AddWithValue("@data", data.Value);
            cmd.Parameters.AddWithValue("@descricao", textDesc.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("adicionado");
        }

        public void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void texteTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
