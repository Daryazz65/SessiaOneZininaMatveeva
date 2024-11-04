﻿using SessiaOneZininaMatveeva.AppData;
using SessiaOneZininaMatveeva.View.Organizer;
using SessiaOneZininaMatveeva.Model;
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

namespace SessiaOneZininaMatveeva.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProfileWIndow.xaml
    /// </summary>
    public partial class ProfileWIndow : Window
    {
        Organizer.Organizer _selectedUser;
        string password = string.Empty;
        string newPassword = string.Empty;
        private static SessiaOneZininaMatveevaEntities _context = App.GetContext();
        public ProfileWIndow(Organizer.Organizer selectedUser)
        {
            InitializeComponent();
            _selectedUser = selectedUser;
            ProfileGrid.DataContext = selectedUser;
            PasswordGrid.Visibility = Visibility.Hidden;

            IsVisibleCb.IsChecked = true;
            PasswordPb.Visibility = Visibility.Hidden;
            NewPasswordPb.Visibility = Visibility.Hidden;
        }

        private void IsVisibleCb_Checked(object sender, RoutedEventArgs e)
        {
            password = PasswordPb.Password;
            newPassword = NewPasswordPb.Password;
            PasswordPb.Visibility = Visibility.Hidden;
            NewPasswordPb.Visibility = Visibility.Hidden;

            PasswordTb.Text = password;
            NewPasswordTb.Text = newPassword;
            PasswordTb.Visibility = Visibility.Visible;
            NewPasswordTb.Visibility = Visibility.Visible;
        }
        private void IsVisibleCb_Unchecked(object sender, RoutedEventArgs e)
        {
            password = PasswordTb.Text;
            newPassword = NewPasswordTb.Text;
            PasswordTb.Visibility = Visibility.Hidden;
            NewPasswordTb.Visibility = Visibility.Hidden;

            PasswordPb.Password = password;
            NewPasswordPb.Password = newPassword;
            PasswordPb.Visibility = Visibility.Visible;
            NewPasswordPb.Visibility = Visibility.Visible;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsVisibleCb.IsChecked == true)
            {
                if (PasswordTb.Text != string.Empty && NewPasswordTb.Text != string.Empty)
                {
                    if (PasswordTb.Text == NewPasswordTb.Text)
                    {
                        //_selectedUser.Password = PasswordTb.Text;
                        _context.SaveChanges();
                        ClassMessageBox.Information("Пароль успешно сменен.");
                        Close();
                    }
                    else
                    {
                        ClassMessageBox.Error("Пароли не совпадают.");
                    }
                }
                else
                {
                    ClassMessageBox.Error("Заполните все поля для ввода.");
                }
            }
            else
            {
                if (PasswordPb.Password != string.Empty && NewPasswordPb.Password != string.Empty)
                {
                    if (PasswordPb.Password == NewPasswordPb.Password)
                    {
                        //_selectedUser.Password = PasswordPb.Password;
                        _context.SaveChanges();
                        ClassMessageBox.Information("Пароль успешно сменен.");
                        Close();
                    }
                    else
                    {
                        ClassMessageBox.Error("Пароли не совпадают.");
                    }
                }
                else
                {
                    ClassMessageBox.Error("Заполните все поля для ввода.");
                }
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ChangePasswordCb_Checked(object sender, RoutedEventArgs e)
        {
            PasswordGrid.Visibility = Visibility.Visible;
        }

        private void ChangePasswordCb_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordGrid.Visibility = Visibility.Hidden;
        }


    }
}