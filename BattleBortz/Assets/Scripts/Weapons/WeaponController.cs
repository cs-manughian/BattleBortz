using UnityEngine;

public class WeaponController : MonoBehaviour
{
    IWeaponBehavior _weaponBehavior;

    // Start is called before the first frame update
    void Start()
    {
        _weaponBehavior = GetComponent<IWeaponBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        ControlWeapon();
    }

    void ControlWeapon()
    {
        bool isPlayerFiring = gameObject.transform.parent.tag == "Player1"
                            ? Input.GetButton("Fire_P1")
                            : Input.GetButton("Fire_P2");
        if (isPlayerFiring)
        {
            _weaponBehavior.Fire();
        }
    }


}
