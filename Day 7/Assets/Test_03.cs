using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

//�迭
//������ ������ ��Ƴ��� ����

//value type ���� :int float,double.....struct(����ü)
//Reference type ����:array, c lass ��ü


public class Test_03 : MonoBehaviour
{
    //����Ƽ���� �迭�� ��������� �����ؼ� ����ϴ� 2���� ���
    int[] m_Brr = new int[5]; //<--��� �迭 ���� 1��° ���
    public int[] Crr; //����迭 ���� 2��° ��뿹��


    // Start is called before the first frame update
    void Start()
    {
        //int AA0=0
        //  , AA1=0
        //  , AA2=0

        //int[] arr = new int[100]; //c#�迭 ���� ����

        int[] arr = new int [5]; //�������� �ϳ� �� ���� �ε����� ���� ����
        arr[0] = 10;
        arr[1] = 11;
        arr[2] = 12;
        arr[3] = 13;
        arr[4] = 14;   //---5���� �̰� 
      //arr[5] = 15; ----���� �������� ������ �߻��Ҽ�����(out of range ���)

        for(int ii = 0; ii < 5; ii++)
        {
            Debug.Log(arr[ii]);

        }
        Debug.Log("arr ũ�� :" + arr.Length); //��:������ ���������� �˰��� �Ҷ��� �±��� �������� �����ü��ִ�.

        //+ ��� ���� 1��° ��� ��

        m_Brr[0] = 11;
        m_Brr[1] = 12;
        m_Brr[2] = 13;
        m_Brr[3] = 14;
        m_Brr[4] = 15;
        for(int ii = 0;ii < m_Brr.Length; ii++)
        {
            Debug.Log("m_Brr [" + ii + "]:" + m_Brr[ii]);
        }

        //��� �迭 ���� 2��° ���

        for (int ii = 0;ii< Crr.Length; ii++)
        {
            Debug.Log("Crr[" + ii + "] : " + Crr[ii]);
        }

        //�ڵ带 ���������ʰ� �Է��Ҽ�����(����);��ȹ�ڿ��� �����ٶ� �� �������� ���鶧 �����ϴ� ���� �ִ�.
        //������ �߿亯���� �ۺ����� �߱⿡ �ٸ� �̵��� �����Ҽ������� ����� �ڵ�� �����ִ�.



        //����� ����

        int[] a_AAA = new int[10];
        int[] a_BBB;
        a_BBB = new int[10];
        a_BBB[0] = 11;
        for (int ii = 0; ii < a_AAA.Length; ii++)
        {
            Debug.Log(a_AAA[ii]);
        }
        //����Ƽ������ �迭�� ������ �ʱ� ���� ���������� 0���� �ʱ�ȭ

        //�Ͻ��� ����
        int[] a_CCC = { 10, 20, 30, 40, 50, 60 }; //����ó�� ������ �����ʾƵ� �ʱ�ȭ ��.
        for (int ii = 0; ii < a_CCC.Length; ii++) 
        { 
        Debug.Log(a_CCC[ii]);
        }

        //int[] a_XXX;
        //a_XXX { 11,22,33,44}; //�Ͻ��� ������ ����� ���ÿ� �ʱ�ȭ �������.(������ ������ ����)_

        //���+�Ͻ�

        int[] a_EEE = new int[] { 10, 20, 30, 40 , 50 , 60 };
        int[] a_FFF;
        a_FFF = new int[] { 11, 12, 13, 14, 15 };
        for(int ii = 0; ii< a_FFF.Length; ii++)
        {
            Debug.Log(a_FFF[ii]);
        }

        //float���� �迭
        float[] farr = new float[3];
        farr[0] = 1.0f;
        farr[1] = 2.34f;
        farr[2] = 3.14f;
        for(int ii = 0; ii < farr.Length ; ii++) 
        {
            Debug.Log("farr(" + ii + "]" + farr[ii]);
        }

        int AAAA = 1000;
        int BBBBB = AAAA; //�Ϲ� �������� ���� ����ȴٴ� �濡�� value type�̴�.

        BBBBB = 99;
        Debug.Log("AAAA : " + AAAA + ",BBBBB : " + BBBBB);

        int[] CCCCC = { 1000 };
        int[] DDDDD = CCCCC;  //�迭������ ���� ��������� �����Ѵٴ� �濡�� REFERENCE TYPE�̶� ��.
        int[] EEEEE = CCCCC;
        DDDDD[0] = 99;
        Debug.Log("CCCCC" + CCCCC[0] + ",DDDDD[0]:" + DDDDD[0] 
            + "EEEEE[0]:" + EEEEE[0]);

        int[] ZZZ = new int[3]; //new int [3](�迭�ȿ� int 4byte 3���� ����)------>int ZZZ
        ZZZ[0] = 10;
        ZZZ[1] = 11;
        ZZZ[2] = 12;

        ZZZ = new int[5];//����  int�� 5���� ���� ��Ű�� ��ǻ�Ϳ��� ���--->�� �� zzz�� �ٽ� ���Խ��״µ�
                         //������ ������ �迭 3�� �������� 5���� int�� ������ ��
        ZZZ[3] = 999;
        ZZZ[4] = 9999;

        for(int ii = 0;ii < ZZZ.Length ; ii++)
        {
            Debug.Log("ZZZ["+ii+"]:" + ZZZ[ii]);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
