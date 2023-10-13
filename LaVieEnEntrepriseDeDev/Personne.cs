namespace LaVieEnEntrepriseDeDev
{
    internal class Personne
    {
        private TimeOnly dateDebut = new TimeOnly();
        private TimeOnly dateFin = new TimeOnly();
        public Role Role { get; private set; }


        public void DemarrerCompteur(string message)
        {
            this.dateDebut = TimeOnly.FromDateTime(DateTime.Now);
        }

        public void ArreterCompteur(Code code, string message)
        {
            this.dateFin = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine($"Début : {this.dateDebut} / Fin : {this.dateFin}, durée : {this.dateFin - this.dateDebut}");
        }
    }
}
