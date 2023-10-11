namespace SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

public class Goblin : Enemy
{
    public Goblin() : base(string.Empty, new(0, 0))
    {
    }

    protected override void DoSeDeplacer()
    {
        this.Position = new Position2DR(this.Position.X + 4, this.Position.Y + 4);
    }

    public override string ToString()
    {
        char c1 = '\u0011';
        return c1.ToString();
    }
}
