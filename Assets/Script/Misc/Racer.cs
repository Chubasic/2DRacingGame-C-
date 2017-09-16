using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Racer : MonoBehaviour {
    //Fields
    public string playerName;
    public string time;
    private static int bonuses;

    public static int Bonuses
    {
        get
        {
            return bonuses;
        }

        set
        {
            if (value > 0)
            {
                bonuses = value;
            }
        }
    }

 //Constructor
    public Racer(string newName, string newTime)
    {
        playerName = newName;
        time = newTime;
    }
}
