﻿using UnityEngine;

public class ThrowableWeaponSource : BaseWeapon, IWeaponBehavior
{
    [SerializeField] float _riseSpeed = 1f;
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
        Vector3 direction = Vector3.up * _riseSpeed;
        weapon.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
    }
}
