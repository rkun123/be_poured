using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position_emitter : MonoBehaviour
{
    private Vector3 preFramePosition;
    public Vector3 relative;
    // Start is called before the first frame update
    void Start()
    {
        preFramePosition = transform.position;
        relative = Vector3.zero;
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public Vector3 getPosition()
    {
        Vector3 relative = transform.position - preFramePosition;
        preFramePosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        return relative;
    }

    public Quaternion GetQuaternion()
    {
        return transform.rotation;
    }
}
