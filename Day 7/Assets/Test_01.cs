using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//enum ����
//��� ���� ���� ���� �ǹ� �ִ� �ܾ��� ǥ���ϸ� �ڵ��� �������� �����ִ� ����


public class Test_01 : MonoBehaviour

{ public enum GawiBawiBo
    { 
      Gawi=1,
      Bawi =2,
      Bo =3            //��ǥ�� �����ص� ����.
    }

    public enum City 
    {
        Seoul,      //0
        Inchenon,   //1
        Busan = 5,    //2
        Gwangju,   //3
        Jeju =10 ,      //4
        Shinchon,  //5
        Count     //6-----ī��Ʈ ���� ������ �����ֱ�����
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


        //1.���� 2.���� 3.��
        //����

        if (a_UserSel == a_ComSel)
        {
            Debug.Log("�����ϴ�.");
        }
        else if (a_UserSel == GawiBawiBo.Gawi && a_ComSel == GawiBawiBo.Bo)
        {
            Debug.Log("�̰���ϴ�.");
        }
        else
        {
            Debug.Log("��");
        
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
