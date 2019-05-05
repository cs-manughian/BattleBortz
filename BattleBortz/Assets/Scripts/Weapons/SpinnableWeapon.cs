using UnityEngine;

public class SpinnableWeapon : BaseWeapon, IWeaponBehavior
{
    [SerializeField] ParticleSystem _sparks;

    public void Fire()
    {
        // Spin the weapon but not the fx
        Transform hitFx = transform.GetChild(0);
        Quaternion savedRotation = hitFx.rotation;

        float spinSpeed = 50f;
        transform.Rotate(new Vector3(0f, 0f, spinSpeed));

        hitFx.rotation = savedRotation;
    }

    public void PlayHitFx()
    {
        _sparks.Play();
    }

    public new void ApplyDamage(Collider bot)
    {
        base.ApplyDamage(bot);
    }
}
