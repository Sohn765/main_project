using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeOut : MonoBehaviour
{
    public Image Image;
    // Start is called before the first frame update
    void Start()
    {
        print("Èì");
        StartCoroutine(FadeCoroutine());
    }

    // Update is called once per frame
    IEnumerator FadeCoroutine()
    {
        print("dal");
        float fadeCount = 1;
        while (fadeCount > 0.0f)
        {
            fadeCount -= 0.01f;
            yield return new WaitForSeconds(0.01f);
            Image.color = new Color(0, 0, 0, fadeCount);
        }
    }

}
