using UnityEngine;

public class ProjectileWeaponSource : BaseWeapon, IWeaponBehavior
{
    [SerializeField] GameObject _projectile;
    [SerializeField] GameObject _projectileSpawnPoint;
    [SerializeField] float _projectileSpeed = 250.0f;

    [SerializeField] float _fireRate = 0.25f;
    float _fireTime = 1.0f;

    void Update()
    {
        _fireTime += Time.deltaTime;
    }

    public void Fire()
    {
        if (_fireTime < _fireRate) return;

        _fireTime = 0.0f;
        GameObject projectile = Instantiate(_projectile);
        projectile.transform.position = _projectileSpawnPoint.transform.position;
        Rigidbody rigidbody = projectile.GetComponent<Rigidbody>();
        Vector3 direction = transform.forward * _projectileSpeed;
        rigidbody.AddForce(direction, ForceMode.Impulse);

        projectile.GetComponent<ProjectileWeapon>().AssignWeaponSourceInstance(this);
    }

    public void PlayHitFx()
    {
        Debug.Log("Playing Hit Fx for Projectile");
    }

    public new void ApplyDamage(Collider bot)
    {
        base.ApplyDamage(bot);
    }

    public bool IsOpponentHit(Collider other)
    {
        return base.IsOpponentHit(gameObject, other);
    }
}
