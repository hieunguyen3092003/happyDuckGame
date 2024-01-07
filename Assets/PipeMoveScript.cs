using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;

    public float deleteZone = -100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;


        if (transform.position.x < deleteZone)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
         
    }
}
