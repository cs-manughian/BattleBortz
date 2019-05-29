using UnityEngine;

public class BotMover : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10000f;
    [SerializeField] float rotationSpeed = 500f;

    [SerializeField] float maxMovementSpeed = 3f;
    [SerializeField] float maxRotationSpeed = 3f;

    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalAxis = gameObject.tag == "Player1" 
                                ? Input.GetAxis("Horizontal_P1") 
                                : Input.GetAxis("Horizontal_P2");
        float verticalAxis = gameObject.tag == "Player1" 
                                ? Input.GetAxis("Vertical_P1") 
                                : Input.GetAxis("Vertical_P2");

        Vector3 translation = verticalAxis * Vector3.forward * movementSpeed;
        if (_rigidbody.velocity.sqrMagnitude < maxMovementSpeed)
        {
            _rigidbody.AddRelativeForce(translation, ForceMode.VelocityChange);
        }

        Vector3 rotation = horizontalAxis * rotationSpeed * Vector3.up;
        if (Mathf.Abs(_rigidbody.angularVelocity.y) < maxRotationSpeed)
        {
            _rigidbody.AddRelativeTorque(rotation, ForceMode.VelocityChange);
        }
    }
}
