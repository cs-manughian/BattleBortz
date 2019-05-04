using UnityEngine;

public class ThrowableWeaponSource : BaseWeapon, IWeaponBehavior
{
    [SerializeField] float _riseSpeed = 1f;
    [SerializeField] GameObject _bearThrowable;

    public void Fire()
    {
        Debug.Log("Firing Throwable");
        ThrowWeapon();
    }

    public void PlayHitFx()
    {
        Debug.Log("Playing Hit Fx for Throwable");
    }

    public new void ApplyDamage(Collider bot)
    {
        base.ApplyDamage(bot);
    }

    public bool IsOpponentHit(Collider other)
    {
        return base.IsOpponentHit(gameObject, other);
    }

    GameObject InstantiateWeapon()
    {
        GameObject weapon = Instantiate(_bearThrowable);
        weapon.transform.position = gameObject.transform.position;
        weapon.GetComponent<ThrowableWeapon>().AssignWeaponSourceInstance(this);
        return weapon;
    }

    void ThrowWeapon()
    {
        GameObject weapon = InstantiateWeapon();
        weapon.GetComponent<Rigidbody>().velocity = Vector3.up * _riseSpeed;
    }
}
