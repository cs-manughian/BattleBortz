using UnityEngine;

public class ThrowableWeapon : MonoBehaviour
{
    [SerializeField] ParticleSystem _explosion;
    [SerializeField] AudioSource _soundFx;
    ThrowableWeaponSource _weaponSource;
    bool _isFirstOpponentCollision = true;

    void OnCollisionEnter(Collision other)
    {
        Explode();
        if (_weaponSource.IsOpponentHit(other.collider) && _isFirstOpponentCollision)
        {
            _isFirstOpponentCollision = false;
            _weaponSource.ApplyDamage(other.collider);
        }
    }

    void Explode()
    {
        GetComponent<MeshRenderer>().enabled = false;
        _soundFx.Play();
        _explosion.Play();
        Destroy(gameObject, _explosion.main.duration);
        //_weaponSource.PlayHitFx();
    }

    public void AssignWeaponSourceInstance(ThrowableWeaponSource src)
    {
        _weaponSource = src;
    }
}
