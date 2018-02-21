using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipController : MonoBehaviour
{
    [SerializeField]
    float speed = 5.0f;
    [SerializeField]
    float boostSpeedMultiplier = 2.0f;
    [SerializeField]
    float maxVelocityChange = 10.0f;
    [SerializeField]
    float rotationSpeed = 30f;

    Rigidbody rb;
    float boostSpeed;
    float boostSpeedRegular = 1;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
        rb.useGravity = false;
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("ReturnToShip"))
        {
            SceneManager.LoadScene("SmShipBridge");
        }

        if (Input.GetButton("Boost"))
        {
            boostSpeed = boostSpeedMultiplier;
        }
        else
        {
            boostSpeed = boostSpeedRegular;
        }     

        HandleMovement();
    }

    void Update()
    {
        float rotation = Input.GetAxis("Rotate") * rotationSpeed;
        rotation *= Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }

    void HandleMovement()
    {
        Vector3 targetVelocity = new Vector3(Input.GetAxis("Vertical"), Input.GetAxis("UpAndDown"), Input.GetAxis("ShipHorizontal"));

        targetVelocity = transform.TransformDirection(targetVelocity);

        targetVelocity *= speed * boostSpeed;

        Vector3 velocity = rb.velocity;
        Vector3 velocityChange = (targetVelocity - velocity);
        velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        velocityChange.y = Mathf.Clamp(velocityChange.y, -maxVelocityChange, maxVelocityChange);
        rb.AddForce(velocityChange, ForceMode.VelocityChange);


    }
}
