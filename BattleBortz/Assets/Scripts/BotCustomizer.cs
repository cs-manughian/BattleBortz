using UnityEngine;
using GameUtils;

public class BotCustomizer : MonoBehaviour
{
    WeaponType playerOneSelection;
    WeaponType playerTwoSelection;

    public void OnWeaponSelected(WeaponSelection selection)
    {
        if (selection.player == 1)
        {
            playerOneSelection = selection.weaponType;
        }
        else
        {
            playerTwoSelection = selection.weaponType;
        }
    }
}
