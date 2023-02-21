using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajDataBase
{
    public partial class sil_barkod : Form
    {
        public sil_barkod()
        {
            InitializeComponent();
        }

        private void Txt_barkodSil_Enter(object sender, EventArgs e)
        {
           
        }

        private void Txt_barkodSil_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sil_barkod_Enter(object sender, EventArgs e)
        {
            
        }

        private void Txt_barkodSil_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Btn_sil_Click(object sender, EventArgs e)
        {
            Class1.cmd = new System.Data.OleDb.OleDbCommand("delete from Tablo1 where barkod = '" + txt_barkodSil.Text + "'", Class1.cnt);
            Class1.cmd.ExecuteNonQuery();
            MessageBox.Show("SİLİNDİ !");
            Application.Restart();
        }
    }
}
