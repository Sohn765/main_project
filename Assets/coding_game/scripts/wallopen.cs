using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallopen : MonoBehaviour
{
    public GameObject wall, wall2,cut;
    public BoxCollider2D laver;
    public SpriteRenderer laver_sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void wallUp()
    {
        wall.SetActive(false);
        wall2.SetActive(false);
        cut.SetActive(false);
        laver_sr.flipX = true;
        laver.isTrigger = true;

    }
}
