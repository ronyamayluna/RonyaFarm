using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerLevelTwo : MonoBehaviour
{
    [SerializeField] GameObject levelsecond;
    [SerializeField] ScoreManager scoreManager;
    
    [SerializeField] TextMeshProUGUI finalScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1f;
        levelsecond.SetActive(false);
    }

    // Update is called once per frame
    public void ShowLevelSecond()
    {
        Time.timeScale = 0f;
        finalScoreText.text = "" + scoreManager.score;
        levelsecond.SetActive(true);

    }
    public void ContinueGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene2"); 
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ContiniueGameThatPlaying()
    {
        Time.timeScale = 1f;
        levelsecond.SetActive(false);
    }
}
