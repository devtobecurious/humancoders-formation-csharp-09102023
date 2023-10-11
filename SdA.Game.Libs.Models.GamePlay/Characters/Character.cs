using SdA.Game.Libs.Models.GamePlay.Characters.Armes;

namespace SdA.Game.Libs.Models.GamePlay.Characters;

/// <summary>
/// Classe parent des ennemies et du player
/// </summary>
public abstract class Character
{
    #region Fields
    private static Random random = new Random();
    #endregion

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
    public virtual void Attaquer(Character enemy)
    {
        int coup = random.Next(0, this.PointsAttaque + 1);
        coup = (int)(coup * this.ArmePrincipale.GetValeurCoup());
        enemy.PointsDeVie = new PointsDeVie(enemy.PointsDeVie.Value - coup, enemy.PointsDeVie.Min, enemy.PointsDeVie.Max);
    }

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

    public PointsDeVie PointsDeVie { get; private set; } = new(100, 0, 100);


    public virtual int PointsAttaque { get; protected set; } = 10;


    public bool EstEnVie => this.PointsDeVie.Value > 0;

    public Arme ArmePrincipale { get; set; } = new Arbalete();
    #endregion
}
