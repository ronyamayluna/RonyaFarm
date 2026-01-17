using UnityEngine;
using TMPro; // Подключаем TextMeshPro
using System.Collections;

public class TimerLevel2 : MonoBehaviour
{
    [SerializeField] private float gameDuration = 30f; // Длительность таймера в секундах
    [SerializeField] private TMP_Text timerText; // Используем TMP_Text для TextMeshPro
    [SerializeField] private GameObject gameOverCanvas; // Ссылка на Canvas, который будет отображаться при окончании времени
    [SerializeField] UIManagerLevelTwo UIManagerLevelTwo; // Исправлено: используем правильный тип

    private float timeRemaining;
    private bool isGameOver = false;

    void Start()
    {
        timeRemaining = gameDuration;

        if (timerText == null)
        {
            Debug.LogError("Текстовый компонент для таймера (TextMeshPro) не назначен!");
        }

        if (gameOverCanvas == null)
        {
            Debug.LogError("Canvas для окончания игры не назначен!");
        }
        else
        {
            gameOverCanvas.SetActive(false); // Скрываем Canvas в начале игры
        }

        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        while (timeRemaining > 0)
        {
            timerText.text = $"Timer: {Mathf.CeilToInt(timeRemaining)} "; // Обновляем текст таймера
            yield return new WaitForSeconds(1f); // Ждём 1 секунду
            timeRemaining--;
        }

        EndGame();
    }

    private void EndGame()
    {
        isGameOver = true;
        timerText.text = "Time!"; // Устанавливаем текст таймера на сообщение
        UIManagerLevelTwo.ShowLevelSecond(); // Показываем Canvas окончания игры
    }
}
