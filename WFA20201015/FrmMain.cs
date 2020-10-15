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
    public partial class FrmMain : Form
    {
        static SqlConnection conn; 
        public FrmMain()
        {
            conn = new SqlConnection(
                @"Server = (localdb)\MSSQLLocalDB;" +
                @"AttachDbFileName=|DataDirectory|\res\turautvonalak.mdf;");
            InitializeComponent();
        }
        public void DgvFeltolt()
        {
            dgvTurazok.Rows.Clear();
            conn.Open();
            var cmd = new SqlCommand("SELECT * FROM turazo;", conn);
            var r = cmd.ExecuteReader();
            while (r.Read())
            {
                dgvTurazok.Rows.Add(r[0], r[1], r[2], r[3], r[4]);
            }
            conn.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DgvFeltolt();
        }
    }
}
