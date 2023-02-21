using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StajDataBase
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
       
        private void Main_Load(object sender, EventArgs e)
        {
            
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumAquamarine;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            
            dataGridView2.EnableHeadersVisualStyles = false;
            Class1.cnt = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DataBase1.accdb");
            Class1.adp = new OleDbDataAdapter("select * from Tablo1", Class1.cnt);
            Class1.cnt.Open();
            Class1.dt = new DataTable();
            Class1.adp.Fill(Class1.dt);
            
            dataGridView2.DataSource = Class1.dt;



            
       


    }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            


        }

        private void Btn_ekle_Click(object sender, EventArgs e)
        {
            ekle frm2= new ekle();
            frm2.ShowDialog();
        }

        private void DataGridView2_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void DataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            degistir frmDegis = new degistir();
            frmDegis.ShowDialog();
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            sil_barkod frm = new sil_barkod();
            frm.ShowDialog();
        }

        private void DataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Class1.barkod = dataGridView2.CurrentRow.Cells["barkod"].Value.ToString();
        }

        private void Rb_mustu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Btn_pulver_Click(object sender, EventArgs e)
        {
            Class1.cnt = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DataBase1.accdb");
            Class1.adp = new OleDbDataAdapter("select * from Tablo1 where firma='PULVER'", Class1.cnt);
            Class1.cnt.Open();
            Class1.dt = new DataTable();
            Class1.adp.Fill(Class1.dt);

            dataGridView2.DataSource = Class1.dt;
        }

        private void btn_conta_Click(object sender, EventArgs e)
        {
            Class1.cnt = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DataBase1.accdb");
            Class1.adp = new OleDbDataAdapter("select * from Tablo1 where firma='ELASTRON'", Class1.cnt);
            Class1.cnt.Open();
            Class1.dt = new DataTable();
            Class1.adp.Fill(Class1.dt);

            dataGridView2.DataSource = Class1.dt;
        }

        private void btn_elastron_Click(object sender, EventArgs e)
        {
            Class1.cnt = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DataBase1.accdb");
            Class1.adp = new OleDbDataAdapter("select * from Tablo1 where firma='CONTA'", Class1.cnt);
            Class1.cnt.Open();
            Class1.dt = new DataTable();
            Class1.adp.Fill(Class1.dt);

            dataGridView2.DataSource = Class1.dt;
        }

        private void Btn_pec_Click(object sender, EventArgs e)
        {
            Class1.cnt = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =DataBase1.accdb");
            Class1.adp = new OleDbDataAdapter("select * from Tablo1", Class1.cnt);
            Class1.cnt.Open();
            Class1.dt = new DataTable();
            Class1.adp.Fill(Class1.dt);

            dataGridView2.DataSource = Class1.dt;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult Soru;

            Soru = MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Uyarı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (Soru == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
