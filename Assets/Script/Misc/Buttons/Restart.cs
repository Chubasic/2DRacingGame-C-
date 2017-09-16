using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void TryAgain()
    {
		Racer.Bonuses = 1;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainLevel", LoadSceneMode.Single);
    }
}
