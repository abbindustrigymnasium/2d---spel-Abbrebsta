using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour{

    public void LoadScene(string SceneToLoad){
        Debug.Log("LoadScene: " + SceneToLoad);
        SceneManager.LoadScene(SceneToLoad);
    }


}
