using FPT.CorsoCSharp.DomainModel;
using FPT.CorsoCSharp.DomainModel.CustomEventArgs;
using FPT.CorsoCSharp.DomainModel.CustomExceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Linq;
using System.Windows;
using System.Configuration;
using System.Windows.Controls;
using FPT.CorsoCSharp.Repository;
using System.Xml.Linq;

namespace FPT.CorsoCSharp.WindowsApp
{
    public partial class MainWindow : Window
    {
        // Action restituisce sempre void
        Action<int, DateTime, int?, int?> act2;
        Action<List<int>> act3;
        Action act;
        delegate void Metodo();

        Func<int> Random = () => { return 6; };
        Func<DateTime, int, List<bool>, string> act4;

        delegate string ElaboraByte(string raw);
        delegate int Aritmetica(int a, int b);
        FatturaPagata fp = new FatturaPagata();

        public MainWindow()
        {
            int x = Random();
            act = InitializeComponent;
            act2 = (int a, DateTime b, int? c, int? d) => { };

            string r = "_";

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                act4 = metodo;
            }
            else
            {
                act4 = metodo;
            }

            string str = act4(DateTime.Now, 9, new List<bool>() { true, false });

            ElaboraByte sequenza2 = step3;
            sequenza2 += step4;
            sequenza2 += step1;
            sequenza2 += step4;
            sequenza2 += step2;

            foreach (ElaboraByte item in sequenza2.GetInvocationList())
            {
                r = item.Invoke(r);
            }

            string finale = sequenza2("_");


            Metodo sequenza = new Metodo(m1) + m1 + m1;
            sequenza += m1;
            sequenza += m1;
            sequenza += m1;
            // sequenza = null;

            try
            {
                sequenza();
            }
            catch (Exception ex)
            {

            }

            sequenza = sequenza - m2;
            //sequenza();
            Delegate[] elenco = sequenza.GetInvocationList();

            // L'indirizzo di memoria del metodo chiamato InitializeComponent
            Metodo puntatore = InitializeComponent;
            Aritmetica somma = this.sommaDueNumeri;
            Aritmetica somma1 = new Aritmetica(sommaDueNumeri);
            int risultato1 = somma(8, 17);
            int risultato2 = sommaDueNumeri(8, 17, () => { });
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

            var bytes = new byte[3] { 5, 8, 10 };
            BitArray ba = new BitArray(bytes);

            List<double> pesiPersone = new List<double>();
            List<bool> statoAllarmi = new List<bool>();
            List<DateTime> compleanniAmici = new List<DateTime>();

            List<Fattura> fatture = new List<Fattura>()
            {
                new Fattura(),
                new Fattura(),
                new Fattura()
            };
            var date = fatture.DammiPagamenti();
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



            // calc3.Set(fp);

            // Anonymous Type
            var persona1 = new
            {
                Nome = "",
                Cognome = "",
                Eta = 42
            };

            // Object Initializer
            var persona2 = new Persona("Fabrizio")
            {
                Nome = "",
                Cognome = "",
                Eta = 42
            };

            //persona2.Nome = "";
            //persona2.Cognome = "";
            //persona2.Eta = 42;
            var pari = new List<int>() { 2, 4, 6, 8, 10 };

            int? annoNascita = 2018;
            annoNascita = null;
            annoNascita = 7;
            annoNascita++;
            annoNascita--;
            bool pari2 = annoNascita % 2 == 0;

            if (!annoNascita.HasValue)
            {
                // MsgBox
            }
            else
            {
                Console.WriteLine(annoNascita.Value);
            }
            int x5 = annoNascita.GetValueOrDefault();

            int? distanza1 = null;
            int? distanza2 = 1;
            int? totale = distanza1 + distanza2;

            // Mi registro l'evento FatturaAppenaPagata
            fp.FatturaAppenaPagata += fattura_FatturaAppenaPagata;

            // Non riesco a deregistrare l'evento perchè non ho un nome
            // da utilizzare con -=
            fp.FatturaAppenaPagata += (o, s) => { };

        }

        private void fattura_FatturaAppenaPagata(object sender, FatturaPagataEventArgs e)
        {
            MessageBox.Show(
                    $"La fattura {e.Fattura.Numero} è stata pagata alle ore {e.Timestamp.ToShortTimeString()}!"
                    );
        }

        private string metodo(DateTime p1, int p2, List<bool> p3)
        {
            return "---------------";
        }

        private int sommaDueNumeri(int a, int b)
        {
            return a + b;
        }

        private int sommaDueNumeri(int a, int b, Metodo quandoHaFinito)
        {
            int result = a + b;

            // Chiama il metodo di callback, se passato in input
            quandoHaFinito?.Invoke();

            return result;
        }

        private void btnExtMethod_Click(object sender, RoutedEventArgs e)
        {
            var codiceFiscale = "DMNLRG76B28I274H";
            var nuovaFattura = fp;


            // bool ok3 = ExtensionMethods.IsValid(codiceFiscale);
            var valid = codiceFiscale.IsValid();

            var ok1 = codiceFiscale.Maggiorenne();
            var ok2 = codiceFiscale.Maggiorenne("UK");
        }

