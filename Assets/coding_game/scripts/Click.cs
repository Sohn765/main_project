using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cut;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setout()
    {
        print("��");
        cut.gameObject.SetActive(false);
    }
}
