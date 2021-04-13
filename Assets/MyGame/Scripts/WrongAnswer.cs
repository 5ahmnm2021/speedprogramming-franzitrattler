using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrongAnswer : MonoBehaviour
{
    public Button wrongButton1;
    public Button wrongButton2;

    public void OnBUttonClick1()
    {
        wrongButton1.image.color = new Color (255, 0, 0); 
    }

    public void OnBUttonClick2()
    {
        wrongButton2.image.color = new Color(255, 0, 0);
    }
}
