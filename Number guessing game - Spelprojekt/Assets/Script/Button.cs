using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour{

string messageText;
    

    void SetStartTextOnButton(){
     
        UserInformation myUserInformation = FindObjectOfType<UserInformation>();
        
        messageText = "Think of a number between 1 and 1000" + "\n" + "I think I can guess it!" +
        "\n" + "Now decide what number you are going to think of and press start!";
        
        myUserInformation.ChangeText(messageText);

        // gameObject.SetActive(false); // false gömmer knappen, true visar knappen
        
     
        
        
    }

}
  
