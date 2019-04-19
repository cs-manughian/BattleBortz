using UnityEngine;
using UnityEngine.UI;
using GameUtils;

public class WeaponToggleActivator : MonoBehaviour
{
    public WeaponType _weaponType;
    public int _player;
    [SerializeField] GameObject _sawObject;
    [SerializeField] GameObject _gunObject;
    [SerializeField] GameObject _teddyObject;

    private Toggle _toggle;
    private Color _baseColor;
    private Color _selectedColor;
    private GameObject _weaponObject;

    // Start is called before the first frame update
    void Start()
    {
        _toggle = GetComponent<Toggle>();
        _toggle.onValueChanged.AddListener((value) => OnToggleValueChanged(value));

        _baseColor = _toggle.colors.normalColor;
        _selectedColor = _toggle.colors.highlightedColor;

        SetToggleWeaponObject();
    }

    // Update is called once per frame
    void Update()
    {
        RotateWeapon();
    }

    void OnToggleValueChanged(bool value)
    {
        if (value)
        {
            GetComponent<Image>().color = _selectedColor;
        }
        else
        {
            GetComponent<Image>().color = _baseColor;
        }
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
