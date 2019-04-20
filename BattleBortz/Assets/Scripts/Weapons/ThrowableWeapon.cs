using UnityEngine;

public class ThrowableWeapon : MonoBehaviour, IWeaponBehavior
{
    public void Fire()
    {
        Debug.Log("Firing Throwable");
    }
}
