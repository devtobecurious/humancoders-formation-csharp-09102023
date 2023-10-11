namespace SdA.Game.Libs.Models.GamePlay.Characters;

/// <summary>
/// Classe parent des ennemies et du player
/// </summary>
public abstract class Character
{
    #region Constructors
    public Character(Position2DR positionParDefaut)
    {
        this.Position = positionParDefaut;
    }

    public Character(int x, int y) : this(new(x, y))
    {

    }

    public Character() : this(new(0, 0))
    {

    }
    #endregion

    #region Public methods
    /// <summary>
    /// Déplacement par défaut
    /// </summary>
    /// <param name="position"></param>
    public void SeDeplacer(Position2DR position)
    {
        if (position == null) return; // lui préférer un throw 

        this.Position = position;

        this.DoSeDeplacer();
    }
    #endregion

    #region Internal methods
    /// <summary>
    /// 
    /// </summary>
    protected abstract void DoSeDeplacer();
    #endregion

    #region Properties
    public Position2DR Position { get; protected set; }
    #endregion
}
