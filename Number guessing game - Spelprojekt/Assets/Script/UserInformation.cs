using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInformation : MonoBehaviour {

    public void ChangeText(string textToDisplay){ // Ändrar texten i displayen
        GetComponent<Text>().text = textToDisplay; 
    }
    
   // void Start() {
     //   ChangeText("Hejsan") ;

    //}

   
}
