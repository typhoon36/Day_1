using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ȯ (Casting)
// 1, �ڵ� ����ȯ
// ���� �ٸ� �������� ������ �����ϰų� ������ �� �� �ڵ����� ����ȯ �Ǵ� ��Ģ
// ��, ���� �ٸ� �������� �� �� ū�����θ� ��� ��ȯ�Ǵ� Ư¡�� �ִ�.
// ���������� ũ�� ����
// double > float > ulong > long > uint > int > ushort > short > char

// 2, ���� ����ȯ

public class Test_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1, �ڵ� ����ȯ
        int ii = 345;
        float ff = ii;  //�ڵ� ����ȯ 345.0f
        //int aa = ff;    //C#������ ū���������� �������������� �ڵ����� ������ �� ����.
        Debug.Log("ii : " + ii + ", ff : " + ff);
        // "ii : " + "345" + ", ff : " + "345"
        // "ii : 345, ff : 345"

        long aaa = 123L;  //8����Ʈ¥�� ������ ��� �������� ���� ����
        Debug.Log(aaa + " : " + sizeof(long));
        // "123" + " : " + "8"
        // "123 : 8"
        aaa = ii;  //�ڵ� ����ȯ ���� 345L
        //ii = aaa; //�ڵ� ����ȯ ����
        //aaa = ff; //�ڵ� ����ȯ ����
        ff = aaa;

        //2, ���� ����ȯ
        float a_ff = 12.34f;
        int a_ii = (int)a_ff;   //<-- ���� ����ȯ(���� ����ȯ)
        Debug.Log("a_ii : " + a_ii);

        //���� ����ȯ Ȱ���ϴ� ��
        float xxx = 123.456f;
        int MyInt = (int)xxx;
        float MyFloat = xxx - (int)xxx;  // 123.456f - 123.0f
        Debug.Log(MyInt + " : " + MyFloat);


        // �������� <--> ���ڿ����� ��ȯ
        int ABC = 123;
        string CBA = "123";

        int KKK = 123 + ABC;            // 246
        string SSS = "123" + ABC;       // "123123"
        Debug.Log(KKK + " : " + SSS);

        // �������� --> ���ڿ����� ��ȯ
        ABC = 777;
        CBA = ABC.ToString();   //�������°� ���ڿ� ���·� ��ȯ��

        // ���ڿ����� --> ��������
        string EEE = "123";
        //int FFF = EEE;  //����ȯ���δ� �ȵǰ� �Լ��� ��� �Ѵ�.
        //int FFF = int.Parse(EEE); // �� ������ �Լ� : Ư�� ���ڰ� ���� ������ ��������.
        //Debug.Log(FFF);

        //int.TryParse()  //������ �Լ�
        int FFF = 0;
        int.TryParse("123", out FFF);
        Debug.Log(FFF);
        FFF = FFF + 5000;
        Debug.Log(FFF);

        float ppp = 0.0f;
        float.TryParse("123.456", out ppp);
        Debug.Log("ppp : " + ppp);

        Debug.Log("<������ 7��>");
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