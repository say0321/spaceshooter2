using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -speed*Time.deltaTime,Space.World);
        transform.Rotate(1, 1, 1);
        if (transform.position.z < -30.0f) {
            Destroy(gameObject);
        }
    }
}
