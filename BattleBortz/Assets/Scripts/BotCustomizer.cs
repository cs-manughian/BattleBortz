using UnityEngine;
using GameUtils;

public class BotCustomizer : MonoBehaviour
{
    WeaponType _playerOneSelection = WeaponType.NONE;
    WeaponType _playerTwoSelection = WeaponType.NONE;

    public void OnWeaponSelected(WeaponSelection selection)
    {
        if (selection.player == 1)
        {
            _playerOneSelection = selection.weaponType;
        }
        else
        {
            _playerTwoSelection = selection.weaponType;
        }
    }

    public bool IsPlayerSelectionComplete()
    {
        return _playerOneSelection != WeaponType.NONE &&
               _playerTwoSelection != WeaponType.NONE;
    }
}
