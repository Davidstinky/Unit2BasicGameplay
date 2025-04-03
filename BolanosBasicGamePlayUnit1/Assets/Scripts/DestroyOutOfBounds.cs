using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topbound = 40;
    private float lowerbound = -40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topbound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerbound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
