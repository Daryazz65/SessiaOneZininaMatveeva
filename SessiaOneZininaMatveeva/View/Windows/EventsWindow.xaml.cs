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
    /// Логика взаимодействия для EventsWindow.xaml
    /// </summary>
    public partial class EventsWindow : Window
    {
        private static SessiaOneZininaMatveevaEntities _context = App.GetContext();
        List<Direction> directions = _context.Directions.ToList();
        List<Event> events = _context.Events.ToList();
        private Organizer.Organizer _selectedUser;
        public EventsWindow()
        {
            InitializeComponent();
            EventsLb.ItemsSource = _context.Events.ToList();
            directions.Insert(0, new Direction() { Name = "Все направления" });
            DirectionCmb.ItemsSource = directions;
            DirectionCmb.DisplayMemberPath = "Name";
            ProfileTbl.Visibility = Visibility.Collapsed;
            SignInTbl.Visibility = Visibility.Visible;
            NewEventBtn.Visibility = Visibility.Collapsed;
        }

        public EventsWindow(Organizer.Organizer selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
            EventsLb.ItemsSource = _context.Events.ToList();
            directions.Insert(0, new Direction() { Name = "Все направления" });
            DirectionCmb.ItemsSource = directions;
            DirectionCmb.DisplayMemberPath = "Name";
            ProfileTbl.Visibility = Visibility.Visible;
            SignInTbl.Visibility = Visibility.Collapsed;
            ProfileTbl.Text = AuthoriseHelper.selectedOrganizer.Name;
            NewEventBtn.Visibility = Visibility.Visible;
        }

        private void DirectionCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            events = _context.Events.ToList();
            if (DirectionCmb.SelectedIndex == 0)
            {
                events = _context.Events.ToList();
                EventsLb.ItemsSource = events;
            }
            else
            {
                events = events.Where(ev => ev.Direction == DirectionCmb.SelectedItem as Direction).ToList();
                EventsLb.ItemsSource = events;
            }
        }

        private void SignInHL_Click(object sender, RoutedEventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Show();
            Close();
        }

        private void EventsLb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EventInfoWindow eventInfoWIndow = new EventInfoWindow(EventsLb.SelectedItem as Event);
            eventInfoWIndow.ShowDialog();
        }

        private void ProfileHl_Click(object sender, RoutedEventArgs e)
        {
            Organizer.Organizer organizerWindow = new Organizer.Organizer(_selectedUser);
            organizerWindow.Show();
            Close();
        }

        private void NewEventBtn_Click(object sender, RoutedEventArgs e)
        {
            NewEventWindow newEventWindow = new NewEventWindow(_selectedUser);
            if (newEventWindow.ShowDialog() == true)
            {
                EventsLb.ItemsSource = App.GetContext().Events.ToList();
            }

        }
    }
}