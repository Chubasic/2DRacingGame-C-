using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {
    [SerializeField]
	private float frenzy = 3f;
	public Text frenzyTimer;
	static public bool frenzyTime = true;
	GameObject dest;

	void Start()
	{
		dest = GameObject.FindGameObjectWithTag ("Frenzy");
        frenzyTime = true;

	}

	void Awake ()
	{
		StartCoroutine (Count());
	}

	void FrenzyTime()
	{
		string frenzyToString = ((int)frenzy).ToString ("0");
		frenzyTimer.text = "Race start in " + frenzyToString;
	}

	IEnumerator Count()
	{
		while (frenzy > 1f) {
			FrenzyTime ();
			frenzy -= Time.deltaTime;
			yield return frenzy;
		}

	}


	void Update()
	{
		if (frenzy < 1f) 
		{
			frenzyTime = false;
			dest.GetComponent<Text> ().enabled = false;
		}

	}
}