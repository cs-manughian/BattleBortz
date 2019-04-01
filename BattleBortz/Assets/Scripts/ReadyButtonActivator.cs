using UnityEngine;
using UnityEngine.UI;

public class ReadyButtonActivator : MonoBehaviour
{
    BotCustomizer _customizer;
    Button _readyButton;

    void Start()
    {
        _readyButton = GetComponent<Button>();

        _customizer = GameObject.Find("BotCustomizer").GetComponent<BotCustomizer>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (!_readyButton.interactable && _customizer.IsPlayerSelectionComplete())
        {
            _readyButton.interactable = true;
        }
    }
}
