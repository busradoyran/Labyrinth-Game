using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 45 * Time.deltaTime, 0);
            //transform.Translate(5 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -45 * Time.deltaTime, 0);
            //transform.Translate(-5 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, 10 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -10 * Time.deltaTime);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
