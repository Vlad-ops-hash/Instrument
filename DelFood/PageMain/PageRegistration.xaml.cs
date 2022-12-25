using DelFood.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using DelFood.PageMain;

namespace DelFood.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, RoutedEventArgs e)
        {
            if (ODBConnectionHelper.entObj.User.Count(x => x.Login == TxbLogin.Text) < 1)
            {
                if (PsbPassword.Password == TxbPassword.Text)
                {
                    DataBase.User user = new DataBase.User
                    {
                        Login = TxbLogin.Text,
                        Password = TxbPassword.Text,
                        IdRole = 1
                    };
                    ODBConnectionHelper.entObj.User.Add(user);
                    ODBConnectionHelper.entObj.SaveChanges();
                    FrameApp.frmObj.GoBack();
                    MessageBox.Show("Урааа, вы создали аккаунт");
                }
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует!");
            }
        }

        private void txtpassans_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (PsbPassword.Password == TxbPassword.Text)
            {
                BtnCreate.IsEnabled = true;
                TxbPassword.Background = Brushes.LightGreen;
                TxbPassword.BorderBrush = Brushes.Green;

            }
            else
            {
                BtnCreate.IsEnabled = false;
                TxbPassword.Background = Brushes.LightCoral;
                TxbPassword.BorderBrush = Brushes.Red;

            }

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PsbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCreate_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
