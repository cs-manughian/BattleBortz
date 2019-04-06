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
        _customizer = GameObject.Find("BotCustomizer").GetComponent<BotCustomizer>();
        WeaponType weaponType = gameObject.tag == "Player1" 
                              ? _customizer.PlayerOneSelection 
                              : _customizer.PlayerTwoSelection;

        MountWeapon(weaponType);
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
                break;
        }
    }

    void PositionWeapon(GameObject weaponRef)
    {
        GameObject weapon = Instantiate(weaponRef);
        weapon.transform.SetParent(_weaponBone.transform, worldPositionStays:false);
    }
}
