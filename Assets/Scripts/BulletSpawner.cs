using UnityEngine;

public class BulletSpawner : MonoBehaviour
{ 
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] bool spawn;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnBullet()
    {
        if (gameManager)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            gameManager.onBulletSpawned(bullet);
        }
        else
        {
            Debug.LogError("GameManager is not assigned in BulletSpawner.");
        }
    }

}
