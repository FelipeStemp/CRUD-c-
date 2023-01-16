using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace marcenariaproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 tela2 = new Form2();
            tela2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGNJ7NB;Initial Catalog=marcenaria;Integrated Security=True");
            con.Open();

            var sqlQuery = "SELECT * FROM clientes";

            using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con))
            {
                using (DataTable dt = new DataTable())
                {
                    da.Fill(dt);
                    gridPrincipal.DataSource = dt;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGNJ7NB;Initial Catalog=marcenaria;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT nome,numero,nf,valor,entrada,despesas,parcelas,pagas,data,descricao FROM clientes WHERE id = '"+int.Parse(consulta.Text)+"'",con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtNome.Text = dr[0].ToString();
                txtTel.Text = dr[1].ToString();
                txtNF.Text = dr[2].ToString();
                txtValor.Text = dr[3].ToString();
                txtEntrada.Text = dr[4].ToString();
                txtDespesas.Text = dr[5].ToString();
                cbParcelas.Text = dr[6].ToString();
                cbPagas.Text = dr[7].ToString();
                dataUP.Text = dr[8].ToString();
                txtDesc.Text = dr[9].ToString();
            }

            con.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TGNJ7NB;Initial Catalog=marcenaria;Integrated Security=True");


            con.Open();
            SqlCommand cmd = new SqlCommand(" UPDATE clientes " +
                "SET nome=@nome, numero=@numero, nf=@nf, valor=@valor, entrada=@entrada, despesas=@despesas,parcelas=@parcelas,pagas=@pagas, data=@data, descricao=@descricao " +
                "WHERE id = '"+ int.Parse(consulta.Text) + "'", con);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@numero", Int64.Parse(txtTel.Text));
            cmd.Parameters.AddWithValue("@nf", txtNF.Text);
            cmd.Parameters.AddWithValue("@valor", Int64.Parse(txtValor.Text));
            cmd.Parameters.AddWithValue("@entrada", Int64.Parse(txtEntrada.Text));
            cmd.Parameters.AddWithValue("@despesas", Int64.Parse(txtDespesas.Text));
            cmd.Parameters.AddWithValue("@parcelas", Int64.Parse(cbParcelas.Text));
            cmd.Parameters.AddWithValue("@pagas", Int64.Parse(cbPagas.Text));
            cmd.Parameters.AddWithValue("@data", dataUP.Value);
            cmd.Parameters.AddWithValue("@descricao", txtDesc.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Atualizado");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void excel_Click(object sender, EventArgs e)
        {

            if (gridPrincipal.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                try
                {
                    

                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1 ; i < gridPrincipal.Columns.Count -1; i++)
                    {
                        XcelApp.Cells[1, i] = gridPrincipal.Columns[i - 1].HeaderText;
                    }
                    //
                    for (int i = 0; i < gridPrincipal.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < gridPrincipal.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = gridPrincipal.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
            

        }
    }
}