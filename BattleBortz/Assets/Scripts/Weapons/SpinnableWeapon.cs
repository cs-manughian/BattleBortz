using UnityEngine;

public class SpinnableWeapon : MonoBehaviour, IWeaponBehavior
{
    public void Fire()
    {
        Debug.Log("Firing");
    }
}
