using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InstructionsToGame : MonoBehaviour{

    public Text messageText;
    

    int max = 1000;
    int min = 1;
    int guess = 500;

    void StartGame(){
    
        max = 1000;
        min = 1;
        guess = 500;
        
        
        Debug.Log("Welcome to the Guessing Game!"); 

        Debug.Log("Think of a number between "+min+" and "+max+""); 

        Debug.Log("Is the number that you are thinking of higher than, lower than, or exactly "+guess+"?"); 

        Debug.Log("If it's higer, press Up. If it's lower than, press Down, And if it's correct, press enter");

        max = max + 1;
    }
        
       
    
void Update(){
        if(Input.GetKeyDown("up")){
        min = guess; guess = (max+min)/2;
        Debug.Log("Is your number"+guess+"?");
        }
        
     if(Input.GetKeyDown("down")){
            max = guess; guess =(max+min)/2;
            Debug.Log("Is your number "+guess+"?");
     }

        if(Input.GetKeyDown("enter")){
            Debug.Log("Wohooo nice! I guessed correctly. Your number was "+guess+"!");
        }
    

    }
}
