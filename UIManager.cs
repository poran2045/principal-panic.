
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text livesText;
    private int lives = 3;

    void Start()
    {
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();
    }

    void UpdateUI()
    {
        livesText.text = "Lives: " + lives;
    }
}
