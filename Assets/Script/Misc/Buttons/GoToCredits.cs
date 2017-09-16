using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToCredits : MonoBehaviour
{

    public void GotoCredits()
    {
        SceneManager.LoadScene("Ending", LoadSceneMode.Single);
    }
}
