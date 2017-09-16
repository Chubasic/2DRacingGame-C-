using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour {

    Vector3 sin;

    void Start()
    {
        sin = transform.position;
    }

    void AnimateSin()
    {
        float sinY = Mathf.Sin(Time.realtimeSinceStartup * 0.5f) + sin.y;
        float sinSpin = Mathf.Sin(Time.realtimeSinceStartup * 0.8f);
        transform.position = new Vector3(sin.x, sinY, 0);
        transform.rotation = Quaternion.Euler(0, sinSpin, 0);
    }


    void FixedUpdate()
    {
        AnimateSin();
    }
}
