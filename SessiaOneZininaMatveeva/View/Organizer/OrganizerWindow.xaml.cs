using SessiaOneZininaMatveeva.View.Windows;
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
using SessiaOneZininaMatveeva.Model;
using System.Windows.Shapes;

namespace SessiaOneZininaMatveeva.View.Organizer
{
    /// <summary>
    /// Логика взаимодействия для OrganizerWindow.xaml
    /// </summary>
    public partial class Organizer : Window
    {
        private Organizer _selectedUser;
        public Organizer(Organizer selectedUser)
        {
            InitializeComponent();
            UserGrid.DataContext = selectedUser;
            _selectedUser = selectedUser;
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            ProfileWIndow profileWindow = new ProfileWIndow(_selectedUser);
            profileWindow.ShowDialog();
        }

        private void EventsBtn_Click(object sender, RoutedEventArgs e)
        {
            EventsWindow eventsWindow = new EventsWindow(_selectedUser);
            eventsWindow.Show();
            Close();
        }

        private void ParticipantsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JuryBtn_Click(object sender, RoutedEventArgs e)
        {

        }
      }
}