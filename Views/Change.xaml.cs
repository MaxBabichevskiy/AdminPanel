using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using WpfApp14.Model;

namespace WpfApp14.Views
{
    /// <summary>
    /// Логика взаимодействия для Change.xaml
    /// </summary>
    public partial class Change : Page
    {
        private const string ConnectionString = "Data Source=MSI;Initial Catalog=Financial_Indicators;Integrated Security=True";


        public Change()
        {
            InitializeComponent();
        }

        private void change_btn_click(object sender, RoutedEventArgs e)
        {
            string login = txtUsername.Text;
            string newPassword = txtPassword.Password;
            string newId = txtRole.Text;

           // int role = Convert.ToInt32(txtRole.Text);

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(newPassword))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Users SET Password = @NewPassword WHERE Login = @Login";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@Login", login);
                        int rowsAffected = command.ExecuteNonQuery();
                        AppData.db.SaveChanges();

                        

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пароль успешно обновлен.");
                        }
                        else
                        {
                            MessageBox.Show("Логин не найден в базе данных.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка при обновлении пароля: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите логин и новый пароль.");
            }

        }

        private void back_btn_click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
