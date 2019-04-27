using UnityEngine;

public class SpinnableWeapon : MonoBehaviour, IWeaponBehavior
{
    [SerializeField] ParticleSystem sparks;

    public void Fire()
    {
        float spinSpeed = 50f;
        transform.Rotate(new Vector3(0f, 0f, spinSpeed));
    }

    public void PlayHitFx()
    {
        sparks.Play();
    }
}
