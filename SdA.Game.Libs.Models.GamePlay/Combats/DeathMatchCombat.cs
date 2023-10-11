using SdA.Game.Libs.Models.GamePlay.Characters;

namespace SdA.Game.Libs.Models.GamePlay.Combats;

public class DeathMatchCombat : BaseCombat
{
    #region Constructors
    public DeathMatchCombat(Character character1, Character character2) : base(character1, character2)
    {
    }
    #endregion

    #region Internal methods
    protected override bool DoFight()
    {
        bool isSuccess = false;
        // le death match va être ici

        do
        {
            this.Character1.Attaquer(this.Character2);
            this.Character2.Attaquer(this.Character1);
        } while (this.Character1.EstEnVie && this.Character2.EstEnVie);

        isSuccess = true;

        return isSuccess;
    }
    #endregion
}
