using UnityEngine;
using GameUtils;

public class WeaponButton : MonoBehaviour
{
    public WeaponType _weaponType;
    public int _player;
    [SerializeField] GameObject _sawObject;
    [SerializeField] GameObject _gunObject;
    [SerializeField] GameObject _teddyObject;

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
