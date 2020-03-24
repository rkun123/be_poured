using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour
{
    private int step = 0;
    public GameObject milkTutorial;
    public GameObject mugTutorial;
    public GameObject gameTutorial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Step " + step);
        switch(step) {
            case 0:
                mugTutorial.SetActive(false);
                milkTutorial.SetActive(true);
                gameTutorial.SetActive(false);
                checkMilkTutorialFinished();
                break;
            case 1:
                mugTutorial.SetActive(true);
                milkTutorial.SetActive(false);
                gameTutorial.SetActive(false);
                checkMugTutorialFinished();
                break;
            case 2:
                mugTutorial.SetActive(false);
                milkTutorial.SetActive(false);
                gameTutorial.SetActive(true);
                checkGameTutorialFinished();
                break;
            
        }
        
    }

    void checkMilkTutorialFinished(){
        if(Input.GetKeyDown(KeyCode.Space)) step = 1;
    }
    void checkMugTutorialFinished(){
        if(Input.GetKeyDown(KeyCode.Space)) step = 2;
    }
    void checkGameTutorialFinished(){
        if(Input.GetKeyDown(KeyCode.Space)) SceneManager.LoadScene("scenes/Main");
    }


}
