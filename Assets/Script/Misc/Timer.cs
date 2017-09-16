using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    
    public Text timer;
    private float startTimer;
    private string minutes;
    private string seconds;
    private static string timerValue;

    public static string TimerValue
    {
        get
        {
            return timerValue;
        }

        set
        {
            timerValue = value;
        }
    }

    // Use this for initialization
    void Start () {
        startTimer = Time.time;
    }

    void TimerFunc() {
		
		float t = Time.time - startTimer;
		minutes = ((int)t / 60).ToString();
		seconds = (t % 60).ToString("0");
		timer.text = "Your time:" + minutes + ":" + seconds;
		TimerValue = "Time:" + minutes + ":" + seconds;
    }


    // Update is called once per frame
    void Update () {

        if (Finish.Finished == false && CountDown.frenzyTime == false)
        {
            TimerFunc();
        }
	}
}


