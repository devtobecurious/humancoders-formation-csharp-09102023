namespace DiscoverEvents
{
    internal class Alarme
    {
        public event EventHandler AlarmeStart;

        public event EventHandler AlarmeArrete;

        public void Sonner(int duree = 1000)
        {
            this.AlarmeStart?.Invoke(this, new EventArgs());

            int i = 0;
            while (i++ < duree)
            {
                Console.WriteLine("Tiouu tiouuu tiouu");
                Thread.Sleep(100);
            }

            this.AlarmeArrete?.Invoke(this, new EventArgs());
        }
    }
}
