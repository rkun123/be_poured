﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_controller : MonoBehaviour
{
    public int score;
    float scoreMax = 1000.0f;
    public GameObject imageTarget;
    public Image progressBar;
    public Text scoreText;
    public float xRange = 10;
    private position_emitter positionEmitter;
    private float xLeftLimit = 0, xRightLimit = 0;
    private float xScale = 1, xOffset = 0;
    // Start is called before the first frame update
    void Start()
    {
        positionEmitter = imageTarget.GetComponent<position_emitter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x(), transform.position.y, transform.position.z);
        Debug.Log("Pos: "+transform.position);
    }

    float x(){
        if(positionEmitter.transform.position.x < xLeftLimit) xLeftLimit = positionEmitter.transform.position.x;
        if(positionEmitter.transform.position.x > xRightLimit) xRightLimit = positionEmitter.transform.position.x;
        xScale = 20 / (xRightLimit - xLeftLimit);
        xOffset = (xLeftLimit + xRightLimit) / 2;
        float x = (positionEmitter.transform.position.x - xOffset) * xScale;

        Debug.Log("xLeftLimit:"+xLeftLimit);
        Debug.Log("xRightLimit:"+xRightLimit);
        Debug.Log("x_offset:"+xOffset);
        Debug.Log("x_scale:"+xScale);
        Debug.Log("x:"+positionEmitter.transform.position.x);
        Debug.Log("Mug.x:"+x);
        return x;
    }

    public void onCollisionByWater() {
        if(score < scoreMax) score++;
        Debug.Log("Score: " + score);
        RectTransform rectTransform = progressBar.GetComponent<RectTransform>();
        rectTransform.localScale = new Vector3(1, score/scoreMax, 1);
        scoreText.text = Mathf.Round(score / scoreMax * 100).ToString() + "%";


    }
}