using UnityEngine;

public class ThrowableWeapon : MonoBehaviour
{
    ThrowableWeaponSource _weaponSource;

    void OnCollisionEnter(Collision other)
    {
        if (_weaponSource.IsOpponentHit(other.collider))
        {
            Explode();
            _weaponSource.ApplyDamage(other.collider);
        }
    }

    void Explode()
    {
        _weaponSource.PlayHitFx();
        Destroy(gameObject);
    }

    public void AssignWeaponSourceInstance(ThrowableWeaponSource src)
    {
        _weaponSource = src;
    }
}
