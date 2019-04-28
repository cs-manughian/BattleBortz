using UnityEngine;

public class ThrowableWeapon : BaseWeapon, IWeaponBehavior
{
    public void Fire()
    {
        Debug.Log("Firing Throwable");
    }

    public void PlayHitFx()
    {
        Debug.Log("Playing Hit Fx for Throwable");
    }

    public new void ApplyDamage(Collider bot)
    {
        base.ApplyDamage(bot);
    }
}
