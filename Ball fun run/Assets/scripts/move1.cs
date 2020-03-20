using UnityEngine;
public class move1 : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float JumpForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(-10 * speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(10 * speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(0, 0, -10 * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(0, 0, 10 * speed * Time.deltaTime);

        
        jump();
    }

    void jump()
    {
       
         if (ReadyToJump())
         {
           
            if (Input.GetKey(KeyCode.RightShift))
            {
                rb.AddForce(0, 10 * JumpForce * Time.deltaTime, 0, ForceMode.Impulse);
            }
        
         }
    }


    bool ReadyToJump()
    {
        return Physics.Raycast(transform.position,Vector3.down, 1);
    }
}
