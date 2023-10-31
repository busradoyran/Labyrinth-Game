using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; // A reference to our PlayerMovement script.

    // This funciton runs when we hit another object.
    // We get information about the collision and call it "collisionInfo".

    public float speed = 0.0001f;
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Wall")
        {
            if (Input.GetKey("d"))
            {
                transform.Translate(-5 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("a"))
            {
                transform.Translate(5 * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("w"))
            {
                transform.Translate(0, 0, -5 * Time.deltaTime);
            }
            if (Input.GetKey("s"))
            {
                transform.Translate(0, 0, 5 * Time.deltaTime);
            }

            // We check if the object we collided with has a tag called "Wall".

            Debug.Log("We hit a wall.");
            movement.enabled = false;   // Disable the players movement.
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}