using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.아래와 같은 배열이 있을때 222값은 몇 번째 인덱스에 잇는지?
        //인덱스를 찾는 코드를 작성하고 인덱스를 출력해주세요
        int[] App = { 34, 56, 12, 89, 120, 6, 8, 222, 67, 81, 110 };

        List<int> list = new List<int>() { 34, 56, 12, 89, 120, 6, 8, 222, 67, 81, 110 }; //새로운 리스트 생성

        int indexA = list.LastIndexOf(222); //리스트 안 찾기기능

        Debug.Log("222값은"+indexA+"에 있다!"); //출력




        //2. 아래와 같은 배열이 있을때 33이라는 값은 몇번째 인덱스에 있는가?
        //또,99라는 값은 몇번 인덱스에 있는가?
        //작성하고 인덱스를 출력해주세요.
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
                Debug.Log("33의 인덱스 값은 : "+ii);
            }
            if (VVV[ii] == 99)
            {
                Debug.Log("99의 인덱스 값은 :" + ii);
            }
        }

        //3.아래와 같은 배열이 있을때 아래 보기와 같은 연산 후 출력하시오

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


        //보기
        //a_rr[0]=ZZZ[0] + ZZZ[1];
        //a_rr[0]=ZZZ[2] + ZZZ[3];
        //a_rr[0]=ZZZ[4] + ZZZ[5];
        //a_rr[0]=ZZZ[6] + ZZZ[7];
        //:
        //a_rr[??]=ZZZ[98] + ZZZ[99];

        //결과 출력 for문으로 a_rr 배열 출력 예
        //a_rr[0]:1
        //a_rr[0]:5
        //a_rr[0]:9
        // :

        //4, 최대값, 최소값 구하기...

        int[] a_kk = { 23, 45, 12, 67, 34, 77, 103, 3, 6, 7, 9, 11, 65, 204, 33, 56 };

        //for문을 돌면서 최대값과 최소값을 구하고 최대값의 인덱스와 최소값의 인덱스를 같이 출력해 주세요.
        //출력 예시 : " 최대값 : ?? (인덱스 ??), 최소값 : ?? (인덱스 ??) "

        int max = int.MinValue;
        int min = int.MaxValue;
        int minidx = 0;
        int maxidx = 0;

        for (int i = 1; i< a_kk.Length; i++)
        {
            if (a_kk[i]>max) //최대값
            {
                max = a_kk[i];
                maxidx=a_kk[i];

            }

            if (min > a_kk[i]) //최소값
            {
                min = a_kk[i];
                minidx=a_kk[i];
            }
        }

        Debug.Log("최대값 : "+ max +"(인덱스"+ maxidx +")");
        Debug.Log("최소값 : "+ min +"(인덱스"+ minidx +")");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
