using UnityEngine;
using GameUtils;

public class BotCustomizer : MonoBehaviour
{
    WeaponType playerOneSelection;
    WeaponType playerTwoSelection;

    public void OnWeaponSelected(WeaponSelection selection)
    {
        Debug.Log(selection.player);
        Debug.Log(selection.weaponType);
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
