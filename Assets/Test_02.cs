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
        Debug.Log("�ݰ����� ����Ƽ");

        float height1 = 160.5f;  //C# ���� float���� ���� �ڿ� f�� �ٿ���� �Ѵ�.
        float height2;
        height2 = height1;
        Debug.Log(height2);

        double abc = 567.8;
        // double �� �Ҽ����� ��� ���������̰� 8Byte�� �����Ѵ�. ��, f�� ������ �ʴ´�.
        // double�� �Ǽ����� �����ϴ� ����������, double���� float ������ ������ ũ��.

        short ABC = 32767;

        bool abab = true;
        Debug.Log(abab);    // True
        abab = false;
        Debug.Log(abab);    // False

        int CCC;        //C#���� ������ ���� ��� ���� ���� ���·� ����� �� ����. ��������.
        CCC = 10;
        Debug.Log(CCC);

        // char 
        // c, c++ : char 1Byte �ƽ�Ű�ڵ�
        // c# : char 2Byte �����ڵ�
        char ccdd = 'k';    //<-- C#���� ' ' �����ָ� ���� �ϳ��� �ǹ��Ѵ�.
        ccdd = '��';
        Debug.Log(ccdd);

        //Debug.Log(sizeof(int));  //<-- �������� �޸� ������ �˾ƿ���

        //string 
        string strName;
        strName = "GDragon";  //<-- C#���� " " �����ָ� ���ڿ�(����)�� �ǹ��Ѵ�.
        Debug.Log(strName);
        strName = "�ݰ����� " + "���� " + "���� ���� ���ƿ�.";
        Debug.Log(strName);

        byte ggg = 255;     //0 ~ 255 ���� ���� �� �մ� 1Byte ¥�� ���� ����

        //--- �ʱⰪ�� ���� ���������� �����Ǵ� ��������
        var vv1 = 123;
        var vv2 = 3.14f;
        var vv3 = "seoul";
        var vv4 = true;

        //vv1 = "Korea";  //��������.
        vv3 = "korea";
        //--- �ʱⰪ�� ���� ���������� �����Ǵ� ��������
    }

    // Update is called once per frame
    void Update()
    {

    }
}
