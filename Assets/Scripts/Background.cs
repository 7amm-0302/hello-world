using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    private float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(transform.position.x, 10f, transform.position.z);
        }
    }
}
