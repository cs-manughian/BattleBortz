using UnityEngine;

public class SpinnableWeapon : MonoBehaviour, IWeaponBehavior
{
    public void Fire()
    {
        transform.Rotate(new Vector3(0f, 0f, 10f));
    }
}
