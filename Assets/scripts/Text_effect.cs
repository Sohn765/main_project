using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_effect : MonoBehaviour
{
    public int charperSecondes;
    string targetmsg;
    public GameObject endCursor;
    Text Text;
    int index;
    private void Awake()
    {
        Text = GetComponent<Text>();
    }
    public void setmsg(string msg)
    {
        targetmsg = msg;
        EffectStart();
    }

    void EffectStart()
    {

        Text.text = "";
        index = 0;
        endCursor.SetActive(false); 
        Invoke("Effectting", 1 / charperSecondes);


    }

    void Effectting()
    {
        if (Text.text == targetmsg)
        {
            EffecttEnd();
            return;
        }
        Text.text += targetmsg[index];
        index++;
        Invoke("Effectting", 1 / charperSecondes);

    }
    void EffecttEnd()
    {
        endCursor.SetActive(true);
    }
}
