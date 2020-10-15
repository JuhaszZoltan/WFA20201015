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

namespace WFA20201015
{
    public partial class FrmUjTurazo : Form
    {
        SqlConnection conn;
        public FrmUjTurazo(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            conn.Open();
            var adapter = new SqlDataAdapter()
            {
                InsertCommand = new SqlCommand(
                    "INSERT INTO turazo (vezeteknev, keresztnev, varos, telefonszam) VALUES " +
                    $"('{tbVnev.Text}', '{tbKnev.Text}', '{tbVaros.Text}', '{tbTel.Text}');", conn),
            };
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("siker");
        }
    }
}
