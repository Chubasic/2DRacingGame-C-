using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSensor : MonoBehaviour {
    public Transform backSensor;
    [SerializeField]
    GameObject carCar;

    void Start()
    {
        backSensor = GetComponent<Transform>();
    }

    private void Update()
    {
        RaycastHit2D hitBack = Physics2D.Raycast(backSensor.position, Vector3.down);
        Debug.DrawRay(backSensor.position, Vector3.down);
        if (hitBack.collider != null)
        {
            if (hitBack.collider.gameObject.CompareTag("Ground"))
            {
                carCar.transform.rotation = Quaternion.identity;
            }
        }
        else
        {
            return;
        }
    }
}
