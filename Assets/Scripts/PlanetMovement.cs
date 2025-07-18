using UnityEngine;

public class MoveLeft : MonoBehaviour
  
{

    public float speed = 5f;
    private Rigidbody2D rb; 
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(-speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
