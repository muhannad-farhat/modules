using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class _restart : MonoBehaviour
{
    
    public float RealTimer = 0.6f;
    bool EndGame = false;

    

    void Update()
    {
        if (EndGame == true)
        {
            RealTimer -= Time.deltaTime;
            if (RealTimer <= 0 )
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void StartAgain()
    {
        EndGame = true;  
    }
}
