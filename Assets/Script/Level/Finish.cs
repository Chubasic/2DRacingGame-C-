using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Finish : MonoBehaviour
{
    // Separeted just for i dont know why//
    public static Dictionary<string, Racer> PlayerTime = new Dictionary<string, Racer>();
    private static bool finished = false;
    //public int debug = 0;
    public GameObject results;
	private int foeNum = 0;

    public static bool Finished
    {
        get
        {
            return finished;
        }

        set
        {
            finished = value;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
		

        if (coll.tag == "Player")
        {
            string keyTag = coll.tag;
            string tValue = Timer.TimerValue;//Timer values
			Destroy(GameObject.FindWithTag(coll.tag));
            SetPlayerTime(keyTag, tValue);
            ResultBoardShow();
            //debug++; for some reason this method works twice :(
            //Debug.Log(debug);
        } else if (coll.tag == "Enemy")
        {
			foeNum++;
			string keyTag = coll.tag + foeNum.ToString();
            string tValue = Timer.TimerValue;
			Destroy(coll.gameObject);
            SetPlayerTime(keyTag, tValue);
            ResultBoardShow();
        }
        else {
            return;
        }
    }
    void Init()
    {
        if (PlayerTime != null)
            return;
    }

     void SetPlayerTime(string keyTag, string tValue)
    {
        //Init();
        if (!PlayerTime.ContainsKey(keyTag))
        {
            PlayerTime.Add(keyTag, new Racer(keyTag, tValue));
        }
        else {
            PlayerTime.Clear();
        }
    }

    public static Racer[] GetAllValues()//For future it will be static and public1
    {
        return PlayerTime.Values.ToArray();
    }
    public void ResultBoardShow()
    {
        Finished = true;
        results.SetActive(true);
    }
}