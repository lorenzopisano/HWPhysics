using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] float minY = -100.0f;
    [SerializeField] float maxX = 100f;
    [SerializeField] float minX = -100f;
    void Start()
    {
    }
    
    void Update()
    {
        if (this.transform.position.y < minY || this.transform.position.x > maxX || this.transform.position.x < minX)
        {
            Destroy(this.gameObject);
        }
    }
}
