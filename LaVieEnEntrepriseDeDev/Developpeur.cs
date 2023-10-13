namespace LaVieEnEntrepriseDeDev
{
    internal class Developpeur
    {
        public event Action<string>? CodeACommencer;
        public event Action<Code, string>? CodeFini;

        private readonly CreateCodeAvecProcess creerCode;

        public Developpeur(CreateCodeAvecProcess creerCode)
        {
            this.creerCode = creerCode;
        }

        public Code EcrireCode()
        {
            this.CodeACommencer?.Invoke("Let's go");
            var code = this.creerCode();
            this.CodeFini?.Invoke(code, "Alors ça t'en bouche un coin de canard");

            return code;
        }
    }
}
