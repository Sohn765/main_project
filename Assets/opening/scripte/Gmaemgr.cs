using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gmaemgr : MonoBehaviour
{
    public Text talkText;
    public OP_playerMove move;
    public GameObject zz;
    public int clickcount,playSound, speed;
    public AudioSource bellsound,clicksound, AudioSource;
    void Start()
    {
        clickcount = 0;
        playSound = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!bellsound.isPlaying && playSound == 0)
        {
            setactive();
        }
    }
    void setactive()
    {
        AudioSource.Stop();
        zz.SetActive(true);
        talkText.text = "아... 내일 점심은 먹을 게 없네 자판기나 가야겠다";
        clickcount++;
        playSound++;
    }
    private void OnMouseDown()
    {

        if (clickcount == 1)
        {
            
            AudioSource.Play();
            clicksound.Play();
            zz.SetActive(false);
            move.moveY = -1;
        }
        
    }
}
