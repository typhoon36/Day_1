using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.�Ʒ��� ���� �迭�� ������ 222���� �� ��° �ε����� �մ���?
        //�ε����� ã�� �ڵ带 �ۼ��ϰ� �ε����� ������ּ���
        int[] App = { 34, 56, 12, 89, 120, 6, 8, 222, 67, 81, 110 };

        List<int> list = new List<int>() { 34, 56, 12, 89, 120, 6, 8, 222, 67, 81, 110 }; //���ο� ����Ʈ ����

        int indexA = list.LastIndexOf(222); //����Ʈ �� ã����

        Debug.Log("222����"+indexA+"�� �ִ�!"); //���




        //2. �Ʒ��� ���� �迭�� ������ 33�̶�� ���� ���° �ε����� �ִ°�?
        //��,99��� ���� ��� �ε����� �ִ°�?
        //�ۼ��ϰ� �ε����� ������ּ���.
        int a_idx = 0;

        int[] VVV = new int[100];

        for (int ii = 0; ii<100; ii++)
        {
            if ((ii % 3)==0)
            {
                VVV[a_idx]=ii;
                a_idx++;
            }
        }

        for (int ii = 0; ii< VVV.Length; ii++)
        {
            if (VVV[ii] == 33)
            {
                Debug.Log("33�� �ε��� ���� : "+ii);
            }
            if (VVV[ii] == 99)
            {
                Debug.Log("99�� �ε��� ���� :" + ii);
            }
        }

        //3.�Ʒ��� ���� �迭�� ������ �Ʒ� ����� ���� ���� �� ����Ͻÿ�

        int[] ZZZ = new int[100];
        for (int ii = 0; ii <100; ii++)
        {
            ZZZ[ii]=ii;

            Debug.Log(ZZZ[ii]);
        }

        int[] a_rr = new int[50];

        int a_rrIdx = 0;
        for (int j = 0; j<ZZZ.Length; j +=2)
        {
            a_rr[a_rrIdx] = ZZZ[j]+ZZZ[j+1];
            Debug.Log("a_rr[" + a_rrIdx + "]:" + a_rr[a_rrIdx]);
            a_rrIdx++;
        }


        //����
        //a_rr[0]=ZZZ[0] + ZZZ[1];
        //a_rr[0]=ZZZ[2] + ZZZ[3];
        //a_rr[0]=ZZZ[4] + ZZZ[5];
        //a_rr[0]=ZZZ[6] + ZZZ[7];
        //:
        //a_rr[??]=ZZZ[98] + ZZZ[99];

        //��� ��� for������ a_rr �迭 ��� ��
        //a_rr[0]:1
        //a_rr[0]:5
        //a_rr[0]:9
        // :

        //4, �ִ밪, �ּҰ� ���ϱ�...

        int[] a_kk = { 23, 45, 12, 67, 34, 77, 103, 3, 6, 7, 9, 11, 65, 204, 33, 56 };

        //for���� ���鼭 �ִ밪�� �ּҰ��� ���ϰ� �ִ밪�� �ε����� �ּҰ��� �ε����� ���� ����� �ּ���.
        //��� ���� : " �ִ밪 : ?? (�ε��� ??), �ּҰ� : ?? (�ε��� ??) "

        int max = int.MinValue;
        int min = int.MaxValue;
        int minidx = 0;
        int maxidx = 0;

        for (int i = 1; i< a_kk.Length; i++)
        {
            if (a_kk[i]>max) //�ִ밪
            {
                max = a_kk[i];
                maxidx=a_kk[i];

            }

            if (min > a_kk[i]) //�ּҰ�
            {
                min = a_kk[i];
                minidx=a_kk[i];
            }
        }

        Debug.Log("�ִ밪 : "+ max +"(�ε���"+ maxidx +")");
        Debug.Log("�ּҰ� : "+ min +"(�ε���"+ minidx +")");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
