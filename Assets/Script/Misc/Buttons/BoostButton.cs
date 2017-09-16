using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostButton : MonoBehaviour {
	
	public CarMovement pSpeed;
	[SerializeField]
	protected float booSpeed;
	[SerializeField]
	GameObject[] panels = new GameObject[3];

	void UIActiveCheck()
	{
		if ((panels [0].activeSelf) || (panels[1].activeSelf)) 
		{
			panels [2].SetActive (false);
			pSpeed.speed = 2500f;
		}
	}

    public void Turbo()
    {
		booSpeed = 2800f;
		pSpeed.speed = booSpeed;
    }

    public void Nitro()
    {
        booSpeed = 3000f;
        pSpeed.speed = booSpeed;
    }

    public void Swsh()
    {
        booSpeed = 3500f;
        pSpeed.speed = booSpeed;
    }

    private void Update()
    {
        UIActiveCheck();
    }
}
