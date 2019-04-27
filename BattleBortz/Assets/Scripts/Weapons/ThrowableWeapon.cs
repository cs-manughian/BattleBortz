using UnityEngine;

public class ThrowableWeapon : MonoBehaviour, IWeaponBehavior
{
    public void Fire()
    {
        Debug.Log("Firing Throwable");
    }

    public void PlayHitFx()
    {
        Debug.Log("Playing Hit Fx for Throwable");
    }
}
