﻿using UnityEngine;
using UnityEngine.UI;
using GameUtils;

// This goes on choose container
public class WeaponSelector : MonoBehaviour
{
    BotCustomizer _customizer;

    void Start()
    {
        _customizer = GameObject.Find("BotCustomizer").GetComponent<BotCustomizer>();

        // Get all buttons
        Toggle[] toggles = GetComponentsInChildren<Toggle>();
        foreach (Toggle toggle in toggles)
        {
            // Apply SelectWeapon as the onValueChanged event
            toggle.onValueChanged.AddListener((value) => SelectWeapon(toggle, value));
        }
    }

    // On Click for Weapon Button Object
    void SelectWeapon(Toggle toggle, bool value)
    {
        if (!value) return;
        // TODO:
        // This is actually the script. We need to rename the script on refactor
        WeaponToggleActivator weaponActivator = toggle.GetComponent<WeaponToggleActivator>(); 

        WeaponSelection selection;
        selection.weaponType = weaponActivator._weaponType;
        selection.player = weaponActivator._player;

        _customizer.OnWeaponSelected(selection);
    }
}