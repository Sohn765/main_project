using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Randomeffect : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[0];
    SpriteRenderer src;
    public RandomBox box;
    public GameObject player,point0 ,point1,point2,point3,point5,point6,gpdl,camera1,nokey;
    public int keyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        src = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clickbox()
    {
        StartCoroutine(randomEffect());
    }
    public IEnumerator randomEffect()
    {
        int i =0;
        int a = 0;
        while (i < 36)
        {

            print(a);
            yield return new WaitForSeconds(0.05f);
            src.sprite = sprites[a];
            if (a >= 9) a = 0;
            a++;
            i++;
        }
        src.sprite = sprites[box.dlswk];
        yield return new WaitForSeconds(1f);
        if (box.dlswk == 0)
        {
            if (keyCount != 0)
            {
                nokey.SetActive(true);
            }
            else
            {
                point0.SetActive(true);
                keyCount++;
            }
            
       
        }
        else if (box.dlswk == 1)
        {
            player.transform.position = point1.transform.position;
        }
        else if (box.dlswk == 2)
        {
            player.transform.position = point2.transform.position;
        }
        else if (box.dlswk == 3)
        {
            player.transform.position = point3.transform.position;
        }
        else if (box.dlswk == 4)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(8);
        }
        else if (box.dlswk == 5)
        {
            point5.SetActive(true);
            yield return new WaitForSeconds(2f);
            point5.SetActive(false);
        }
        else if (box.dlswk == 6)
        {
            gpdl.SetActive(true);
            camera1.SetActive(false);
            player.transform.position = point6.transform.position;
        }
        yield return new WaitForSeconds(1f);
        box.box.SetActive(true);
        box.eft.SetActive(false);
    }
}
