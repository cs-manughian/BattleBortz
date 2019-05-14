using UnityEngine;
using UnityEngine.UI;
using GameUtils;
using System.Collections.Generic;

// This goes on choose container
public class WeaponSelector : MonoBehaviour
{
    BotCustomizer _customizer;

    List<WeaponButtonActivator> _weaponButtonActivators = new List<WeaponButtonActivator>();

    void Start()
    {
        _customizer = GameObject.Find("BotCustomizer").GetComponent<BotCustomizer>();

        // Get all buttons
        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            // Apply SelectWeapon as the onClick event
            button.onClick.AddListener(() => SelectWeapon(button));

            _weaponButtonActivators.Add(button.GetComponent<WeaponButtonActivator>());
        }
    }

    // On Click for Weapon Button Object
    void SelectWeapon(Button button)
    {
        WeaponButtonActivator weaponActivator = button.GetComponent<WeaponButtonActivator>();
        foreach (WeaponButtonActivator buttonActivator in _weaponButtonActivators)
        {
            buttonActivator.SelectButton(false);
        }
        weaponActivator.SelectButton(true);

        WeaponSelection selection;
        selection.weaponType = weaponActivator._weaponType;
        selection.player = weaponActivator._player;

        _customizer.OnWeaponSelected(selection);
    }
}