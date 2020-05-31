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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-T938JU3;Initial Catalog=depo_deneme1;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            string a, b;
            // TODO: Bu kod satırı 'depo_deneme1DataSet2.tablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tabloTableAdapter1.Fill(this.depo_deneme1DataSet2.tablo);
            // TODO: Bu kod satırı 'depo_deneme1DataSet.tablo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from dbo.tablo", baglan);
            
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                a = dr[2].ToString();
                b = dr[3].ToString();
                if (Convert.ToInt32(a)<= Convert.ToInt32(b))
                {
                    listBox1.Items.Add(dr[0] + "numaralı ürün azaldı.Sipariş verilmesi gerekiyor.");
                }
            }
            baglan.Close();

            

        }
    }
}
