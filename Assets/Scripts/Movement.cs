using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float ySpeed = 0.75f;
    public float xSpeed = 1.0f;

    private Vector3 moveDelta;

    protected virtual void UpdateMotor(Vector3 input)
    {
        // Reset moveDelta
        moveDelta = new Vector3(input.x * xSpeed, input.y * ySpeed, 0f);
        transform.Translate(moveDelta.x * Time.deltaTime, moveDelta.y * Time.deltaTime, 0);
    }
}
