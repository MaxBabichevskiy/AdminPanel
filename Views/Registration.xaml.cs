using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using WpfApp14.Model;
using System.Data.SqlClient;

namespace WpfApp14.Views
{
   
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private const string ConnectionString = "Data Source=MSI;Initial Catalog=Financial_Indicators;Integrated Security=True";

        public Registration()
        {
            InitializeComponent();
        }

        private void registr_btn_click(object sender, RoutedEventArgs e)
        {
            string login = txtUsername.Text;
            string password = txtPassword.Password;

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string query = "INSERT INTO Users (RolesId, Login, Password) VALUES (@RoleId, @Login, @Password)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@RoleId", 1);
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Логин и пароль успешно добавлены в базу данных.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при добавлении в базу данных: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.");
            }

        }

        private void back_btn_click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
