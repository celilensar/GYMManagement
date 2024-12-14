
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace GYMProject
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Kullan�c� ad� ve �ifreyi al�n
            string username = userNameTextBox.Text;  // Kullan�c� ad� textBox'�
            string password = passwordTextBox.Text;  // �ifre textBox'�

            // Veritaban� ba�lant� dizesi (De�i�tirin: sunucu, veritaban� ad� vb.)
            string connectionString = "Data Source=DESKTOP-FAT5F5N\\SQLEXPRESS01;Initial Catalog=GYMNEW;Integrated Security=True;Encrypt=False";

            // SQL sorgusu
            string query = "SELECT COUNT(1) FROM UserAuth WHERE Username = @username AND Password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Ba�lant�y� a�
                    conn.Open();

                    // SQL komutunu olu�tur
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password); // �ifrenin g�venli�i i�in hashing �nerilir

                    // Sonucu kontrol et
                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    // Giri� ba�ar�l�ysa
                    if (result > 0)
                    {
                        MessageBox.Show("Giri� ba�ar�l�!");

                        // AnaEkranAdmin formuna y�nlendir
                        AnaEkranAdmin adminForm = new AnaEkranAdmin();
                        adminForm.Show();
                        this.Hide();  // Giri� ekran�n� gizle
                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata olu�tu: " + ex.Message);
                }
            }
        }
    }
}
