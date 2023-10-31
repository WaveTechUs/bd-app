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
        public Form1()
        {
            InitializeComponent();
            string conStringUser = "User Id=" + user + ";Password=" + pwd + ";Data Source=" + db + ";";

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
                            cor.NomeCor = reader.GetString(1);
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
    }
}