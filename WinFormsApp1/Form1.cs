using Oracle.ManagedDataAccess.Client;
using System.Data;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static string user = "rm93102";
        public static string pwd = "140104";
        public static string db = "oracle.fiap.com.br/orcl";
        string conStringUser = "User Id=" + user + ";Password=" + pwd + ";Data Source=" + db + ";";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(conStringUser))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        con.Open();
                        connectionText.Text = "Conectado ao banco";

                        cmd.CommandText = "SELECT COR_ID, NOME_COR FROM COR";
                        OracleDataReader reader = cmd.ExecuteReader();
                        List<Cor> list = new List<Cor>();
                        while (reader.Read())
                        {
                            Cor cor = new Cor();
                            cor.Nome = reader.GetString(1);
                            list.Add(cor);
                        }

                        dataGrid.DataSource = list;

                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = new OracleConnection(conStringUser))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        con.Open();
                        connectionText.Text = "Conectado ao banco";

                        cmd.CommandText = "SELECT NOME_FORNECEDOR FROM FORNECEDOR";
                        OracleDataReader reader = cmd.ExecuteReader();
                        List<Fornecedor> list = new List<Fornecedor>();
                        while (reader.Read())
                        {
                            Fornecedor fornecedor = new Fornecedor();
                            fornecedor.Nome = reader.GetString(0);
                            list.Add(fornecedor);
                        }

                        dataGrid.DataSource = list;

                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

        }
    }
}