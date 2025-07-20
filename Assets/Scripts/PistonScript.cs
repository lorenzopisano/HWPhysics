using System;
using UnityEngine;

public class PistonScript : MonoBehaviour
{
    [SerializeField] float springForce = 150.0f;
    [SerializeField] float pullForce;
    bool _isPulling;
    Rigidbody _rb;
    SpringJoint _spring;
    void Start()
    {
        this._rb = this.GetComponent<Rigidbody>();
        this._spring = this.GetComponent<SpringJoint>();
        
    }
    void Update()
    {
        this._isPulling = Input.GetKey(KeyCode.Space);
    }

    void FixedUpdate()
    {
        if (_isPulling)
        {
            this._rb.AddForce(Vector3.down * pullForce, ForceMode.Force);
            this._spring.spring = 1;
        }
        else
        {
            this._spring.spring = springForce;
        }
    }
}
