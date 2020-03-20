using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    SceneManager sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        sceneManager = new SceneManager();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Load Main scene");
            SceneManager.LoadScene("Scenes/Main");
        }
    }
}
