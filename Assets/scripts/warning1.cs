using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning1 : MonoBehaviour
{
    // Start is called before the first frame update
    public warning warning;
    void Start()
    {
        warning.M.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        warning.W.SetActive(false);
    }
}
