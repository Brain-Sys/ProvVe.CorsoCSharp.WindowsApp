using FPT.CorsoCSharp.DomainModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace FPT.CorsoCSharp.ViewModels
{
    // DLL --> .NET Standard
    // 
    public class MainViewModel : ViewModelBase
    {
        HttpClient client = new HttpClient();
        private Timer timer;

        // Nessuna proprietà che dipende dal framework della UI

        public bool IsBusy { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private ObservableCollection<Fattura> invoices;
        public ObservableCollection<Fattura> Invoices
        {
            get { return invoices; }
            set { invoices = value;
                base.RaisePropertyChanged();
            }
        }

        private List<int> numbers;
        public List<int> Numbers
        {
            get { return numbers; }
            set { numbers = value;
                base.RaisePropertyChanged();
            }
        }

        // Delegate che tengono aperta la porta verso codice specifico
        // per una piattaforma / UI
        public Action TakePhoto { get; set; }
        public Func<string> AskUser { get; set; }

        // Comandi esposti dal viewmodel
        public RelayCommand LoginCommand { get; set; }
        public RelayCommand<int> DeleteCommand { get; set; }
        public RelayCommand<Fattura> PayInvoiceCommand { get; set; }

        // Far scattare una foto
        // Leggere un barcode
        // Input dalla voce
        // Ereditarietà

        public MainViewModel()
        {
            timer = new Timer(new TimerCallback((o) =>
            {
                int x = 1;
                int idTh = Thread.CurrentThread.ManagedThreadId;

                this.Numbers[0] = 90;
                this.Numbers.Add(x++);
                this.Numbers = this.Numbers;
                this.Invoices.Add(new Fattura() { Numero = x.ToString() });

                base.RaisePropertyChanged();
                base.RaisePropertyChanged(() => this.Numbers);
                base.RaisePropertyChanged(nameof(Numbers));
                base.RaisePropertyChanged(nameof(Invoices));
            }), null, Timeout.Infinite, Timeout.Infinite);

            this.Username = "igor";

            if (base.IsInDesignMode)
            {
                this.Password = "pluto";
            }
            else
            {
                this.Password = "letta davvero dal file";
            }
            // Database
            // COM
            // JSON
            this.LoginCommand = new RelayCommand
                (loginCommandExecute, loginCommandCanExecute);
            this.DeleteCommand = new RelayCommand<int>(deleteCommandExecute);
            this.PayInvoiceCommand = new RelayCommand<Fattura>((f) =>
            {
                f.Pagata = !f.Pagata;
            });

            this.Numbers = new List<int>() { 1, 6, 10, 87, 42 };
            this.Invoices = new ObservableCollection<Fattura>()
            {
                new Fattura() { Numero = "1"},
                new Fattura() { Numero = "2", Pagata = true },
                new Fattura() { Numero = "3"},
                new Fattura() { Numero = "4"},
            };

            // await this.loginCommandExecute();
            init();
        }

        private void init()
        {
            this.IsBusy = true;
            //string html = await client.GetStringAsync("http://blog.vivendobyte.net");
            //byte[] bytes = await client.GetByteArrayAsync("http://www.vivendobyte.net");

            Task<string> t1 = client.GetStringAsync("http://blog.vivendobyte.net");
            Task<byte[]> t2 = client.GetByteArrayAsync("http://www.repubblico.it");
            Task<byte[]> t3 = new Task<byte[]>(() => {
                t2.RunSynchronously();
                throw new InvalidOperationException();
            }, TaskCreationOptions.AttachedToParent);

            Task t4 = new Task(() =>
                Task.Factory.StartNew(() => {
                    Task.Factory.StartNew(() => {
                        Task.Factory.StartNew(() => {
                            throw new InvalidOperationException();   
                        },
                            TaskCreationOptions.AttachedToParent);

                        throw new FormatException("xyz");

                    }, TaskCreationOptions.AttachedToParent);
                }, TaskCreationOptions.AttachedToParent));

            try
            {
                t4.Start();
                Task.WaitAll(t4);
                // int x = Task.WaitAny(t1, t2);
            }
            catch (AggregateException exc)
            {
                AggregateException eccezioni = exc.Flatten();

                foreach (Exception item in eccezioni.InnerExceptions)
                {
                    Debug.WriteLine(item.Message);
                }
            }

            this.IsBusy = false;
        }

        private void deleteCommandExecute(int obj)
        {
            this.Numbers.Remove(obj);
        }

        private bool loginCommandCanExecute()
        {
            if (string.IsNullOrEmpty(this.Username) || string.IsNullOrEmpty(this.Password))
                return false;

            return true;
        }

        // Ciò che deve fare il comando Login invocato dalla UI
        private async void loginCommandExecute()
        {
            await Task.Factory.StartNew<List<string>>(() =>
            {
                return new List<string>() { "a", "b", "c" };
            });

            await Task.Run(async () => {
                var dir = new DirectoryInfo(@"C:\Windows\System32");
                var files = dir.GetFiles("*.*").OrderByDescending(f => f.Length);

                foreach (var item in files)
                {
                    Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));
                    await FileIO.CopyAsync(item.FullName, "X:\\File.tmp");
                    Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));
                    
                    File.Copy(item.FullName, "E:\\File.tmp", true);
                    Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));
                }

            });
        }

        private void test()
        {
            this.TakePhoto?.Invoke();
            string phrase = this.AskUser?.Invoke();

            switch (phrase)
            {
                case "avvia la pressa":
                    {
                        break;
                    }
            }
        }
    }
}