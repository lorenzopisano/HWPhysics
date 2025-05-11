using UnityEngine;

public class BulletSpawner : MonoBehaviour
{ 
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] bool spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            spawn = false;
        }
    }
}
