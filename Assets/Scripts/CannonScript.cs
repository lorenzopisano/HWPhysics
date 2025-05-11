using UnityEngine;

public class CannonScript : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 15f;
    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.forward, vertical * rotationSpeed * Time.deltaTime);
    }
}
