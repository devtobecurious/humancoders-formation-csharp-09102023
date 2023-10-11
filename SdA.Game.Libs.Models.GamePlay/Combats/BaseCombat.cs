using SdA.Game.Libs.Models.GamePlay.Characters;

namespace SdA.Game.Libs.Models.GamePlay.Combats;

/// <summary>
/// classe non instanciable donnant le contrat pour tous les combats
/// </summary>
public abstract class BaseCombat
{
    #region Constructors
    public BaseCombat(Character character1, Character character2)
    {
        this.Character1 = character1;
        this.Character2 = character2;
    }
    #endregion

    #region Public methods
    public CombatResult? Fight()
    {
        CombatResult? result = null;
        bool isSuccess = false;

        if (this.Character1 == null || this.Character2 == null)
        {
            throw new ArgumentNullException($"{nameof(this.Character1)} / {nameof(this.Character2)}");
        }

        DateTime dateDebut = DateTime.Now;
        isSuccess = this.DoFight();
        result = new CombatResult(isSuccess, dateDebut, DateTime.Now);

        return result;
    }
    #endregion

    #region Internal methods
    /// <summary>
    /// Définit le comportement du combat
    /// </summary>
    protected abstract bool DoFight();
    #endregion

    #region Properties
    public Character Character1 { get; init; }
    public Character Character2 { get; init; }
    #endregion
}
