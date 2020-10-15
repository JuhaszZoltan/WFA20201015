using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA20201015
{
    public partial class FrmMain : Form
    {
        SqlConnection conn; 
        public FrmMain()
        {
            AppDomain.CurrentDomain.SetData(
                "DataDirectory",
                Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly()
                    .Location.Replace(@"bin\Debug", @"\res")));
            conn = new SqlConnection(
                @"Server = (localdb)\MSSQLLocalDB;" +
                @"AttachDbFileName=|DataDirectory|turautvonalak.mdf;");
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

        private void btnUj_Click(object sender, EventArgs e)
        {
            var frm = new FrmUjTurazo(conn);
            frm.ShowDialog();
        }

        private void btnFrissites_Click(object sender, EventArgs e)
        {
            DgvFeltolt();
        }
    }
}
