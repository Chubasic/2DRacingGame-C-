using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFire : MonoBehaviour 
{
	[SerializeField]
	GameObject projectile;//bullet prefab
	[SerializeField]
	Transform pooSpawn;//fire position
	//Movement
	[SerializeField]
	Rigidbody2D movement;
	private float rotationSpeed = 450f;

	void Start()
	{
		movement = GetComponent<Rigidbody2D> ();
		InvokeRepeating ("Fire", 2.0f, 3f);
	}

	void Fire()
	{

		GameObject energyPoo = (GameObject)Instantiate (projectile, pooSpawn.position, pooSpawn.rotation);
		energyPoo.GetComponent<Rigidbody2D>().velocity = -energyPoo.transform.up * 70;
		Destroy (energyPoo, 2.0f);

	}

	void FixedUpdate()
	{
		movement.AddTorque (1f * rotationSpeed * Time.deltaTime);
	}
}
