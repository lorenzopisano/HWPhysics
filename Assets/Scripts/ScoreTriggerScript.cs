using UnityEngine;

public class ScoreTriggerScript : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private int scoreValue = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            if (gameManager != null)
            {
                gameManager.UpdateScore(scoreValue); 
            }
        }
    }
}
