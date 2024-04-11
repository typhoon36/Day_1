using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RSPGame_Mgr : MonoBehaviour
{
    [Header("--- Text ---")]

    public Text UserInfo_Text;

    public Text UserGold_Text;

    public Text Result_Text;

    [Header("--- Button ---")]

    public Button Scissors_Btn;

    public Button Rock_Btn;

    public Button Paper_Btn;

    public Button Restart_Btn;


    [Header("--- Borrow ---")]

    public InputField UserName_IF;

    public Button UserNameSave_Btn;


    [Header("--- Character Image ---")]

    public Image Char_Img;

    public Sprite WinImg;

    public Sprite LostImg;

    public Sprite WaitImg;

    public Image GameOver_Img;

    [Header("--- User Image ---")]

    public Image User_Img;

    public Sprite Scissors1Img;

    public Sprite Rock1Img;

    public Sprite Paper1Img;


    [Header("--- Computer Image ---")]

    public Image Com_Img;

    public Sprite Scissors2Img;

    public Sprite Rock2Img;

    public Sprite Paper2Img;

    int m_UserGold = 1000;

    int m_WinCount = 0;

    int m_LostCount = 0;

    int m_DrawCount = 0;

    string m_NickName = "����";

    // Start is called before the first frame update
    void Start()
    {
        if (Scissors_Btn != null)
            Scissors_Btn.onClick.AddListener(ScissorsBtnClick);

        if (Rock_Btn != null)
            Rock_Btn.onClick.AddListener(RockBtnClick);

        if (Paper_Btn != null)
            Paper_Btn.onClick.AddListener(PaperBtnClick);

        if (Restart_Btn != null)
            Restart_Btn.onClick.AddListener(RestartBtnClick);

        if (UserNameSave_Btn != null)
            UserNameSave_Btn.onClick.AddListener(UserNameSaveBtnClick);

    }

    //// Update is called once per frame
    //void Update()
    //{

    //}

    private void ScissorsBtnClick()   // User Choice is Scissors
    {
        if (m_UserGold <= 0)

            return;

        User_Img.sprite = Scissors1Img;

        int a_ComSe = Random.Range(1, 4);

        if (a_ComSe == 1)  // Case : User Win
        {
            Com_Img.sprite = Paper2Img;

            m_UserGold += 100;

            m_WinCount++;

            Result_Text.text = "User(����) vs Com(��) �����? ... �¸�!";

            Char_Img.sprite = WinImg;


            UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

                m_LostCount + ") ���º� (" + m_DrawCount + ")";

            UserGold_Text.text = m_UserGold.ToString();

        }
        else if (a_ComSe == 2)
        {
            Com_Img.sprite = Rock2Img;
            m_UserGold -= 200;

            m_LostCount++;

            Result_Text.text = "User(����) vs Com(�ָ�) �����? ... �й� T^T";

            Char_Img.sprite = LostImg;

            UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

               m_LostCount + ") ���º� (" + m_DrawCount + ")";

            UserGold_Text.text = m_UserGold.ToString();
        }
        if (m_UserGold <= 0)
        {
            Char_Img.gameObject.SetActive(false);

            GameOver_Img.gameObject.SetActive(true);


            m_UserGold = 0;

            UserGold_Text.text = m_UserGold.ToString();

            Result_Text.text = "GAME OVER �Ф� �ٽ� �����غ�����!";

            Restart_Btn.gameObject.SetActive(true);
        }
        else
        {
            Com_Img.sprite = Scissors2Img;
            m_DrawCount++;
            Result_Text.text = "User(����) vs Com(����) �����? ... �����ϴ�!";
            Char_Img.sprite = Scissors2Img;

            UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

                m_LostCount + ") ���º� (" + m_DrawCount + ")";

            UserGold_Text.text = m_UserGold.ToString();
        }
    }

    private void RockBtnClick()   //  User choice is Rock
    {
        if (m_UserGold <= 0)
            return;
        User_Img.sprite = Rock1Img;

        int a_ComSe = Random.Range(1, 4);

        if (a_ComSe == 1)  // Case : User Win
        {

            Com_Img.sprite = Scissors2Img;
            m_UserGold += 100;
            m_WinCount++;
            Result_Text.text = "User(����) vs Com(����) �����? ... �¸�!";

            Char_Img.sprite = WinImg;

            UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

               m_LostCount + ") ���º� (" + m_DrawCount + ")";

            UserGold_Text.text = m_UserGold.ToString();
        }
        else if (a_ComSe == 2)  // Case : User Lose
        {
            Com_Img.sprite = Paper2Img;

            m_UserGold -= 200;

            m_LostCount++;

            Result_Text.text = "User(����) vs Com(��) �����? ... �й� T^T";

            Char_Img.sprite = LostImg;

            UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

                m_LostCount + ") ���º� (" + m_DrawCount + ")";

            UserGold_Text.text = m_UserGold.ToString();

            if (m_UserGold <= 0)
            {
                Char_Img.gameObject.SetActive(false);

                GameOver_Img.gameObject.SetActive(true);


                m_UserGold = 0;

                UserGold_Text.text = m_UserGold.ToString();

                Result_Text.text = "GAME OVER �Ф� �ٽ� �����غ�����!";

                Restart_Btn.gameObject.SetActive(true);



            }
            else
            {
                Com_Img.sprite = Rock2Img;

                m_DrawCount++;

                Result_Text.text = "User(����) vs Com(����) �����? ... �����ϴ�!";

                Char_Img.sprite = WaitImg;

                UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

              m_LostCount + ") ���º� (" + m_DrawCount + ")";

                UserGold_Text.text = m_UserGold.ToString();

            }

        }




    }


    private void PaperBtnClick()
    {
        if (m_UserGold <= 0)

            return;

        User_Img.sprite = Paper1Img;

        int a_ComSe = Random.Range(1, 4);    // User choice is paper

        if (a_ComSe == 1)  // Case : User Win
        {
            Com_Img.sprite = Rock2Img;

            m_UserGold += 100;

            m_WinCount++;

            Result_Text.text = "User(��) vs Com(����) �����? ... �¸�!";

            Char_Img.sprite = WinImg;


            UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

               m_LostCount + ") ���º� (" + m_DrawCount + ")";

            UserGold_Text.text = m_UserGold.ToString();
        }
        else if (a_ComSe == 2)
        {
            Com_Img.sprite = Scissors2Img;

            m_UserGold -= 200;

            m_LostCount++;

            Result_Text.text = "User(��) vs Com(����) �����? ... �й� T^T";

            Char_Img.sprite = LostImg;


            UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

                m_LostCount + ") ���º� (" + m_DrawCount + ")";

            UserGold_Text.text = m_UserGold.ToString();

            if (m_UserGold <= 0)
            {
                Char_Img.gameObject.SetActive(false);

                GameOver_Img.gameObject.SetActive(true);


                m_UserGold = 0;

                UserGold_Text.text = m_UserGold.ToString();

                Result_Text.text = "GAME OVER �Ф� �ٽ� �����غ�����!";

                Restart_Btn.gameObject.SetActive(true);
            }
        }
        else
        {
            Com_Img.sprite = Paper2Img;

            m_DrawCount++;

            Result_Text.text = "User(��) vs Com(��) �����? ... �����ϴ�!";

            Char_Img.sprite = WaitImg;

            UserInfo_Text.text = m_NickName + "���� ��(" + m_WinCount + ") ��(" +

                m_LostCount + ") ���º� (" + m_DrawCount + ")";

            UserGold_Text.text = m_UserGold.ToString();
        }

    }

    private void RestartBtnClick()
    {
        SceneManager.LoadScene("RPSGame_Mgr");
    }
    private void UserNameSaveBtnClick()
    {

        string a_Nick = UserName_IF.text;


        if (a_Nick == "")
            m_NickName = "����";

        else

            m_NickName = a_Nick;

        UserInfo_Text.text = m_NickName + "��(" + m_WinCount + ") ��(" +

                m_LostCount + ") ���º� (" + m_DrawCount + ")";

    }
}