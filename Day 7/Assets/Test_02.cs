using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

//�ݺ���
//for��
//for(�ʱ��; ���ǽ�; ������)
//{
//  �ݺ��� �ڵ�
//
//}





public class Test_02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int num = 1;
        //Debug.Log(num);
        //num =2;
        //Debug.Log(num);
        //1���� 100���� ���� ����غ���

    //     for(int i = 1; i <= 100; i++)     
    //         Debug.Log(i);
       
        //for���� ���� a������ ��ȭ���� 0~99.
        //�ݺ�Ƚ���� 100��
        for(int a = 0; a< 100; a++)
        {
            Debug.Log(a);
        }
        //output:012

        //for������ 10~1  �ݺ�Ƚ��:10��
        for(int xx = 10 ; xx >0 ; xx--)
        { 
            Debug.Log(xx); 
        }

        Debug.Log("������ 7��");
        for(int ii= 0; ii< 10; ii++) 
        {
            Debug.Log("7 * "+ ii +"="+ (7 * ii));
        
        }
        //output 7�� 1~9���ϱ�

        //���� for��
        Debug.Log("<������ 2~9�� ���>");
        for(int a_Dan=2 ; a_Dan<10; a_Dan++)    
        {
            Debug.Log("<������"+a_Dan+"��>");
            for (int idx = 1; idx < 10; idx++)
            {
                Debug.Log(a_Dan + "*" + idx + "=" + (a_Dan * idx));
            }
            Debug.Log("------");
        }
        //while
        //while(���ǽ�)
        //{
        //  �ݺ��ڵ�
        //}

        //while��
        int a_bb = 1;
        while (a_bb <= 10)
        {
            Debug.Log("a_bb :" + a_bb);
            a_bb++;
        }
        //for������ ����

        for(int bb =1;bb <= 10; bb++)
        {
            Debug.Log("bb : " + bb);
        }

        //do-while
        int a_kk = 10;
        while (20 < a_kk) 
        {
            Debug.Log("while�� a_kk = " + a_kk);
        }

        a_kk = 10;
        do
        {
            Debug.Log("do-while a_kk = " + a_kk);
            a_kk++;

        } while (20 < a_kk);

        //------WHILE ����

        int AAA = -1;
        AAA = Random.Range(1, 10);

        int BBB = -1;
        BBB = AAA;
        while (AAA ==BBB)
        {
            BBB = Random.Range(1, 10);
        }
        Debug.Log(AAA + " : " + BBB);
        //aaa ������ ���� bbb ������ ���� �ٸ��� �������� ����ȭ ���ֽÿ�.

        //���� ����
        int ABC = 0;

       while(true)
        {
            ABC++;

            if ((ABC % 2) == 0)
                continue;    //������ġ�� ���ư���� Ű���� (for�� ���밡��)
            if (10 < ABC) 
                break;         //��� ���������� Ű����

            Debug.Log("���ѷ��� �׽�Ʈ :" + ABC);
        }

        ABC = 0;
        for (; ;)
        {
            ABC++;

            if ((ABC % 2) == 0)

                continue; //for�� ������ġ�� ���ư���� Ű����
            if(10 < ABC)

                break;  //��� ����������� Ű����

            Debug.Log("for�� ���ѷ��� :" + ABC);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
