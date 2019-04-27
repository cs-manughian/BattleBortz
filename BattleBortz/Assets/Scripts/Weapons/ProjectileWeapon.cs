using UnityEngine;

public class ProjectileWeapon : MonoBehaviour, IWeaponBehavior
{
    public void Fire()
    {
        Debug.Log("Firing Projectile");
    }

    public void PlayHitFx()
    {
        Debug.Log("Playing Hit Fx for Projectile");
    }
}
