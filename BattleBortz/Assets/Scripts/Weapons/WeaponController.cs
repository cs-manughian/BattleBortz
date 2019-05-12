using UnityEngine;

public class WeaponController : MonoBehaviour
{
    IWeaponBehavior _weaponBehavior;
    bool _isPlayerFiring;
    string controlWeaponButton;

    void Awake()
    {
        _weaponBehavior = GetComponent<IWeaponBehavior>();
    }
    
    void Update()
    {
        ControlWeapon();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == null || other.transform.tag == "Untagged") return;

        char thisPlayerNumber = gameObject.tag[6];
        char colliderPlayerNumber = other.transform.tag[6];
        
        bool isOtherPlayerHit = thisPlayerNumber != colliderPlayerNumber;
        if (isOtherPlayerHit && _isPlayerFiring)
        {
            _weaponBehavior.PlayHitFx();
            _weaponBehavior.ApplyDamage(other);
        }
    }

    void ControlWeapon()
    {
        if (string.IsNullOrEmpty(controlWeaponButton)) 
            return;

        _isPlayerFiring = Input.GetButton(controlWeaponButton);
        if (_isPlayerFiring)
        {
            _weaponBehavior.Fire();
        }
    }

    public void AssignControlWeaponButton(string tag)
    {
        gameObject.tag = tag;
        controlWeaponButton = tag == "Player1"
                                    ? "Fire_P1"
                                    : "Fire_P2";
    }
}
