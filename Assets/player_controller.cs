using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_controller : MonoBehaviour
{
    public int score;
    float scoreMax = 1000.0f;
    public GameObject imageTarget;
    public Image progressCircle;
    public Text scoreText;
    private position_emitter positionEmitter;
    private float xLeftLimit = 0, xRightLimit = 0;
    public float xScale = 1;
    private float xOffset = 10;
    private float zMin = 0, zMax = 0;
    public float zScale = 1;
    private float zOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        positionEmitter = imageTarget.GetComponent<position_emitter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-x(), transform.position.y, z() * 2);
        Debug.Log("Pos: "+transform.position);
    }

    float x(){
        if(positionEmitter.transform.position.x < xLeftLimit) xLeftLimit = positionEmitter.transform.position.x;
        if(positionEmitter.transform.position.x > xRightLimit) xRightLimit = positionEmitter.transform.position.x;
        xScale = 40 / (xRightLimit - xLeftLimit);
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

    float z(){
        if(positionEmitter.transform.position.z < zMax) zMax = positionEmitter.transform.position.z;
        if(positionEmitter.transform.position.z > zMin) zMin = positionEmitter.transform.position.z;
        zScale = 40 / (zMax - zMin);
        zOffset = (zMin + zMax) / 2;
        float z = (positionEmitter.transform.position.z - zOffset) * zScale;

        Debug.Log("zLeftLimit:"+xLeftLimit);
        Debug.Log("zRightLimit:"+xRightLimit);
        Debug.Log("z_offset:"+xOffset);
        Debug.Log("z_scale:"+xScale);
        Debug.Log("z:"+positionEmitter.transform.position.x);
        Debug.Log("Mug.z:"+z);
        return z;
    }
    public void onCollisionByWater() {
        if(score < scoreMax) score++;
        Debug.Log("Score: " + score);
        //RectTransform rectTransform = progressBar.GetComponent<RectTransform>();
        //rectTransform.localScale = new Vector3(1, score/scoreMax, 1);
        
        scoreText.text = Mathf.Round(score / scoreMax * 100).ToString() + "%";
        progressCircle.fillAmount = score / scoreMax;


    }

    public void addMilkParticles(int numOfParticles) {
        score += numOfParticles;
        if(score > scoreMax) score = (int)Mathf.Round(scoreMax);
        Debug.Log("Score: " + score);

        scoreText.text = Mathf.Round(score / scoreMax * 100).ToString() + "%";
        progressCircle.fillAmount = score / scoreMax;
    }
}
