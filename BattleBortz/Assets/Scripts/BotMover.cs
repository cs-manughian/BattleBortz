using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMover : MonoBehaviour
{
    [SerializeField] float speed = 10000f;
    [SerializeField] float rotationSpeed = 500f;

    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalAxis = gameObject.tag == "Player1" ? Input.GetAxis("Horizontal_P1") : Input.GetAxis("Horizontal_P2");
        float verticalAxis = gameObject.tag == "Player1" ? Input.GetAxis("Vertical_P1") : Input.GetAxis("Vertical_P2");

        Vector3 velocity = Vector3.forward * speed;
        Vector3 translation = verticalAxis * velocity;
        Vector3 rotation = horizontalAxis * rotationSpeed * Vector3.up;

        translation *= Time.fixedDeltaTime;
        rotation *= Time.fixedDeltaTime;
        
        _rigidbody.AddRelativeForce(translation, ForceMode.Force);
        _rigidbody.AddRelativeTorque(rotation, ForceMode.Acceleration);
    }
}
