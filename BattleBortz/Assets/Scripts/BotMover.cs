using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMover : MonoBehaviour
{
    [SerializeField] float speed = 50f;
    [SerializeField] float rotationSpeed = 150f;

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = Vector3.forward * speed;
        Vector3 translation = Input.GetAxis("Vertical") * velocity;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(translation);
        transform.Rotate(0, rotation, 0);
    }
}
