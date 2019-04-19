using UnityEngine;
using GameUtils;

public class WeaponLoader : MonoBehaviour
{
    [SerializeField] GameObject _sawObject;
    [SerializeField] GameObject _gunObject;
    [SerializeField] GameObject _teddyObject;

    [SerializeField] GameObject _weaponBone;

    BotCustomizer _customizer;

    // Start is called before the first frame update
    void Start()
    {
        SetBotCustomization();

        WeaponType weaponType = gameObject.tag == "Player1" 
                              ? _customizer.PlayerOneSelection 
                              : _customizer.PlayerTwoSelection;

        MountWeapon(weaponType);
    }

    void SetBotCustomization()
    {
        GameObject gameObject = GameObject.Find("BotCustomizer");
        if (gameObject == null)
        {
            // This is for when the game scene is ran directly
            _customizer = new GameObject().AddComponent<BotCustomizer>();
        }
        else
        {
            _customizer = gameObject.GetComponent<BotCustomizer>();
        }
    }

    void MountWeapon(WeaponType weaponType)
    {
        switch (weaponType)
        {
            case WeaponType.SAW:
                PositionWeapon(_sawObject);
                break;
            case WeaponType.GUN:
                PositionWeapon(_gunObject);
                break;
            case WeaponType.TEDDY_BEAR:
                PositionWeapon(_teddyObject);
                break;
            default:
                PositionWeapon(_teddyObject);
                break;
        }
    }

    void PositionWeapon(GameObject weaponRef)
    {
        GameObject weapon = Instantiate(weaponRef);
        weapon.transform.SetParent(_weaponBone.transform, worldPositionStays:false);
    }
}
