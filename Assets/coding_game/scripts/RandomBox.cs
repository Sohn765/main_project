using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject box,eft;
    public Randomeffect effect;
    public int dlswk;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        dlswk = Random.Range(0,6);
        box.SetActive(false);
        eft.SetActive(true);
        effect.Clickbox();
    }
}
