using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

//배열
//동일한 변수를 모아놓은 집합

//value type 변수 :int float,double.....struct(구조체)
//Reference type 변수:array, c lass 객체


public class Test_03 : MonoBehaviour
{
    //유니티에서 배열을 멤버변수로 선언해서 사용하는 2가지 방법
    int[] m_Brr = new int[5]; //<--멤버 배열 변수 1번째 사용
    public int[] Crr; //멤버배열 변수 2번째 사용예시


    // Start is called before the first frame update
    void Start()
    {
        //int AA0=0
        //  , AA1=0
        //  , AA2=0

        //int[] arr = new int[100]; //c#배열 정수 선언

        int[] arr = new int [5]; //개수보다 하나 더 적은 인덱스를 쓸수 있음
        arr[0] = 10;
        arr[1] = 11;
        arr[2] = 12;
        arr[3] = 13;
        arr[4] = 14;   //---5까지 이고 
      //arr[5] = 15; ----쓰면 잠재적인 에러가 발생할수있음(out of range 등등)

        for(int ii = 0; ii < 5; ii++)
        {
            Debug.Log(arr[ii]);

        }
        Debug.Log("arr 크기 :" + arr.Length); //예:몬스터의 스폰갯수를 알고자 할때의 태그의 마리수를 가져올수있다.

        //+ 멤버 변수 1번째 사용 예

        m_Brr[0] = 11;
        m_Brr[1] = 12;
        m_Brr[2] = 13;
        m_Brr[3] = 14;
        m_Brr[4] = 15;
        for(int ii = 0;ii < m_Brr.Length; ii++)
        {
            Debug.Log("m_Brr [" + ii + "]:" + m_Brr[ii]);
        }

        //멤버 배열 변수 2번째 사용

        for (int ii = 0;ii< Crr.Length; ii++)
        {
            Debug.Log("Crr[" + ii + "] : " + Crr[ii]);
        }

        //코드를 수정하지않고도 입력할수있음(장점);기획자에게 보여줄때 나 설정값을 만들때 유용하다 볼수 있다.
        //단점은 중요변수를 퍼블릭으로 했기에 다른 이들이 수정할수있으니 노출된 코드라 볼수있다.



        //명시적 선언

        int[] a_AAA = new int[10];
        int[] a_BBB;
        a_BBB = new int[10];
        a_BBB[0] = 11;
        for (int ii = 0; ii < a_AAA.Length; ii++)
        {
            Debug.Log(a_AAA[ii]);
        }
        //유니티에서는 배열을 선언후 초기 값을 주지않으면 0으로 초기화

        //암시적 선언
        int[] a_CCC = { 10, 20, 30, 40, 50, 60 }; //집합처럼 갯수를 적지않아도 초기화 함.
        for (int ii = 0; ii < a_CCC.Length; ii++) 
        { 
        Debug.Log(a_CCC[ii]);
        }

        //int[] a_XXX;
        //a_XXX { 11,22,33,44}; //암시적 선언은 선언과 동시에 초기화 해줘야함.(에러의 요지가 있음)_

        //명시+암시

        int[] a_EEE = new int[] { 10, 20, 30, 40 , 50 , 60 };
        int[] a_FFF;
        a_FFF = new int[] { 11, 12, 13, 14, 15 };
        for(int ii = 0; ii< a_FFF.Length; ii++)
        {
            Debug.Log(a_FFF[ii]);
        }

        //float형의 배열
        float[] farr = new float[3];
        farr[0] = 1.0f;
        farr[1] = 2.34f;
        farr[2] = 3.14f;
        for(int ii = 0; ii < farr.Length ; ii++) 
        {
            Debug.Log("farr(" + ii + "]" + farr[ii]);
        }

        int AAAA = 1000;
        int BBBBB = AAAA; //일반 변수들은 값이 복사된다는 뜻에서 value type이다.

        BBBBB = 99;
        Debug.Log("AAAA : " + AAAA + ",BBBBB : " + BBBBB);

        int[] CCCCC = { 1000 };
        int[] DDDDD = CCCCC;  //배열변수는 원본 저장공간을 참조한다는 뜻에서 REFERENCE TYPE이라 함.
        int[] EEEEE = CCCCC;
        DDDDD[0] = 99;
        Debug.Log("CCCCC" + CCCCC[0] + ",DDDDD[0]:" + DDDDD[0] 
            + "EEEEE[0]:" + EEEEE[0]);

        int[] ZZZ = new int[3]; //new int [3](배열안에 int 4byte 3개가 생김)------>int ZZZ
        ZZZ[0] = 10;
        ZZZ[1] = 11;
        ZZZ[2] = 12;

        ZZZ = new int[5];//새로  int형 5개를 생성 시키라 컴퓨터에게 명령--->그 후 zzz에 다시 대입시켰는데
                         //원래의 연결의 배열 3은 없어져서 5개의 int를 대입이 됨
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
