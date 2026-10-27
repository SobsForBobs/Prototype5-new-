using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    public int difficulty;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        gameManagerX.StartGame(difficulty);
    }

}