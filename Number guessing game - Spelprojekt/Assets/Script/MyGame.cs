using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGame : MonoBehaviour
{
    [SerializeField] GameObject myGuessText;
    int max = 1000;
    int min = 1;
    int guess = 500;

    void Start() {
        max = max + 1;
        MakeGuess();
    
    }

    void UpdateGuesstext() {
     myGuessText.GetComponent<Text>().text = "This is my guess: " + guess;
    }

    void MakeGuess() {
        guess = Random.Range(min, max);
        UpdateGuesstext();
    }

    public void Lower() {
        max = guess - 1;
        MakeGuess();
        
    }
        
    public void Higher() {
        min = guess + 1;
        MakeGuess();
    }

  
    
/*void Update(){


        if(Input.GetKeyDown("up")){
        min = guess; guess = (max+min)/2;
        Debug.Log("Is your number"+guess+"?");
        }
        
     if(Input.GetKeyDown("down")){
            max = guess; guess =(max+min)/2;
            Debug.Log("Is your number "+guess+"?");
     }

    }
   */ 
}
