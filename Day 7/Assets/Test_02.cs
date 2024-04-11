using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

//반복문
//for문
//for(초기식; 조건식; 증감식)
//{
//  반복될 코드
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
        //1부터 100까지 값을 출력해보자

    //     for(int i = 1; i <= 100; i++)     
    //         Debug.Log(i);
       
        //for문안 에서 a변수의 변화값은 0~99.
        //반복횟수는 100번
        for(int a = 0; a< 100; a++)
        {
            Debug.Log(a);
        }
        //output:012

        //for문에서 10~1  반복횟수:10번
        for(int xx = 10 ; xx >0 ; xx--)
        { 
            Debug.Log(xx); 
        }

        Debug.Log("구구단 7단");
        for(int ii= 0; ii< 10; ii++) 
        {
            Debug.Log("7 * "+ ii +"="+ (7 * ii));
        
        }
        //output 7단 1~9곱하기

        //이중 for문
        Debug.Log("<구구단 2~9단 출력>");
        for(int a_Dan=2 ; a_Dan<10; a_Dan++)    
        {
            Debug.Log("<구구단"+a_Dan+"단>");
            for (int idx = 1; idx < 10; idx++)
            {
                Debug.Log(a_Dan + "*" + idx + "=" + (a_Dan * idx));
            }
            Debug.Log("------");
        }
        //while
        //while(조건식)
        //{
        //  반복코드
        //}

        //while문
        int a_bb = 1;
        while (a_bb <= 10)
        {
            Debug.Log("a_bb :" + a_bb);
            a_bb++;
        }
        //for문으로 변경

        for(int bb =1;bb <= 10; bb++)
        {
            Debug.Log("bb : " + bb);
        }

        //do-while
        int a_kk = 10;
        while (20 < a_kk) 
        {
            Debug.Log("while문 a_kk = " + a_kk);
        }

        a_kk = 10;
        do
        {
            Debug.Log("do-while a_kk = " + a_kk);
            a_kk++;

        } while (20 < a_kk);

        //------WHILE 예시

        int AAA = -1;
        AAA = Random.Range(1, 10);

        int BBB = -1;
        BBB = AAA;
        while (AAA ==BBB)
        {
            BBB = Random.Range(1, 10);
        }
        Debug.Log(AAA + " : " + BBB);
        //aaa 변수의 값과 bbb 변수의 값이 다르게 나오도록 구현화 해주시오.

        //무한 루프
        int ABC = 0;

       while(true)
        {
            ABC++;

            if ((ABC % 2) == 0)
                continue;    //시작위치로 돌아가라는 키워드 (for문 응용가능)
            if (10 < ABC) 
                break;         //즉시 빠져나가는 키워드

            Debug.Log("무한루프 테스트 :" + ABC);
        }

        ABC = 0;
        for (; ;)
        {
            ABC++;

            if ((ABC % 2) == 0)

                continue; //for문 시작위치로 돌아가라는 키워드
            if(10 < ABC)

                break;  //즉시 빠져나가라는 키워드

            Debug.Log("for문 무한루프 :" + ABC);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
