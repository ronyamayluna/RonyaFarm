using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] GameObject gameoverscreen;
    [SerializeField] TextMeshProUGUI finalScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
        gameoverscreen.SetActive(false);
    }

    // Update is called once per frame
    public void ShowGameOverScreen()
    {
        Time.timeScale = 0f;
        finalScoreText.text = "" + scoreManager.score;
        gameoverscreen.SetActive(true);
        
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene1"); // 
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ContiniueGameThatPlaying()
            {
        Time.timeScale = 1f;
        gameoverscreen.SetActive(false);
    }
}
