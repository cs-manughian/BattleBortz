using UnityEngine;

public class ThrowableWeaponSource : BaseWeapon, IWeaponBehavior
{
    [SerializeField] float _riseSpeed = 1f;
    [SerializeField] GameObject _bearThrowable;

    public void Fire()
    {
        Debug.Log("Firing Throwable");
        InstantiateWeapon();
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

    void InstantiateWeapon()
    {
        GameObject weapon = Instantiate(_bearThrowable);
        weapon.transform.position = gameObject.transform.position;
        weapon.GetComponent<ThrowableWeapon>().AssignWeaponSourceInstance(this);
    }

    void ThrowWeapon()
    {
        _bearThrowable.GetComponent<Rigidbody>().velocity = Vector3.up * _riseSpeed;
    }
}
