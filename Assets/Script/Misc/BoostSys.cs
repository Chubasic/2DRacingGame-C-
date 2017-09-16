using UnityEngine;
using UnityEngine.UI;

public class BoostSys : MonoBehaviour 
{

	public GameObject[] boostButt = new GameObject[3];
    [SerializeField]
    Text bonusText;

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.CompareTag("Coin"))
        {
            Racer.Bonuses++;
            Destroy(obj.gameObject);
            bonusText.text = "Coins:" + Racer.Bonuses.ToString();
        }
    }

    void BoostSpeed()
	{
        if (Racer.Bonuses >= 5)
        {
            boostButt[0].SetActive(true);
            if ((Racer.Bonuses >= 8) && (Racer.Bonuses <= 9))
            {
                boostButt[1].SetActive(true);
            }
            if (Racer.Bonuses >= 17)
            {
                boostButt[2].SetActive(true);
            }
        }

    }
		
    private void Update()
    {
        BoostSpeed();
    }

}
