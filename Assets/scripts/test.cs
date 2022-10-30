using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    public Text tx,main_tx;
    public string m_text;
    public move mv;
    public void game_text()
    {
        StartCoroutine(_typing());
    }

    // Update is called once per frame
    IEnumerator _typing()
    {
        for (int i = 0; i < m_text.Length; i++)
        {   

            tx.text = m_text.Substring(0, i);
            yield return new WaitForSeconds(0.08f);



        }
    }
}
