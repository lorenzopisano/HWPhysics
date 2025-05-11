using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] float minY = 0f;
    [SerializeField] float maxX = 100f;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (this.transform.position.y < minY || this.transform.position.x > maxX)
        {
            Destroy(this.gameObject);
        }
    }
}
