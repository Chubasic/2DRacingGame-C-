using UnityEngine.UI;
using UnityEngine;


public class InstateTimeRows : MonoBehaviour {

    public GameObject scoreEntryPrefab;

    public void ToUI()
    {
        Racer[] races = Finish.GetAllValues();
        foreach (Racer racer in races)
        {
            GameObject gO = Instantiate(scoreEntryPrefab);
            gO.transform.SetParent(this.transform);
            gO.transform.Find("Players").GetComponent<Text>().text = racer.playerName;
            gO.transform.Find("Time").GetComponent<Text>().text = racer.time;
            Finish.PlayerTime.Clear();
            
        }
    }

    void Update()
    {
        if (Finish.Finished == true)
        {
            ToUI();
            Finish.Finished = false;
        }
        
    }
}
