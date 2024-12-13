﻿using System;
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
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void lastNameLabel_Click(object sender, EventArgs e)
        {


        }

        private void genderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş alan kontrolü
                if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                    genderComboBox.SelectedItem == null ||
                    ageCounter.Value <= 0 ||
                    string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) ||
                    string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                    roleComboBox.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                    membershipTypeComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal membershipPrice = 0;

                // MembershipType'a göre fiyat belirleme
                switch (membershipTypeComboBox.SelectedItem.ToString())
                {
                    case "Month":
                        membershipPrice = 1000; // 1 aylık fiyat
                        break;

                    case "Year":
                        membershipPrice = 9000; // 1 yıllık fiyat
                        break;

                    default:
                        MessageBox.Show("Geçerli bir üyelik türü seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                }

                // Veritabanı bağlantısı
                string connectionString = "Data Source=EMREEROGLU\\SQLEXPRESS;Initial Catalog=GymDB;Integrated Security=True;Encrypt=False"; // Bağlantı dizesini buraya ekleyin.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Member tablosuna veri ekleme
                    string insertMemberQuery = @"
                INSERT INTO Member (FirstName, LastName, Gender, Age, PhoneNumber, Email, Address)
                OUTPUT INSERTED.MemberID
                VALUES (@FirstName, @LastName, @Gender, @Age, @PhoneNumber, @Email, @Address)";

                    using (SqlCommand command = new SqlCommand(insertMemberQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                        command.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                        command.Parameters.AddWithValue("@Gender", genderComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Age", ageCounter.Value);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                        command.Parameters.AddWithValue("@Email", emailTextBox.Text);
                        command.Parameters.AddWithValue("@Address", addressTextBox.Text);

                        int memberId = (int)command.ExecuteScalar(); // MemberID'yi al

                        // Membership tablosuna veri ekleme
                        string insertMembershipQuery = @"
                    INSERT INTO Membership (MemberID, MembershipType, Price)
                    VALUES (@MemberID, @MembershipType, @Price)";

                        using (SqlCommand membershipCommand = new SqlCommand(insertMembershipQuery, connection))
                        {
                            membershipCommand.Parameters.AddWithValue("@MemberID", memberId);
                            membershipCommand.Parameters.AddWithValue("@MembershipType", membershipTypeComboBox.SelectedItem.ToString());
                            membershipCommand.Parameters.AddWithValue("@Price", membershipPrice);

                            membershipCommand.ExecuteNonQuery(); // Membership verisi ekle
                        }

                        // userAuth tablosuna veri ekleme (kullanıcı adı ve şifre)
                        string username = $"{firstNameTextBox.Text.ToLower()}_{lastNameTextBox.Text.ToLower()}_{memberId}";
                        string password = username; // Şifreyi kullanıcı adına eşit yapıyoruz, ihtiyaç duyarsanız farklı bir şifreleme metodu kullanabilirsiniz.

                        string insertAuthQuery = @"
                    INSERT INTO userAuth (Username, Password, MemberID)
                    VALUES (@Username, @Password, @MemberID)";

                        using (SqlCommand authCommand = new SqlCommand(insertAuthQuery, connection))
                        {
                            authCommand.Parameters.AddWithValue("@Username", username);
                            authCommand.Parameters.AddWithValue("@Password", password);
                            authCommand.Parameters.AddWithValue("@MemberID", memberId);

                            authCommand.ExecuteNonQuery(); // userAuth verisi ekle
                        }

                        // Payment formunu oluşturun ve MemberID'yi geçirin
                        Payment paymentForm = new Payment(memberId, membershipPrice);
                        paymentForm.MembershipAmount = membershipPrice; // Fiyatı aktar
                        paymentForm.Show();
                        this.Hide(); // NewMember formunu gizle
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
