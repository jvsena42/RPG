using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{

    public Text dialogText;
    public Text nameText;
    public GameObject dialogBox;
    public GameObject nameBox;

    private string[] dialogLines = {"This", "is", "a", "test"};

    private int currentLine=0 ;

    // Start is called before the first frame update
    void Start()
    {   
        dialogText.text = dialogLines[0];
    }

    // Update is called once per frame
    void Update()
    {
        //only show the text if the dialog is opened
        if(dialogBox.activeInHierarchy){
            //When the button is released by the player
            if (Input.GetButtonUp("Fire1"))
            {
                currentLine++;

                //Check the end of the array
                if (currentLine>=dialogLines.Length)
                {
                    currentLine = 0;
                    dialogBox.SetActive(false);
                }else
                {
                    dialogText.text = dialogLines[currentLine];
                }
                
            }
        }
    }
}
