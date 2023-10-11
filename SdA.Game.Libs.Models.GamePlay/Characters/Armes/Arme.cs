namespace SdA.Game.Libs.Models.GamePlay.Characters.Armes
{
    public abstract class Arme
    {
        private const decimal Default = 1.1M;

        public int Id { get; set; }

        public string Nom { get; set; }

        public virtual decimal GetValeurCoup()
        {
            return Default;
        }
    }
}
