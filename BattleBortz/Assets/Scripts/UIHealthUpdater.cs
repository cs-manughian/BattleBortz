using UnityEngine;
using UnityEngine.UI;

public class UIHealthUpdater : MonoBehaviour
{
    [SerializeField] Text _player1text;
    [SerializeField] Text _player2text;

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
        _player1text.text = string.Format("P1: {0}", health);
    }

    void UpdatePlayer2Health(int health)
    {
        _player2text.text = string.Format("P2: {0}", health);
    }
}
