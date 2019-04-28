
using UnityEngine;

public interface IWeaponBehavior
{
    void Fire();
    void PlayHitFx();
    void ApplyDamage(Collider bot);
}
