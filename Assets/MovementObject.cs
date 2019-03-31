using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObject : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 20000f;
    public float sidewayForce = 500f;

    public void MoveLeft()
    {
        rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void MoveRight()
    {
        rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
