using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yap : MonoBehaviour
{
    public GameObject block;

    private void OnCollisionEnter2D(Collision2D collision)

    {
        Destroy (block);
        StartCoroutine("exit");
        print("Ri");
 }

    public IEnumerator exit()
    {
        yield return new WaitForSeconds(0.1f);
        print("RIdk");
        block.SetActive(true);
    }







}
  

