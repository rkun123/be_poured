using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_collision : MonoBehaviour
{
    public int numOfCollisions = 0;
    public GameObject collisionTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject obj) {
        if(obj.Equals(collisionTarget)) numOfCollisions++;
        Debug.Log("Colisions: "+numOfCollisions);
        player_controller player = obj.GetComponentInParent<player_controller>();
        player.onCollisionByWater();

    }
}
