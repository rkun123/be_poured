using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject mug;
    player_controller mug_player;
    float startTime;
    float game_time;
    void Start()
    {
        startTime = Time.deltaTime;
        mug_player = mug.GetComponent<player_controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mug_player.score >= 100) {
            game_time = Time.deltaTime - startTime;
        }
    }
}
