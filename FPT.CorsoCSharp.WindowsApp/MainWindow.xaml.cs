using FPT.CorsoCSharp.DomainModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Net.Http;
// using System.Linq;
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

namespace FPT.CorsoCSharp.WindowsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ArrayList list = new ArrayList(20);
            list.Add(67);
            list.Add(true);
            list.Add(DateTime.Now);
            list.Add(89.45345);
            list.IndexOf(89.45345);
            // Perdita di performance a run-time
            // int number = (int)list[1];

            // Boxing & Unboxing
            DateTime dt = (DateTime)list[2];
            StringCollection list1 = new StringCollection();
            list1.Add("mdlkgnkldngkdffnkj");
            list1.Add("mdlkgnkldngkdffnkj");
            list1.Add("mdlkgnkldngkdffnkj");
            list1.Add("mdlkgnkldngkdffnkj");
            // list1.Add(34);
            BitArray ba = new BitArray(new byte[] { 5, 8, 10 });

            List<double> pesiPersone = new List<double>();
            List<bool> statoAllarmi = new List<bool>();
            List<DateTime> compleanniAmici;
            List<Fattura> fatture = new List<Fattura>();
            fatture.Add(new Fattura());

            pesiPersone.Contains(78);
            statoAllarmi.Add(true);
            // Compile time
            //double pesoIgor = pesiPersone[0];
            int index = pesiPersone.IndexOf(89.3);

            Stack stack1 = new Stack();
            stack1.Push(4);
            stack1.Push("");
            string pop = stack1.Pop().ToString();
            Stack<string> stack2;
            Queue<Fattura> coda;

            ObservableCollection<Fattura> list3 = new ObservableCollection<Fattura>();
            //list3.AddRange();
            Dictionary<string, Fattura> tim = new Dictionary<string, Fattura>();
            // Fattura f1 = tim["5u4564545/2018"];

            // Calcolatrice<bool> calc = new Calcolatrice<bool>();
            //Calcolatrice<HttpClient> calc2 = new Calcolatrice<HttpClient>();
            Calcolatrice<Fattura> calc3 = new Calcolatrice<Fattura>();
            //Calcolatrice<Cliente> calc4;
            // Calcolatrice<BitArray> calc4 = new Calcolatrice<BitArray>();


            FatturaPagata fp = new FatturaPagata();
            calc3.Set(fp);
        }
    }
}