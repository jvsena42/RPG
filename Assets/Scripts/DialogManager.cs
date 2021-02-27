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

    public string[] dialogLines;

    public int currentLine;
    private bool justStarted;

    //make a instance to access from dialog activator
    public static DialogManager instance;

    // Start is called before the first frame update
    void Start()
    {   
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //only show the text if the dialog is opened
        if(dialogBox.activeInHierarchy){
            //When the button is released by the player
            if (Input.GetButtonUp("Fire1"))
            {
                if (!justStarted)
                {
                    currentLine++;

                    //Check the end of the array
                    if (currentLine>=dialogLines.Length)
                    {
                        //currentLine = 0;
                        dialogBox.SetActive(false);
                    }else
                    {
                        dialogText.text = dialogLines[currentLine];
                    }
                }else
                {   
                    //when the player releases the button
                    justStarted = false;
                }
            }
            
        }
    }

    public void ShowDialog(string[] newLines){
        dialogLines = newLines;
        currentLine = 0;

        dialogText.text = dialogLines[0];
        dialogBox.SetActive(true);

        justStarted = true;
    }
}
