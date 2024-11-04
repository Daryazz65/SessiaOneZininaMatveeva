using SessiaOneZininaMatveeva.AppData;
using SessiaOneZininaMatveeva.Model;
using SessiaOneZininaMatveeva.View.Organizer;
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
using System.Windows.Shapes;
using static SessiaOneZininaMatveeva.AppData.ClassHelper;

namespace SessiaOneZininaMatveeva.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        private static SessiaOneZininaMatveevaEntities _context = App.GetContext();
        public StartWindow()
        {
            List<string> roles = new List<string> { "Организатор", "Модератор", "Жюри", "Участник" };
            InitializeComponent();
            ViborRoleCmb.ItemsSource = roles;
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthoriseHelper.Authorise(LoginTb.Text, PasswordTb.Password, ViborRoleCmb.SelectedItem as string))
            {
                CaptchaWindow cAPTCHAWindow = new CaptchaWindow();
                if (cAPTCHAWindow.ShowDialog() == true)
                {
                    if (ViborRoleCmb.SelectedIndex == 0)
                    {
                        Organizer.Organizer organizerWindow = new Organizer.Organizer(ClassHelper.selectedOrganizer);
                        organizerWindow.Show();
                        Close();
                    }
                }

            }
        }

        private void SignUpHl_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EnterHl_Click(object sender, RoutedEventArgs e)
        {
            EventsWindow eventsWindow = new EventsWindow();
            eventsWindow.Show();
            Close();
        }

        private void SignHl_Click(object sender, RoutedEventArgs e)
        {
            SignWindow signUpWindow = new SignWindow();
            signUpWindow.Show();
            Close();
        }
    }
}