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
    public partial class degistir : Form
    {
        public degistir()
        {
            InitializeComponent();
        }
        
        private void Degistir_Load(object sender, EventArgs e)
        {
            cmb_firma.Items.Add("PULVER");
            cmb_firma.Items.Add("ELASTRON");
            cmb_firma.Items.Add("CONTA");

            cmb_bolum.Items.Add("AR-GE");
            cmb_bolum.Items.Add("ÜRETİM");
            cmb_bolum.Items.Add("MUHASEBE");
            cmb_bolum.Items.Add("SATIN ALMA");
            cmb_bolum.Items.Add("PAZARLAMA");


            Class1.adp = new OleDbDataAdapter("select * from Tablo1 where barkod= '" + Class1.barkod + "'", Class1.cnt);
            DataTable dt = new DataTable();
            Class1.adp.Fill(dt);
       
            cmb_ulke.Text= dt.Rows[0][0].ToString();
            txt_sehir.Text= dt.Rows[0][1].ToString();
            cmb_firma.Text=dt.Rows[0][2].ToString();
            cmb_bolum.Text=dt.Rows[0][3].ToString();
            txt_barkod.Text=dt.Rows[0][4].ToString();
            txt_kullanici.Text=dt.Rows[0][5].ToString();
            txt_marka.Text=dt.Rows[0][6].ToString();
            txt_model.Text=dt.Rows[0][7].ToString();
            txt_islemci.Text=dt.Rows[0][8].ToString();
            txt_bellek.Text=dt.Rows[0][9].ToString();
            txt_ssd.Text=dt.Rows[0][10].ToString();
            txt_hdd.Text=dt.Rows[0][11].ToString();
            txt_inch.Text=dt.Rows[0][12].ToString();
            txt_gpu.Text=dt.Rows[0][13].ToString();
            txt_date .Text= dt.Rows[0][14].ToString();
            txt_fiyat.Text= dt.Rows[0][15].ToString();
            txt_isletimsis.Text= dt.Rows[0][16].ToString();
            txt_office.Text= dt.Rows[0][17].ToString();

        }

        private void Btn_onay_Click(object sender, EventArgs e)
        {
            Class1.cmd = new System.Data.OleDb.OleDbCommand("update Tablo1 set ulke = @ulke, sehir = @sehir,firma= @firma ,bolum= @bolum , barkod=@barkod ,kullanici= @kullanici , marka=@marka ,model= @model, islemci=@islemci , bellek=@bellek ,ssd= @ssd ,hdd= @hdd,inch= @inch ,ekran_karti= @gpu ,faturaTarihi= @fatura ,fiyat= @fiyat ,isletimSistemi =@iSistem , office =@ofis where barkod ='"+Class1.barkod+"'", Class1.cnt);
            Class1.cmd.Parameters.AddWithValue("@ulke", cmb_ulke.Text);
            Class1.cmd.Parameters.AddWithValue("@sehir", txt_sehir.Text);
            Class1.cmd.Parameters.AddWithValue("@firma", cmb_firma.Text);
            Class1.cmd.Parameters.AddWithValue("@bolum", cmb_bolum.Text);
            Class1.cmd.Parameters.AddWithValue("@barkod", txt_barkod.Text);
            Class1.cmd.Parameters.AddWithValue("@kullanici", txt_kullanici.Text);
            Class1.cmd.Parameters.AddWithValue("@marka", txt_marka.Text);
            Class1.cmd.Parameters.AddWithValue("@model", txt_model.Text);
            Class1.cmd.Parameters.AddWithValue("@islemci", txt_islemci.Text);
            Class1.cmd.Parameters.AddWithValue("@bellek", txt_bellek.Text);
            Class1.cmd.Parameters.AddWithValue("@ssd", txt_ssd.Text);
            Class1.cmd.Parameters.AddWithValue("@hdd", txt_hdd.Text);
            Class1.cmd.Parameters.AddWithValue("@inch", txt_inch.Text);
            Class1.cmd.Parameters.AddWithValue("@gpu", txt_gpu.Text);
            Class1.cmd.Parameters.AddWithValue("@fatura", txt_date.Text);
            Class1.cmd.Parameters.AddWithValue("@fiyat", txt_fiyat.Text);
            Class1.cmd.Parameters.AddWithValue("@iSistem", txt_isletimsis.Text);
            Class1.cmd.Parameters.AddWithValue("@ofis", txt_office.Text);
            Class1.cmd.ExecuteNonQuery();
            MessageBox.Show("DEĞİŞTİ");
            Application.Restart();
        }

        private void Degistir_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            

        }
    }
}
