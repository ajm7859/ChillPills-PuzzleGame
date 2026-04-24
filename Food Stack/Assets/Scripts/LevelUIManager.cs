using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelUIManager : MonoBehaviour
{
    public TMP_Text timerText;
    private float timer;
    private bool levelRunning = true;

    public GameObject levelCompletePanel;
    public TMP_Text starsText;
    public TMP_Text timeText;

    public float threeStarTime = 20f;
    public float twoStarTime = 40f;

    private void Start()
    {
        levelCompletePanel.SetActive(false);
        timer = 0f;
        levelRunning = true;
    }

    private void Update()
    {
        if (!levelRunning) return;

        timer += Time.deltaTime;
        timerText.text = $"Time: {timer:F1}s";
    }

    public void CompleteLevel()
    {
        levelRunning = false;

        int stars = GetStars();

        starsText.text = GetStarText(stars);
        timeText.text = $"Time: {timer:F1}s";

        levelCompletePanel.SetActive(true);
    }

    private int GetStars()
    {
        if (timer <= threeStarTime)
        {
            return 3;
        }

        if (timer <= twoStarTime)
        {
            return 2;
        }

        return 1;
    }

    private string GetStarText(int stars)
    {
        if (stars == 3) return "***";
        if (stars == 2) return "**-";
        return "*--";
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}