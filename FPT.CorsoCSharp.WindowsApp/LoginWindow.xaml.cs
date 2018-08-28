using FPT.CorsoCSharp.DomainModel;
using FPT.CorsoCSharp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

namespace FPT.CorsoCSharp.WindowsApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        // delegate int MyFunc(int i);
        Func<int, int> p1 = i => i * 10;
        Func<int, int, string> p2 = (n1, n2) => { return (n1 * n2).ToString(); };

        private Action todo = () =>
        {
            Console.WriteLine("123");
        };

        public LoginWindow()
        {
            InitializeComponent();
            var vm = this.DataContext as MainViewModel;
            vm = this.Resources["viewmodel"] as MainViewModel;
            vm.TakePhoto = () => {
                // Accende la fotocamera
            };
            vm.AskUser = accendi_microfono;
            todo();
            int risultato = p1(7);
            string stringa = p2(8, 4);
        }

        private string accendi_microfono()
        {
            return "";
        }

        private void removeEvents()
        {
            FatturaPagata fp = new FatturaPagata();
            var events = fp.GetType().GetEvents();

            foreach (EventInfo item in events)
            {
                // item.RemoveEventHandler(fp, null);
            }

            //PropertyInfo pi = fp.GetType().GetProperty("FatturaAppenaPagata",
            //    BindingFlags.NonPublic | BindingFlags.Instance);
            //EventHandlerList list = (EventHandlerList)pi.GetValue(b, null);
            //list.RemoveHandler(fp, list[fp]);

        }
    }
}
