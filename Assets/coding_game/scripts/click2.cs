using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click2 : MonoBehaviour
{
    public GameObject player,GameObject,camera2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        player.transform.position = GameObject.transform.position; 
        camera2.SetActive(true);
    }
}
