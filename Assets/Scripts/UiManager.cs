using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private TMP_Text scoreText;
    void Start()
    {
        
    }
    
    void OnEnable()
    {
        gameManager.OnScoreChanged += UpdateScore;
    }

    void OnDisable()
    {
        gameManager.OnScoreChanged -= UpdateScore;
    }

    private void UpdateScore(int score)
    {
        this.scoreText.SetText("Score:\n" + score);
    }
    
}
