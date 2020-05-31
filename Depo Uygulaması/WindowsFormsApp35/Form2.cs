using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp35
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-T938JU3;Initial Catalog=depo_deneme1;Integrated Security=True");
        int id = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'depo_deneme1DataSet1.tablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tabloTableAdapter.Fill(this.depo_deneme1DataSet1.tablo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into dbo.tablo(deponum,urunaciklama,depoadedi,siniradet) values (@p1,@p2,@p3,@p4)",baglan);
            komut.Parameters.AddWithValue("@p1",txturunkod.Text);
            komut.Parameters.AddWithValue("@p2", txturunaciklama.Text);
            komut.Parameters.AddWithValue("@p3", txtdepoadedi.Text);
            komut.Parameters.AddWithValue("@p4", txtsiniradedi.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("kayıt eklendi");
            this.tabloTableAdapter.Fill(this.depo_deneme1DataSet1.tablo);


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txturunkod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txturunaciklama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdepoadedi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsiniradedi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnoncekiekran_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
