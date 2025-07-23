using UnityEngine;

public class MoveLeft : MonoBehaviour
  
{


    public float speed = 10f; 
    public Rigidbody2D planet; 
    public float offScreenX = -20; // x position where the planet is considered offscreen
    public int spawnX = 15; // x position where the planet will respawn
    public int maxY = 5; 
    public int minY = -5; 



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        planet = GetComponent<Rigidbody2D>();
        planet.linearVelocity = new Vector2(-speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (planet.position.x < offScreenX)
        {             // Reset the planet's position to the right side of the screen
            planet.position = new Vector2(spawnX, Random.Range(maxY,minY));
    
        }
       
    }
}
