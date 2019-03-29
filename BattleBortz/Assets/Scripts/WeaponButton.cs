using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponButton : MonoBehaviour
{
    public enum WeaponType
    {
        SAW,
        GUN,
        TEDDY_BEAR
    };

    public WeaponType _weaponType;
    public GameObject _sawObject;
    public GameObject _gunObject;
    public GameObject _teddyObject;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (_weaponType == WeaponType.SAW)
        {
            _sawObject.SetActive(true);
            _gunObject.SetActive(false);
            _teddyObject.SetActive(false);

            _sawObject.transform.Rotate(new Vector3(0f, 0.5f, 0.1f));
        }
        else if (_weaponType == WeaponType.GUN)
        {
            _sawObject.SetActive(false);
            _gunObject.SetActive(true);
            _teddyObject.SetActive(false);
            
            _gunObject.transform.Rotate(new Vector3(0f, 0.5f, 0.1f));
        }
        else
        {
            _sawObject.SetActive(false);
            _gunObject.SetActive(false);
            _teddyObject.SetActive(true);
            
            _teddyObject.transform.Rotate(new Vector3(0f, 0.5f, 0.1f));
        }
    }
}
