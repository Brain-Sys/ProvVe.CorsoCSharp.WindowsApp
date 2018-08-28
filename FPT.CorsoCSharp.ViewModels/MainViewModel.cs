using System;

namespace FPT.CorsoCSharp.ViewModels
{
    // DLL --> .NET Standard
    // 
    public class MainViewModel
    {
        // Nessuna proprietà che dipende dal framework della UI

        public string Username { get; set; }
        public string Password { get; set; }

        // Delegate che tengono aperta la porta verso codice specifico
        // per una piattaforma / UI
        public Action TakePhoto { get; set; }
        public Func<string> AskUser { get; set; }

        // Far scattare una foto
        // Leggere un barcode
        // Input dalla voce
        // Ereditarietà

        public MainViewModel()
        {
            this.Username = "igor";
            this.Password = "pluto";
            // Database
            // COM
            // JSON
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