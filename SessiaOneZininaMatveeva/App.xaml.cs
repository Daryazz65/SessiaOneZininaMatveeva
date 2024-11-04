using SessiaOneZininaMatveeva.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SessiaOneZininaMatveeva
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static SessiaOneZininaMatveevaEntities context;
        public static SessiaOneZininaMatveevaEntities GetContext()
        {
            if (context == null)
            {
                context = new SessiaOneZininaMatveevaEntities();
            }
            return context;
        }
    }
}