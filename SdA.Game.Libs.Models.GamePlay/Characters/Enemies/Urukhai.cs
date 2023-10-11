namespace SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

public class Urukhai : Enemy
{
    public Urukhai(string name) : base(string.Empty, new(0, 0))
    {
    }

    protected override void DoSeDeplacer()
    {
        this.Position = new Position2DR(this.Position.X + 2, this.Position.Y + 2);
    }

    public override string ToString()
    {
        char c1 = '\u0008';
        return c1.ToString();
    }
}
