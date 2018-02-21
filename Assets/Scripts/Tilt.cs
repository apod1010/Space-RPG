using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    [SerializeField]
    float tiltSpeed = 10f;
    //[SerializeField]
    //float rotationSpeed = 30f;


    void Update()
    {

        //float rotation = Input.GetAxis("Rotate") * rotationSpeed;
        //rotation *= Time.deltaTime;
        //transform.Rotate(0, rotation, 0);

        float tilt = Input.GetAxis("ShipHorizontal") * tiltSpeed;

        if (Input.GetAxis("ShipHorizontal") != 0)
        {
            tilt *= Time.deltaTime;
            transform.Rotate(tilt, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }

    }
}
