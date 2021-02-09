using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_Chan_playercontroller : MonoBehaviour
{
    float speed = 99.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (transform.position.x <= -55)
        {
            transform.position += new Vector3(104, 0, 0);
        }

        if (transform.position.x >= 55)
        {
            transform.position += new Vector3(-104, 0, 0);
        }
    }
}
