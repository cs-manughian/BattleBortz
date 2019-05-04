using UnityEngine;

public class ProjectileWeapon : MonoBehaviour
{
    ProjectileWeaponSource _weaponSource; 

    void OnTriggerEnter(Collider other)
    {
        if (_weaponSource.IsOpponentHit(other))
        {
            _weaponSource.PlayHitFx();
            _weaponSource.ApplyDamage(other);
        }
    }

    public void AssignWeaponSourceInstance(ProjectileWeaponSource src)
    {
        _weaponSource = src;
    }
}
