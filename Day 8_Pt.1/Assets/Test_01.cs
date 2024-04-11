using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// c# 메서드(method)    //function(c,c++)
// 용도 : 코드를 재활용하기 위한 용도로도 사용이 되고,
// 절차지향적 프로그래밍 기법에서 부품(기능)을 만드는 용도로 사용된다.
//즉, 메서드란 코드를 재활용 하거나 코드를 부품화하고싶을때 사용하는 문법.


//  [접근수식자] 리턴형 메서드이름(데이터형 매개변수,데이터형 매개변수, ....)
//  {
//      실행 코드
//  }

// 접근 수식자, 접근 지정자...
//public - construct,클래스 내외부에서 모두 접근하도록 사용하게 하는 지정자 
//private - 구조체 클래스 내부에서만 사용하게 하고 외부에서 접근 못하게 하는 지정자
//protected - 외부에서 접근 불가능하고,자신과 상속관계의 자식클래스까지는 접근 허용하는 지정자

//리턴형 매개변수에 따른 메서드의 종류

//1. 리턴형과 매개변수 모두 존재
//2. return형이 없고 매개변수가 있는 형태
//3.return 형이 없고 매개변수가 없는 형태
//4.return형이 있고 매개변수가 없는 형태


public class Test_01 : MonoBehaviour
{
    //멤버 메서드이라고도 불림.클래스 안에 구현하기때문


    //1.리턴형과 매개변수가 모두 존재하는 형태
    public int Sum(int a, int b)
    {
        int c = a + b;
        return c;
    }

    //2.return형이 없고 매개변수가 있는 형태

    public void Hamsu(int Kor, int Eng ,int Math) 
    { //void 리턴값이 없다는 의미(리턴값을 돌려주지않아도 됨)
        int a_Hap = Kor + Eng + Math;
        Debug.Log("총점 :" + a_Hap);

        if (a_Hap < 20)
            return; //돌려주지않아도 된다고했지 불가능하다 하지않음.
                    //void형 함수에서 return;이라고만 써주면 함수를 즉시 빠져나가게된다.

        Debug.Log("평균 : " + (a_Hap /3.0f).ToString("F2") ); //위에 return을 if에 맞물려 리턴되었을때 안찍힘.

    }

    //3.return 형이 없고 매개변수가 없는 형태 --이벤트함수나 마찬가지인 형태
    public void PrintGUGUDan()
    {
        int a_Dan = 7;
        for (int i = 1; i < 10; i++)
        {
            Debug.Log(a_Dan + "*" + i + "=" + (a_Dan * i));
        }
    }

    //4.return형이 있고 매개변수가 없는 형태
    float m_Velocity = 10.0f;

    public bool IsMove() 
    {
        if(m_Velocity <=  0)     //읽기 전용 0보다 큰지 아닌지만 판단하고 읽어올수있게 하는 함수(
            return false;       
         
        return true;

    }


    public int MyMethod(int a,int b) //메서드의 정의(설계도)---->요놈이 리턴형과 매개변수가 모두 존재함.
    {   //일반함수 : 호출해줘야지만 동작
        int c = a + b;
        return c;
    }

    // Start is called before the first frame update 
    void Start()
    { //유니티의 이벤트 함수: 우리가 호출해주지않아도 유니티가 자동으로 호출해주는 함수
      //유니티 시스템이 특정 상황에 맞게 호출하는 함수 ; 콜백함수

      //매개변수 parmameter , 인자(인수)...이름이 다양함 다 같은 의미
      //인자 = 매개변수 : 함수의 정의 부분에 있는 변수
      //인수 = 넘기는 값.

        int AAA = MyMethod(111,222); //메서드 호출(사용)
        //---> 호출해줬던 리턴값을 333으로 돌려줌

        int BBB = MyMethod(12, 34);

        int CCC = MyMethod(77, 88);

        //Sum(10, 25); 죽은 코드 두개를 더한다음 출력을 하던지 가공처리를 하면 되는데 사용을 하지않아서 쓰레기 코드다.
        //리턴형이 있는 함수여도 리턴값을 받아서 사용하지않아도 된다.

        int abc = Sum(11, 22) + 99; //이게 맞는 표현.11+22가 된 결과값을 호출시키고 99를 계산하는 방식
        Debug.Log(Sum(11, 22)); //메서드 호출

        Hamsu(50, 10, 20); //메서드 호출 //void 는 리턴하지않는걸 유의할것.

        PrintGUGUDan();  //메서드 호출 ---->이런방식이  '재활용' 한다고 보면 된다.

        if (IsMove() == true)

            Debug.Log("움직이고 있어");

        else

            Debug.Log("멈춰 있어");

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
