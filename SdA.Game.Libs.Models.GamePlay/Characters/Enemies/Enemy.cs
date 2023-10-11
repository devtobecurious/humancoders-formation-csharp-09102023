namespace SdA.Game.Libs.Models.GamePlay.Characters.Enemies;

/// <summary>
/// 
/// </summary>
public abstract class Enemy : Character // Non instanciable
{
    #region Constructors
    public Enemy(string name, Position2DR position) : base(position)
    {
        Name = name;
    }
    #endregion

    #region Public methods
    protected override abstract void DoSeDeplacer();

    public virtual void Attaquer()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "X";
    }
    #endregion

    #region Properties
    public string Name { get; init; }
    #endregion
}
