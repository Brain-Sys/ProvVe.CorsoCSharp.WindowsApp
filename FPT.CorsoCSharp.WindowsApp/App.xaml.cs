using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FPT.CorsoCSharp.WindowsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Messenger.Default.Register<string>(this, openView);
            AppDomain.CurrentDomain.UnhandledException +=
                CurrentDomain_UnhandledException;

            AppDomain.CurrentDomain.FirstChanceException += (o, s) =>
            {
                // LOG
                // Binding WPF
            };

            Application.Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            object obj = e.ExceptionObject;
        }

        private void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
        }

        // Qui arriva un messaggio da qualsiasi viewmodel
        private void openView(string viewName)
        {
            Type type = Type.GetType("FPT.CorsoCSharp.WindowsApp." + viewName);

            if (type != null)
            {
                Window obj = Activator.CreateInstance(type) as Window;
                var vm = obj.Resources["viewmodel"] as ViewModelBase;
                vm?.Cleanup();
                obj.ShowDialog();
            }
        }
    }
}