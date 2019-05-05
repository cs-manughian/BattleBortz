using UnityEngine;

public class ThrowableWeaponSource : BaseWeapon, IWeaponBehavior
{
    [SerializeField] float _riseSpeed = 5f;
    [SerializeField] GameObject _bearThrowable;

    float _fireTime = 1.0f;
    float _fireRate = 1.0f;

    void Update()
    {
        _fireTime += Time.deltaTime;
    }

    public void Fire()
    {
        if (_fireTime < _fireRate) return;
        _fireTime = 0.0f;

        ThrowWeapon();
    }

    public void PlayHitFx()
    {
        // TODO: Refactor for weapon source classes
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
        Vector3 spawnPos = Vector3.up * 0.25f;
        weapon.transform.position = gameObject.transform.position + spawnPos;
        weapon.GetComponent<ThrowableWeapon>().AssignWeaponSourceInstance(this);
        return weapon;
    }

    void ThrowWeapon()
    {
        GameObject weapon = InstantiateWeapon();
        float forwardForceFactor = 0.25f;
        float upForceFactor = 0.5f;
        Vector3 force = (transform.forward * forwardForceFactor + Vector3.up * upForceFactor) * _riseSpeed;
        weapon.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
    }
}