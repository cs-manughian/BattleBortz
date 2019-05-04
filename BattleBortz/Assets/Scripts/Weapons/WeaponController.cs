using UnityEngine;

public class WeaponController : MonoBehaviour
{
    IWeaponBehavior _weaponBehavior;
    bool _isPlayerFiring;

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

        char thisPlayerNumber = gameObject.transform.parent.tag[6];
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
        _isPlayerFiring = gameObject.transform.parent.tag == "Player1"
                            ? Input.GetButton("Fire_P1")
                            : Input.GetButton("Fire_P2");
        if (_isPlayerFiring)
        {
            _weaponBehavior.Fire();
        }
    }
}
