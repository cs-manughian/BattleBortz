using UnityEngine;

public class ThrowableWeapon : MonoBehaviour
{
    ThrowableWeaponSource _weaponSource;

    void OnCollisionEnter(Collision other)
    {
        if (_weaponSource.IsOpponentHit(other.collider))
        {
            _weaponSource.PlayHitFx();
            _weaponSource.ApplyDamage(other.collider);
        }
    }

    public void AssignWeaponSourceInstance(ThrowableWeaponSource src)
    {
        _weaponSource = src;
    }
}
