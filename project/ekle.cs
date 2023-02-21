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
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void Ekle_Load(object sender, EventArgs e)
        {
            cmb_firma.Items.Add("PULVER");
            cmb_firma.Items.Add("ELASTRON");
            cmb_firma.Items.Add("CONTA");

            cmb_bolum.Items.Add("AR-GE");
            cmb_bolum.Items.Add("ÜRETİM");
            cmb_bolum.Items.Add("MUHASEBE");
            cmb_bolum.Items.Add("SATIN ALMA");
            cmb_bolum.Items.Add("PAZARLAMA");
        }

        private void Btn_onay_Click(object sender, EventArgs e)
        {
            
            // Class1.cmd = new System.Data.OleDb.OleDbCommand("insert into Tablo1 values ('" +cmb_ulke.SelectedItem +"','"+txt_sehir.Text+"','"+cmb_firma.SelectedItem+"','"+cmb_bolum.SelectedItem+ "','" + txt_barkod.Text + "','" + txt_kullanici.Text + "')",Class1.cnt);
            Class1.cmd = new System.Data.OleDb.OleDbCommand("insert into Tablo1 values (@ulke, @sehir, @firma , @bolum , @barkod , @kullanici , @marka , @model, @islemci , @bellek , @ssd , @hdd, @inch , @gpu , @fatura , @fiyat ,@iSistem , @ofis)", Class1.cnt);
            Class1.cmd.Parameters.AddWithValue("@ulke", cmb_ulke.SelectedItem);
            Class1.cmd.Parameters.AddWithValue("@sehir",txt_sehir.Text );
            Class1.cmd.Parameters.AddWithValue("@firma",cmb_firma.SelectedItem );
            Class1.cmd.Parameters.AddWithValue("@bolum", cmb_bolum.SelectedItem);
            Class1.cmd.Parameters.AddWithValue("@barkod",txt_barkod.Text );
            Class1.cmd.Parameters.AddWithValue("@kullanici",txt_kullanici.Text );
            Class1.cmd.Parameters.AddWithValue("@marka", txt_marka.Text);
            Class1.cmd.Parameters.AddWithValue("@model",txt_model.Text );
            Class1.cmd.Parameters.AddWithValue("@islemci", txt_islemci.Text);
            Class1.cmd.Parameters.AddWithValue("@bellek", txt_bellek.Text);
            Class1.cmd.Parameters.AddWithValue("@ssd", txt_ssd.Text);
            Class1.cmd.Parameters.AddWithValue("@hdd",txt_hdd.Text );
            Class1.cmd.Parameters.AddWithValue("@inch",txt_inch.Text );
            Class1.cmd.Parameters.AddWithValue("@gpu",txt_gpu.Text );
            Class1.cmd.Parameters.AddWithValue("@fatura",txt_date.Text );
            Class1.cmd.Parameters.AddWithValue("@fiyat",txt_fiyat.Text );
            Class1.cmd.Parameters.AddWithValue("@iSistem",txt_isletimsis.Text );
            Class1.cmd.Parameters.AddWithValue("@ofis", txt_office.Text);
            Class1.cmd.ExecuteNonQuery();

            Application.Restart();

        }

        private void Ekle_FormClosed(object sender, FormClosedEventArgs e)
        {
            

            
        }
    }
}
