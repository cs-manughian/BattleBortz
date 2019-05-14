using UnityEngine;
using UnityEngine.UI;
using GameUtils;

public class WeaponButtonActivator : MonoBehaviour
{
    public WeaponType _weaponType;
    public int _player;
    [SerializeField] GameObject _sawObject;
    [SerializeField] GameObject _gunObject;
    [SerializeField] GameObject _teddyObject;

    private GameObject _weaponObject;

    [SerializeField] Color _baseColor;
    [SerializeField] Color _selectedColor;

    bool _isSelected = false;
    Image _image;

    // Start is called before the first frame update
    void Start()
    {
        SetToggleWeaponObject();

        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        RotateWeapon();

        // Update color because screw Unity
        if (_isSelected) _image.color = _selectedColor;
        else _image.color = _baseColor;
    }

    public void SelectButton(bool value)
    {
        _isSelected = value;
    }

    void SetToggleWeaponObject()
    {
        if (_weaponType == WeaponType.SAW)
        {
            _weaponObject = _sawObject;
        }
        else if (_weaponType == WeaponType.GUN)
        {
            _weaponObject = _gunObject;
        }
        else
        {
            _weaponObject = _teddyObject;
        }
    }

    void RotateWeapon()
    {
        _weaponObject.transform.Rotate(new Vector3(0f, 0.25f, 0.05f));
    }
}
