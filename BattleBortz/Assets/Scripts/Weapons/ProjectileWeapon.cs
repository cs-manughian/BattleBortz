using UnityEngine;

public class ProjectileWeapon : BaseWeapon, IWeaponBehavior
{
    public void Fire()
    {
        Debug.Log("Firing Projectile");
    }

    public void PlayHitFx()
    {
        Debug.Log("Playing Hit Fx for Projectile");
    }

    public new void ApplyDamage(Collider bot)
    {
        base.ApplyDamage(bot);
    }
}
