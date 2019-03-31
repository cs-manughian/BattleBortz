using UnityEngine;
using UnityEngine.UI;
using GameUtils;

// This goes on choose container
public class WeaponSelector : MonoBehaviour
{
    BotCustomizer customizer;

    void Start()
    {
        customizer = GameObject.Find("BotCustomizer").GetComponent<BotCustomizer>();

        // Get all buttons
        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            // Apply SelectWeapon as the on click event
            button.onClick.AddListener(() => SelectWeapon(button));
        }
    }

    // On Click for Weapon Button Object
    void SelectWeapon(Button button)
    {
        // TODO:
        // This is actually the script. We need to rename the script on refactor
        WeaponButton weaponBtn = button.GetComponent<WeaponButton>(); 

        WeaponSelection selection;
        selection.weaponType = weaponBtn._weaponType;
        selection.player = weaponBtn._player;

        customizer.OnWeaponSelected(selection);
    }
}