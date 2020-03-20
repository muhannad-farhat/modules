using UnityEngine;

public class move_cam : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    void Update()
    {
       
              Vector3 Distance = (player1.position + player2.position) / 2;
              transform.position = Distance;

        
    }
}