        private void btnDownload_Click(object sender, RoutedEventArgs e)
        {
            WebClient client = new WebClient();
            // client.DownloadStringCompleted += ho_finito;
            // client.DownloadStringAsync(new Uri(""));
        }

        private void m1() { Debug.WriteLine("m1"); }
        private void m2()
        {
            throw new InvalidOperationException();
            Debug.WriteLine("m2");
        }
        private void m3() { Debug.WriteLine("m3"); }
        private void m4() { Debug.WriteLine("m4"); }

        private string step1(string input) { return input + "A"; }
        private string step2(string input) { return input + "B"; }
        private string step3(string input) { return input + "C"; }
        private string step4(string input) { return input + "D"; }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                fp.Paga();
            }
            catch (FPTException ex)
            {
                Debug.WriteLine(ex.B);
            }
            catch (FileNotFoundException ex)
            {

            }
            catch (Exception ex)
            {
                // Log
                MessageBox.Show("Oopss, qualcosa è andato storto!\r\n\r\n" + ex.Message);
            }
        }











        private void btnLinq_Click(object sender, RoutedEventArgs e)
        {
            // 2867
            IEnumerable<FileInfo> list = new DirectoryInfo
                (@"c:\windows\system32").GetFiles("*.*");

            // Where
            var soloDll1 = from f in list where filtroPerDll(f) select f;
            var soloDll2 = list.Where(filtroPerDll);

            // list.Count() > 0
            if (list != null && list.Any())
            {

            }

            var filtroDaConfig = list
                .Where(f => f.Extension == ConfigurationManager.AppSettings["Extension"])
                .ToList();

            // Ne esiste almeno uno che....è più grande di 50K?
            bool esiste50K = list.Any(f => f.Length > 50 * 1024);
            FileInfo file50K = list.FirstOrDefault(f => f.Length > 50000 * 1024);
            bool esistonoTutti = list
                .All(f => f.CreationTime.Year < 2015 && !f.IsReadOnly);

            var xyz = list
                //.Where(f => f.CreationTime.Year < 2015)
                //.Where(f => !f.IsReadOnly)
                .Where(f => f.Extension == ".exe")
                .Average(f => f.Length)
                .ToString() + " bytes";

            int soloNascosti1 = list
                .Count(f => f.Attributes == FileAttributes.Hidden);
            int soloNascosti2 = list
                .Where(f => f.Attributes == FileAttributes.Hidden)
                .Count();
            FileInfo fi = list.ElementAtOrDefault(50000);


            var fileOrdinati = list
                .Where(f => f.Name.Contains("p"))
                .ToList()
                .OrderBy(f => f.Name)
                .ThenBy(f => f.Length)
                .ThenByDescending(f => f.DirectoryName);
                




            int elementPerPage = 20;

            var primaPagina = list.Skip(40)
                .Take(elementPerPage)
                .ToList();

            var toolbar = list.TakeWhile(f => f.Extension != ".ini")
                .Select(f => new TemplateButton
                {
                    Etichetta = f.Name,
                    Colore = "Red",
                    Big = f.Length > 500000
                })
                .ToList();

            List<IGrouping<string, FileInfo>> raggruppati =
                list.GroupBy(f => f.Extension).ToList();

            foreach (IGrouping<string, FileInfo> item in raggruppati)
            {
                // Key contiene l'estensione
                string ext = item.Key;

                foreach (FileInfo file in item)
                {

                }
            }

            

            this.toolbar.ItemsSource = toolbar;

            if (file50K != null)
            {

            }

            foreach (var item in soloDll2)
            {

            }

            // Metodi di materializzazione (anche delle liste)
            // ToList()
            // FirstOrDefault()
            // First()
            // LastOrDefault()
            // Last()
            // SingleOrDefault()
            // Single()
            // Any()
        }

        private bool filtroPerDll(FileInfo f)
        {
            Debug.WriteLine(DateTime.Now.Ticks);
            return f.Extension == ".dll";
        }

        private void btnDatabase_Click(object sender, RoutedEventArgs e)
        {
            var ctx = new Repository.DB_StationServiceEntities();
            ctx.Database.Log = (s) => { Debug.WriteLine(s); };
            var tabella = ctx.TIPI_CARBURANTI
                .Where(c => c.Price > 0.0)
                .OrderByDescending(c => c.Name)
                //.Select(o => Mapper.Map<TIPI_CARBURANTI, TCDto>(o))
                .ToList()
                .All(o => o.Liters != 0);


            XDocument doc = XDocument.Load("http://192.168.50.116:9056/GetAlarms?format=xml");
            var ricerca = from n in doc.DescendantNodes()
                          where ((XElement)n).Name == "img"
                          select n;
        }
    }

    internal class TemplateButton
    {
        public string Etichetta { get; set; }
        public string Colore { get; set; }
        public bool Big { get; set; }
    }
}