using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 형변환 (Casting)
// 1, 자동 형변환
// 서로 다른 데이터형 변수에 대입하거나 연산을 할 때 자동으로 형변환 되는 규칙
// 단, 서로 다른 데이터형 일 때 큰쪽으로만 상승 변환되는 특징이 있다.
// 데이터형의 크기 순서
// double > float > ulong > long > uint > int > ushort > short > char

// 2, 수동 형변환

public class Test_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1, 자동 형변환
        int ii = 345;
        float ff = ii;  //자동 형변환 345.0f
        //int aa = ff;    //C#에서는 큰데이터형을 작은데이터형에 자동으로 대입할 수 없다.
        Debug.Log("ii : " + ii + ", ff : " + ff);
        // "ii : " + "345" + ", ff : " + "345"
        // "ii : 345, ff : 345"

        long aaa = 123L;  //8바이트짜리 정수를 담는 데이터형 변수 선언
        Debug.Log(aaa + " : " + sizeof(long));
        // "123" + " : " + "8"
        // "123 : 8"
        aaa = ii;  //자동 형변환 가능 345L
        //ii = aaa; //자동 형변환 실패
        //aaa = ff; //자동 형변환 실패
        ff = aaa;

        //2, 수동 형변환
        float a_ff = 12.34f;
        int a_ii = (int)a_ff;   //<-- 수동 형변환(강제 형변환)
        Debug.Log("a_ii : " + a_ii);

        //수동 형변환 활용하는 예
        float xxx = 123.456f;
        int MyInt = (int)xxx;
        float MyFloat = xxx - (int)xxx;  // 123.456f - 123.0f
        Debug.Log(MyInt + " : " + MyFloat);


        // 숫자형태 <--> 문자열형태 변환
        int ABC = 123;
        string CBA = "123";

        int KKK = 123 + ABC;            // 246
        string SSS = "123" + ABC;       // "123123"
        Debug.Log(KKK + " : " + SSS);

        // 숫자형태 --> 문자열형태 변환
        ABC = 777;
        CBA = ABC.ToString();   //숫자형태가 문자열 형태로 변환됨

        // 문자열형태 --> 숫자형태
        string EEE = "123";
        //int FFF = EEE;  //형변환으로는 안되고 함수를 써야 한다.
        //int FFF = int.Parse(EEE); // 좀 위험한 함수 : 특수 문자가 끼어 있으면 에러난다.
        //Debug.Log(FFF);

        //int.TryParse()  //안전한 함수
        int FFF = 0;
        int.TryParse("123", out FFF);
        Debug.Log(FFF);
        FFF = FFF + 5000;
        Debug.Log(FFF);

        float ppp = 0.0f;
        float.TryParse("123.456", out ppp);
        Debug.Log("ppp : " + ppp);

        Debug.Log("<구구단 7단>");
        // 7 * 1 = 7
        // 7 * 2 = 14
        //    :
        //    :
        // 7 * 9 = 63

        //int Dan = 7;
        //int Idx = 1;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );
        //Idx = 2;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );
        //Idx = 3;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );
        //Idx = 4;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );
        //Idx = 5;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );
        //Idx = 6;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );
        //Idx = 7;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );
        //Idx = 8;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );
        //Idx = 9;
        //Debug.Log( Dan + " * " + Idx + " = " + (Dan * Idx) );

        for (int Ix = 1; Ix <= 9; Ix++)
        {
            Debug.Log(7 + " * " + Ix + " = " + (7 * Ix));
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}