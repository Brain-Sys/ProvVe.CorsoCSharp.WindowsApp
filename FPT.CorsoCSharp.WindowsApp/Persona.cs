namespace FPT.CorsoCSharp.WindowsApp
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public Persona()
        {

        }

        public Persona(string nome)
        {
            this.Nome = nome;
        }
    }
}