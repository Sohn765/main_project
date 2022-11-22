using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talkmgr : MonoBehaviour
{
    // Start is called before the first frame update
    public Text talk;
    public OP2_mgr mv;
    public int talkcount;
    public AudioSource talksource;
    public OP2_mgr oP2_Mgr;
    void Start()
    {
        talkcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if(talkcount == 0)
        {
            talksource.Play();
            mv.show.SetActive(false);
            mv.talkmgr.SetActive(false);
            mv.speedX = 3;
            talkcount++;
            oP2_Mgr.audioSource.Play();
        }
        else if (talkcount == 1)
        {
            talksource.Play();
            mv.show.SetActive(false);
            mv.talkmgr.SetActive(false);
            mv.speedX = mv.rb.velocity.x;
            mv.speedY = 1;
            talkcount++;
            oP2_Mgr.audioSource.Play();
        }
        else if (talkcount == 2)
        {
            talksource.Play();
            talk.text = "나도 친구들 모아서 신청해야겠다";
            talkcount++;
        }

        else if (talkcount == 3)
        {
            talksource.Play();
            talk.text = "*한 번 더 버튼을 누르면 게임이 시작됩니다*";
            talkcount++;
        }
        else if (talkcount == 4)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }


    }

}
