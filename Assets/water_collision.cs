using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_collision : MonoBehaviour
{
    public GameObject playerObj;
    private ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleTrigger() {
        List<ParticleSystem.Particle> enteredParticles = new List<ParticleSystem.Particle>();
        int numOfEnter = particleSystem.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enteredParticles);
        player_controller player = playerObj.GetComponent<player_controller>();
        Debug.Log("Entered " + numOfEnter + " milk particles.");
        player.addMilkParticles(numOfEnter);
    }
}
