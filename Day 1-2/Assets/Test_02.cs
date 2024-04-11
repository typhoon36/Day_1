using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age = 30;
        string name = "cat";
        float height = 158.3f;

        age = 123;
        age = 1004 + 1000 - 500;

        Debug.Log(age);
        Debug.Log("반가워요 유니티");

        float height1 = 160.5f;  //C# 에서 float형은 숫자 뒤에 f를 붙여줘야 한다.
        float height2;
        height2 = height1;
        Debug.Log(height2);

        double abc = 567.8;
        // double 도 소수점을 담는 데이터형이고 8Byte를 차지한다. 단, f를 붙이지 않는다.
        // double도 실수값을 저장하는 공간이지만, double형이 float 형보다 범위가 크다.

        short ABC = 32767;

        bool abab = true;
        Debug.Log(abab);    // True
        abab = false;
        Debug.Log(abab);    // False

        int CCC;        //C#에서 변수에 값이 들어 있지 않은 상태로 사용할 수 없다. 에러난다.
        CCC = 10;
        Debug.Log(CCC);

        // char 
        // c, c++ : char 1Byte 아스키코드
        // c# : char 2Byte 유니코드
        char ccdd = 'k';    //<-- C#에서 ' ' 감싸주면 문자 하나를 의미한다.
        ccdd = '글';
        Debug.Log(ccdd);

        //Debug.Log(sizeof(int));  //<-- 데이터형 메모리 사이즈 알아오기

        //string 
        string strName;
        strName = "GDragon";  //<-- C#에서 " " 감싸주면 문자열(문장)을 의미한다.
        Debug.Log(strName);
        strName = "반가워요 " + "서울 " + "오늘 날씨 좋아요.";
        Debug.Log(strName);

        byte ggg = 255;     //0 ~ 255 까지 담을 수 잇는 1Byte 짜리 변수 선언

        //--- 초기값에 따라서 데이터형이 결정되는 데이터형
        var vv1 = 123;
        var vv2 = 3.14f;
        var vv3 = "seoul";
        var vv4 = true;

        //vv1 = "Korea";  //에러난다.
        vv3 = "korea";
        //--- 초기값에 따라서 데이터형이 결정되는 데이터형
    }

    // Update is called once per frame
    void Update()
    {

    }
}
