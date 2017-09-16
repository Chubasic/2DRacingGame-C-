using System.Collections;
using System.Collections.Generic;

using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Construct_car : MonoBehaviour
{
    protected Rigidbody2D rb;

    public float speed = 1340f;
    public float rotationSpeed = 0;
    public float BreakTrorque = -150f;
    public bool isBraking = false;


    public WheelJoint2D backWheel;
    public WheelJoint2D frontWheel;


    protected float movement = 0f;
    protected float rotation = 0f;


    public virtual void Braking()
    {
        if (isBraking)
        {
            backWheel.breakTorque = BreakTrorque;
        }
    }
}