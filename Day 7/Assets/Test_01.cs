using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//enum 열거
//상수 숫자 들을 보다 의미 있는 단어들로 표현하며 코드의 가독성을 높여주는 문법


public class Test_01 : MonoBehaviour

{ public enum GawiBawiBo
    { 
      Gawi=1,
      Bawi =2,
      Bo =3            //쉼표를 생략해도 좋다.
    }

    public enum City 
    {
        Seoul,      //0
        Inchenon,   //1
        Busan = 5,    //2
        Gwangju,   //3
        Jeju =10 ,      //4
        Shinchon,  //5
        Count     //6-----카운트 빼고 갯수를 세어주기위해
    }


    // Start is called before the first frame update
    void Start()
    {
        City Mycity = City.Busan;
        Debug.Log("Mycity : " + Mycity + ": Index(" + (int)Mycity + ")");
        Debug.Log("Shinchon : " + "Index(" + (int)City.Shinchon + ")");

        GawiBawiBo a_UserSel = GawiBawiBo.Gawi;
        GawiBawiBo a_ComSel = (GawiBawiBo)Random.Range(
            (int)GawiBawiBo.Gawi, (int)GawiBawiBo.Bo + 1);


        //1.가위 2.바위 3.보
        //판정

        if (a_UserSel == a_ComSel)
        {
            Debug.Log("비겼습니다.");
        }
        else if (a_UserSel == GawiBawiBo.Gawi && a_ComSel == GawiBawiBo.Bo)
        {
            Debug.Log("이겼습니다.");
        }
        else
        {
            Debug.Log("짐");
        
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
