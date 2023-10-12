namespace LaVieEnEntrepriseDeDev
{
    internal class Developpeur
    {
        private readonly CreateCodeAvecProcess creerCode;

        public Developpeur(CreateCodeAvecProcess creerCode)
        {
            this.creerCode = creerCode;
        }

        public Code EcrireCode()
        {
            var code = this.creerCode();

            return code;
        }
    }
}
