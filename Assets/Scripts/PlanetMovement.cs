using UnityEngine;

public class MoveLeft : MonoBehaviour
  
{

    public float maxspeed = 25f;
    public float minspeed = 1f;
    public float speed = 10f; // Speed of the planet
    public Rigidbody2D planet1; 
    public float offscreenx = -25; // x position where the planet is considered offscreen
    public float[] yrange = { -3, -1, 1, 3 };// possib y positions for the planet


                            // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        planet1 = GetComponent<Rigidbody2D>();
        planet1.linearVelocity = new Vector2(-speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (planet1.position.x < offscreenx)
        {             // Reset the planet's position to the right side of the screen
            planet1.position = new Vector2(15, Random.Range(0,yrange.Length));
            planet1.linearVelocity = new Vector2(-speed, 0);
        }
       
    }
}
