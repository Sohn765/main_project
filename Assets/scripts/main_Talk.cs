using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_Talk : MonoBehaviour
{
    public Text Text;
    public int talkcount;
    public move main;
    // Start is called before the first frame update
    void Start()
    {
        talkcount = 0;
        Text.text = "��? �ȳ� ������";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (talkcount == 0)
        {
            Text.text = "���� ��¾���̾�?";
            talkcount++;
        }
        else if (talkcount == 1)
        {
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "�ƴ� ����������Ʈ �����͸� �ôµ� �����ұ� �ؼ�";
            talkcount++;
        }
        else if (talkcount == 2)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "����������Ʈ?";
            talkcount++;
        }
        else if (talkcount == 3)
        {
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "�� ���� ��ȹ�� ������ �ִµ� �ϰ� �ڵ��� �¾����� ��!";
            talkcount++;
        }
        else if (talkcount == 4)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "��.. ������ ������ ��� ������ �־�!";
            talkcount++;
        }
        else if (talkcount == 5)
        {
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "����?";
            talkcount++;
        }
        else if (talkcount == 6)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "ū�� �ƴѵ� ���� ������ ���� ������ ���������� ��!";
            talkcount++;
        }
        else if (talkcount == 7)
        {
            main.boy.SetActive(true);
            main.girl.SetActive(false);
            Text.text = "�׷��Ŷ�� �󸶵��� ������ ��� �־�?";
            talkcount++;
        }
        else if (talkcount == 8)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(true);
            Text.text = "�� ���� �ִ� ��ǻ�� �־�";
            talkcount++;
        }
        else if (talkcount == 9)
        {
            main.boy.SetActive(false);
            main.girl.SetActive(false);
            main.mainTalk.SetActive(false);
            main.talkmgr.SetActive(false);
            main.talkend = 1;
        }

    }

}
