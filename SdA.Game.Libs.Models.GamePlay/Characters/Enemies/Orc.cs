namespace SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

public class Orc : Enemy
{
    public Orc(string name) : base(string.Empty, new(0, 0))
    {
    }

    protected override void DoSeDeplacer()
    {

    }

    public override void Attaquer()
    {
        // base.Attaquer();
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        char c1 = '\u0010';
        return c1.ToString();
    }
}
