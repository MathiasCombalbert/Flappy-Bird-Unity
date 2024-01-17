using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private Player player;
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject gameOver;

    private int score;
    public int Score => score;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            Application.targetFrameRate = 60;
            DontDestroyOnLoad(gameObject);
            Pause();
        }
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        //Fill this line to show the necessary UI
        //Your code here...

        Time.timeScale = 1f;
        player.enabled = true;

        //Fill this line to get a list of the pipes present on the scene
        //Your code here...

        //Uncomment after
        // for (int i = 0; i < pipes.Length; i++) {
        //     Destroy(pipes[i].gameObject);
        // }
    }

    public void GameOver()
    {
        //Fill this line to show the necessary UI
        //Your code here...

        Pause();
    }

    public void Pause()
    {
        //Fill this line to add pause logic hint: freezing time might do it
        //Your code here...
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        //Fill this line to update the score on the scoreText object
        //Your code here...
    }

}