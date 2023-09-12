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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для PageAuto.xaml
    /// </summary>
    public partial class PageAuto : Page
    {
        public PageAuto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int p = PBPass.Password.GetHashCode(); // хэшируем введенный пользователем пароль
            // находим в таблицу User пользователя, у которого совпадают логин и пароль с введенными данными
            User userNow = Base.dataBase.User.FirstOrDefault(x => x.Login == TBLogin.Text && x.Password == p);
            if (userNow != null) // если пользоватлеь найден
            {
                switch(userNow.Role) // в зависимости от того, какая у пользователя роль
                {
                    case 1:
                        MessageBox.Show("Здравствуйте, администратор");
                        break;
                    case 2:
                        MessageBox.Show("Здравствуйте, пользоватлель");
                        break;
                    default:
                        MessageBox.Show("Пользователь не найден");
                        break;
                }
            }
            else // если пользователь не найден
            {
                MessageBox.Show("Пользователь не найден");
            }
        }
    }
}
