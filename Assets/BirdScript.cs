using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private float flapStrength = 25;
    private LogicScript logic;
    private bool IsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InBounds();
        if (Input.GetKeyDown(KeyCode.Space) == true && IsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        
    }
    private void InBounds() 
    {
        if (transform.position.y < -20 || transform.position.y > 20) {
            IsAlive = false;
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        IsAlive = false;
    }
}
