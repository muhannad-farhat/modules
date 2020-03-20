using UnityEngine;
public class move2 : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jumpForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }


    void FixedUpdate()
    {
        if (Input.GetKey("w"))
            rb.AddForce(-10 * speed * Time.deltaTime, 0, 0);
        if (Input.GetKey("s"))
            rb.AddForce(10 * speed * Time.deltaTime, 0, 0);
        if (Input.GetKey("a"))
            rb.AddForce(0, 0, -10 * speed * Time.deltaTime);
        if (Input.GetKey("d"))
            rb.AddForce(0, 0, 10 * speed * Time.deltaTime);

        jump();
    }

    void jump()
    {

        if (ReadyToJump())
        {

            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(0, 10 * jumpForce * Time.deltaTime, 0, ForceMode.Impulse);
            }

        }
    }


    bool ReadyToJump()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1);
    }
}
