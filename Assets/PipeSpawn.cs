using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject Pipe;
    private float spawnRate = 5;
    private float Timer = 0;
    private float Offset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < spawnRate)
        {
            Timer += Time.deltaTime;
        }
        else 
        {
            spawnPipe();
            Timer = 0;
        }
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - Offset;
        float highestPoint = transform.position.y + Offset;

        Instantiate(Pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
