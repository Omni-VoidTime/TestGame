using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveSpeed = 5;
    private float Deadzone = -45;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < Deadzone) 
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
