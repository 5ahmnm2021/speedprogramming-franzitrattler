using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int counter;
    public Text answerText;
    public GameObject otherGameobject; 

    void Update()
    {
        sceneSwitch = GetComponent<SceneSwich>.counter; 
        if (counter == 2)
        {
            answerText.text = "alles richtig";
        }
        if (counter == 1)
        {
            answerText.text = "1 Frage richtig";
        }
        if (counter == 0)
        {
            answerText.text = "0 Fragen richtig"; 
        }

    }
}
