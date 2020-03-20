using UnityEngine;
[RequireComponent(typeof(_restart))]

public class Lava : MonoBehaviour
{
    public GameObject deathEffect;
    public _restart restartScript;

   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Lava"))
            {

            Instantiate(deathEffect, transform.position, Quaternion.identity);
            restartScript.StartAgain();
            Destroy(gameObject,0.2f);
           
           

        }
    }   

}
