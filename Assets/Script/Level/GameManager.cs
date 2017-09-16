using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverPanel;
    //Restart Panel functionality

    public void RestartPanel()
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0.2f;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            RestartPanel();
        }
    }
}
