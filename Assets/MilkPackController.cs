using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkPackController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= -20) transform.Translate(Vector3.left * speed);
        if(Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 20) transform.Translate(Vector3.right * speed);
        if(Input.GetKey(KeyCode.UpArrow) && transform.position.z <= 20) transform.Translate(Vector3.forward * speed);
        if(Input.GetKey(KeyCode.DownArrow) && transform.position.z >= -20) transform.Translate(Vector3.back * speed);
    }
}
