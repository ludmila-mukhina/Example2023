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
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
            List<UserRole> US = Base.dataBase.UserRole.ToList();
            CBRole.ItemsSource = US;
            CBRole.SelectedValuePath = "id";
            CBRole.DisplayMemberPath = "Role";            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User()
            {

                Name = TBName.Text,
                Surname = TBSurname.Text,
                DateBirthday = Convert.ToDateTime(DPdate.SelectedDate),
                Role = ((UserRole)CBRole.SelectedItem).id, // определяем роль
                Login = TBLogin.Text,
                Password = PBPass.Password.GetHashCode()
            };
            Base.dataBase.User.Add(newUser);
            Base.dataBase.SaveChanges();
            MessageBox.Show("Пользователь добавлен");
        }
    }
}
