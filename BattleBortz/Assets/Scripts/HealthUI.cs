using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] Text _player1Text;
    [SerializeField] Text _player2Text;
    [SerializeField] Text _winText;

    // Start is called before the first frame update
    void Awake()
    {
        GameObject player1 = GameObject.FindGameObjectWithTag("Player1");
        ScoreTracker scoreTracker = player1.GetComponent<ScoreTracker>();
        scoreTracker.OnHealthChanged += UpdatePlayer1Health;

        GameObject player2 = GameObject.FindGameObjectWithTag("Player2");
        scoreTracker = player2.GetComponent<ScoreTracker>();
        scoreTracker.OnHealthChanged += UpdatePlayer2Health;
    }

    void UpdatePlayer1Health(int health)
    {
        if (health == 0) DisplayWinScreen("Player 1");
        _player1Text.text = string.Format("P1: {0}", health);
    }

    void UpdatePlayer2Health(int health)
    {
        if (health == 0) DisplayWinScreen("Player 2");
        _player2Text.text = string.Format("P2: {0}", health);
    }

    void DisplayWinScreen(string winner)
    {
        _winText.text = string.Format("{0} wins!", winner);
        _winText.gameObject.SetActive(true);
    }
}
