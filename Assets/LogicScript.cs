using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    private int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    private AudioSource dingSFX;
    [ContextMenu("Increase Score")]
    private void Start()
    {
        dingSFX = GetComponent<AudioSource>();
    }
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }

    public void restartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() 
    {
        gameOverScreen.SetActive(true);
    }
}
