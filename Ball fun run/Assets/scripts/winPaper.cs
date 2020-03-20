using UnityEngine;
using UnityEngine.SceneManagement;
public class winPaper : MonoBehaviour
{

    public GameObject winShow;
    bool levelWon = false;
    float timer = 2;


    private void Update()
    {
        transform.Rotate(25 * Time.deltaTime, 18 * Time.deltaTime, -8 * Time.deltaTime);
        GoNextLevel();
    }

    

    void GoNextLevel()
    {
        
        if (levelWon == true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            winShow.SetActive(true);
            levelWon = true;
        }
    }
}
