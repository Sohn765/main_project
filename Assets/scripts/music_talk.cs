using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class music_talk : MonoBehaviour
{
    public Text Text;
    public int talkcount;
    public move main;
    public BoxCollider2D girlgirl;
    public AudioSource AudioSource;
    public test talk;


    // Start is called before the first frame update
    private void Start()
    {
        Text.text = "������ �ȳ�";
        talkcount = 0;
    }

    private void OnMouseDown()
    {
        if (main.maintalkCount == 1 && talkcount == 0)
        {
            AudioSource.Play();
            Text.text = "���ǽ��� �� �Ϸ� �Ծ�?";
            talkcount++;
        }
        else if (talkcount == 1)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.boy1.SetActive(false);
            Text.text = "������ ������µ� ���尡 �ʿ���";
            talkcount++;
        }
        else if (talkcount == 2)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.boy1.SetActive(true);
            Text.text = "����? ���ڱ�?";
            talkcount++;
        }
        else if (talkcount == 3)
        {

            AudioSource.Play();
            main.boy.SetActive(true);
            main.boy1.SetActive(false);
            Text.text = "�� �б����� ���� ������Ʈ�� �ϴ����";
            talkcount++;
        }
        else if (talkcount == 4)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.boy1.SetActive(true);
            Text.text = "��... ���� �־�� ��?";
            talkcount++;
        }
        else if (talkcount == 5)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.boy1.SetActive(false);
            Text.text = "�� �װ� �ʿ���";
            talkcount++;
        }
        else if (talkcount == 6)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.boy1.SetActive(true);
            Text.text = "�˾Ҿ� �׷� ���� �� ������";
            talkcount++;
        }
        else if (talkcount == 7)
        {
            AudioSource.Play();
            main.boy.SetActive(true);
            main.boy1.SetActive(false);
            Text.text = "�� ���� ��?";
            talkcount++;
        }
        else if (talkcount == 8)
        {
            AudioSource.Play();
            main.boy.SetActive(false);
            main.boy1.SetActive(true);
            Text.text = "�ֵ����� ��Ź���� ������ �ִµ� �װ� ���� �� �ٰ�";
            talkcount++;
        }
        else if (talkcount == 9)
        {
            main.boy.SetActive(false);
            main.boy1.SetActive(false);
            main.mainTalk.SetActive(false);
            main.talkmgr.SetActive(false);
            main.talkend = 1;
            girlgirl.isTrigger = true;
        }

        if (main.npcCount == 1)
        {
            main.npc_Talk.SetActive(false);
            main.talkmgr.SetActive(false);
            main.npcCount--;
        }

        if (main.npcCount1 == 1)
        {
            main.npc_Talk1.SetActive(false);
            main.talkmgr.SetActive(false);
            main.npcCount1 -= 1;
        }
    }
}

