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

namespace aliveris_otomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt1.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adp = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        DataTable tablo = new DataTable();
        int toplam;
        int id;
        private void Form2_Load(object sender, EventArgs e)
        {
        /*    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox7.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;

            }
          
            else
            {
                button1.Enabled =true;
                button2.Enabled = true;
                button3.Enabled = true;

            }*/
            listele();
            txttarih.Text = dateTimePicker1.Value.ToString();
        }

        void listele()
        {

            bag.Open();

            tablo.Clear();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from musteri", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            adtr.Dispose();

            bag.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmodel.Items.Clear();
            if (cmbmarka.SelectedItem.ToString() == "ASUS")
            {
                cmbmodel.Items.Add("ZENFONE 5");
                cmbmodel.Items.Add("ZENFONE 2");
                
            }
            else if (cmbmarka.SelectedItem.ToString() == "APPLE")
            {
                cmbmodel.Items.Add("IPHONE 5S");
                cmbmodel.Items.Add("IPHONE 6");
            }
            else if (cmbmarka.SelectedItem.ToString() == "CASPER")
            {  
                cmbmodel.Items.Add("VİA M1");
                cmbmodel.Items.Add("VİA V3");
            }
            else if (cmbmarka.SelectedItem.ToString() == "SAMSUNG")
            {
                cmbmodel.Items.Add("S6 EDGE");
                cmbmodel.Items.Add("S7");
            }
            else if (cmbmarka.SelectedItem.ToString() == "LG")
            {
                cmbmodel.Items.Add("G3");
                cmbmodel.Items.Add("G4");
                cmbmodel.Items.Add("V10");
            }
            else if (cmbmarka.SelectedItem.ToString() == "SONY")
            {
                cmbmodel.Items.Add("XPERIA Z4 ");
                cmbmodel.Items.Add("XPERI Z5");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
                try
                {
                    if (cmbmodel.SelectedItem.ToString() == "ZENFONE 5")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 500;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "ZENFONE 2")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 900;
                        txtucret.Text = toplam.ToString();
                    }
                    if (cmbmodel.SelectedItem.ToString() == "APPLE")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 700;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "IPHONE 5S")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 900;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "IPHONE 6")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 1700;
                        txtucret.Text = toplam.ToString();
                    }
                    if (cmbmodel.SelectedItem.ToString() == "CASPER")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 700;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "VİA M1")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 500;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "VİA V3")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 550;
                        txtucret.Text = toplam.ToString();
                    }
                    if (cmbmodel.SelectedItem.ToString() == "SAMSUNG")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 700;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "S6 EDGE")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 1550;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "S7")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 2550;
                        txtucret.Text = toplam.ToString();
                    }
                    if (cmbmodel.SelectedItem.ToString() == "LG")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 700;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "G4")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 1000;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "G5")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 1500;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "V10")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 1000;
                        txtucret.Text = toplam.ToString();
                    }
                    if (cmbmodel.SelectedItem.ToString() == "SONY")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 700;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "XPERIA Z4")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 1100;
                        txtucret.Text = toplam.ToString();
                    }
                    else if (cmbmodel.SelectedItem.ToString() == "XPERIA Z5")
                    {
                        toplam = Convert.ToInt32(txtadet.Text) * 1400;
                        txtucret.Text = toplam.ToString();
                    }

                }
                catch { }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttc.Text != "" && txtad.Text != "" && txtsoyad.Text != "" && txttel.Text != "" && cmbmarka.Text != "")
                {
                    button2.Enabled = true;
                    bag.Open();
                    ds.Clear();
                    komut.Connection = bag;
                    komut.CommandText = "Insert Into musteri (tc_no,ad,soyad,telefon,ımeı_no,marka,model,tarih,adet,ucret) Values ('" + txttc.Text + "','" + txtad.Text + "','" + txtsoyad.Text + "','" + txttel.Text + "','" + txtimei.Text + "','" + cmbmarka.Text + "','" + cmbmodel.Text + "','" + txttarih.Text + "','" + txtadet.Text + "','" + txtucret.Text + "')";

                    komut.ExecuteNonQuery();
                   // komut.Dispose();
                    bag.Close();
                    MessageBox.Show("Kayıt Tamamlandı !!");
                  
                    listele();
                }
                else
                    MessageBox.Show("Kayıt Yerleri boş");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
           bag.Open();
            OleDbCommand silme = new OleDbCommand("delete from musteri where tc_no='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' ", bag);
            silme.ExecuteNonQuery();
            silme.Dispose();
            bag.Close();
            listele();
            }
            catch (Exception)
            {
                
                throw;
            }
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                bag.Open();
               
                OleDbCommand komut = new OleDbCommand("UPDATE musteri SET ad='" + txtad.Text + "',soyad='"+txtsoyad.Text+"',telefon='"+txttel.Text+"',ımeı_no='"+txtimei.Text+"',marka='"+cmbmarka.Text+"',model='"+cmbmodel.Text+"',tarih='"+txttarih.Text+"',adet='"+txtadet.Text+"',ucret='"+txtucret.Text+"' WHERE tc_no='"+txttc.Text+"'",bag);
                komut.ExecuteNonQuery();
                komut.Dispose();
                bag.Close();
                listele();
                MessageBox.Show("Güncelleme İşlemi Tamamlandı !", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Çıkmak ister misiniz ??", "Bilgilendirme Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bag.Open();
            tablo.Clear();
            string cumle = " Select * from musteri where tc_no like '%" + textBox6.Text + "%'  ";
            OleDbDataAdapter ara = new OleDbDataAdapter(cumle, bag);
            ara.Fill(tablo);

            bag.Close();
            dataGridView1.DataSource = tablo;
            
           
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtimei.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbmarka.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbmodel.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txttarih.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtadet.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtucret.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            bag.Open();
            tablo.Clear();
            string cumle = " Select * from musteri where tc_no like '%" + textBox6.Text + "%'  ";
            OleDbDataAdapter ara = new OleDbDataAdapter(cumle, bag);
            ara.Fill(tablo);

            bag.Close();
            dataGridView1.DataSource = tablo;
            
        }
    }
}
