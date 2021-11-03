using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketSystem : MonoBehaviour
{

    public Material PlayerColor;
    public Text money;
    private int money1;
    public GameObject Broke;
    public GameObject HaveRed;
    public GameObject EquipRed;
    public GameObject moneyBlue;
    public GameObject HaveBlue;
    public GameObject EquipBlue;
    public GameObject moneyMagenta;
    public GameObject HaveMagenta;
    public GameObject EquipMagenta;
    public GameObject moneyCyan;
    public GameObject HaveCyan;
    public GameObject EquipCyan;
    public GameObject moneyYellow;
    public GameObject HaveYellow;
    public GameObject EquipYellow;
    public GameObject moneyGreen;
    public GameObject HaveGreen;
    public GameObject EquipGreen;
    public GameObject moneyBlack;
    public GameObject HaveBlack;
    public GameObject EquipBlack;
    public GameObject moneyWhite;
    public GameObject HaveWhite;
    public GameObject EquipWhite;
    public void Start()
    {
        PlayerPrefs.GetInt("LO");
        money.text = PlayerPrefs.GetInt("LO").ToString();
        money1 = PlayerPrefs.GetInt("LO");
        Broke.SetActive(false);
        PlayerPrefs.SetInt("RED", 1);
        CheckEquip();
    }
    public void Update()
    {
        money.text = PlayerPrefs.GetInt("LO").ToString();
        money1 = PlayerPrefs.GetInt("LO");
        CheckStart();
    }

    public void Red()
    {
        PlayerColor.color = Color.red;
        EquipRed.SetActive(true);
        HaveRed.SetActive(false);
        CheckRed();
        
    }
    public void Blue()
    {
        if (PlayerPrefs.GetInt("BLUE", 0) == 0)
        {
            if (money1 >= 8)
            {
                money1 = money1 - 8;
                PlayerColor.color = Color.blue;
                PlayerPrefs.SetInt("LO", money1);
                PlayerPrefs.SetInt("BLUE", 1);
                moneyBlue.SetActive(false);
                EquipBlue.SetActive(true);
                CheckBlue();

            }
            else
            {
                Invoke("Broke1", 0.5f);
                Invoke("Broke2", 1.75f);
            }
        }
        else if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            PlayerColor.color = Color.blue;
            HaveBlue.SetActive(false);
            EquipBlue.SetActive(true);
            CheckBlue();
        }
    }
    public void Yellow()
    {
        if (PlayerPrefs.GetInt("YELLOW", 0) == 0)
        {
            if (money1 >= 8)
            {
                money1 = money1 - 8;
                PlayerColor.color = Color.yellow;
                PlayerPrefs.SetInt("LO", money1);
                PlayerPrefs.SetInt("YELLOW", 1);
                moneyYellow.SetActive(false);
                EquipYellow.SetActive(true);
                CheckYellow();
            }
            else
            {
                Invoke("Broke1", 0.5f);
                Invoke("Broke2", 1.75f);
            }
        }
        else if (PlayerPrefs.GetInt("YELLOW", 0) == 1)
        {
            PlayerColor.color = Color.yellow;
            HaveYellow.SetActive(false);
            EquipYellow.SetActive(true);
            CheckYellow();
        }
    }
    public void Cyan()
    { if (PlayerPrefs.GetInt("CYAN", 0) == 0)
        {
            if (money1 >= 8)
            {
                money1 = money1 - 8;
                PlayerColor.color = Color.cyan;
                PlayerPrefs.SetInt("LO", money1);
                PlayerPrefs.SetInt("CYAN", 1);
                moneyCyan.SetActive(false);
                EquipCyan.SetActive(true);
                CheckCyan();
            }
            else
            {
                Invoke("Broke1", 0.5f);
                Invoke("Broke2", 1.75f);
            }
        }
        else if (PlayerPrefs.GetInt("CYAN", 0) == 1)
        {
            PlayerColor.color = Color.cyan;
            HaveCyan.SetActive(false);
            EquipCyan.SetActive(true);
            CheckCyan();
        }
    }
    public void Magenta()
    {
        if (PlayerPrefs.GetInt("MAGENTA", 0) == 0)
        {
            if (money1 >= 8)
            {
                money1 = money1 - 8;
                PlayerColor.color = Color.magenta;
                PlayerPrefs.SetInt("LO", money1);
                PlayerPrefs.SetInt("MAGENTA", 1);
                moneyMagenta.SetActive(false);
                EquipMagenta.SetActive(true);
                CheckMagenta();
            }
            else
            {
                Invoke("Broke1", 0.5f);
                Invoke("Broke2", 1.75f);
            }
        }
        else if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            PlayerColor.color = Color.magenta;
            HaveMagenta.SetActive(false);
            EquipMagenta.SetActive(true);
            CheckMagenta();
        }
    }
    public void Green()
    {
        if (PlayerPrefs.GetInt("GREEN", 0) == 0)
        {
            if (money1 >= 8)
            {
                money1 = money1 - 8;
                PlayerColor.color = Color.green;
                PlayerPrefs.SetInt("LO", money1);
                PlayerPrefs.SetInt("GREEN", 1);
                moneyGreen.SetActive(false);
                EquipGreen.SetActive(true);
                CheckGreen();
            }
            else
            {
                Invoke("Broke1", 0.5f);
                Invoke("Broke2", 1.75f);
            }
        }
        else if (PlayerPrefs.GetInt("GREEN", 0) == 1)
        {
            PlayerColor.color = Color.green;
            HaveGreen.SetActive(false);
            EquipGreen.SetActive(true);
            CheckGreen();
        }
    }
    public void Black()
    {
        if (PlayerPrefs.GetInt("BLACK", 0) == 0)
        {
            if (money1 >= 8)
            {
                money1 = money1 - 8;
                PlayerColor.color = Color.black;
                PlayerPrefs.SetInt("LO", money1);
                PlayerPrefs.SetInt("BLACK", 1);
                moneyBlack.SetActive(false);
                EquipBlack.SetActive(true);
                CheckBlack();

            }
            else
            {
                Invoke("Broke1", 0.5f);
                Invoke("Broke2", 1.75f);
            }
        }
        else if (PlayerPrefs.GetInt("BLACK", 0) == 1)
        {
            PlayerColor.color = Color.black;
            HaveBlack.SetActive(false);
            EquipBlack.SetActive(true);
            CheckBlack();
        }
    }
    public void White()
    {
        if (PlayerPrefs.GetInt("WHITE", 0) == 0)
        {
            if (money1 >= 8)
            {
                money1 = money1 - 8;
                PlayerColor.color = Color.white;
                
                PlayerPrefs.SetInt("LO", money1);
                PlayerPrefs.SetInt("WHITE", 1);
                moneyWhite.SetActive(false);
                EquipWhite.SetActive(true);
                CheckWhite();
            }
            else
            {
                Invoke("Broke1", 0.5f);
                Invoke("Broke2", 1.75f);
            }
        }
        else if (PlayerPrefs.GetInt("WHITE", 0) == 1)
        {
            PlayerColor.color = Color.white;
            HaveWhite.SetActive(false);
            EquipWhite.SetActive(true);
            CheckWhite();
        }
    }
    public void CheckStart()
    {
        if (PlayerPrefs.GetInt("RED") == 1)
        {
            HaveRed.SetActive(true);
        }
        if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            moneyBlue.SetActive(false);
            HaveBlue.SetActive(true);
        }
        if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            moneyMagenta.SetActive(false);
            HaveMagenta.SetActive(true);
        }
        if (PlayerPrefs.GetInt("CYAN") == 1)
        {
            moneyCyan.SetActive(false);
            HaveCyan.SetActive(true);
        }
        if (PlayerPrefs.GetInt("YELLOW") == 1)
        {
            moneyYellow.SetActive(false);
            HaveYellow.SetActive(true);
        }
        if (PlayerPrefs.GetInt("GREEN") == 1)
        {
            moneyGreen.SetActive(false);
            HaveGreen.SetActive(true);
        }
        if (PlayerPrefs.GetInt("BLACK") == 1)
        {
            moneyBlack.SetActive(false);
            HaveBlack.SetActive(true);
        }
        if (PlayerPrefs.GetInt("WHITE") == 1)
        {
            moneyWhite.SetActive(false);
            HaveWhite.SetActive(true);
        }
    }
    public void CheckEquip()
    {
        if(PlayerColor.color==Color.red)
        {
            EquipRed.SetActive(true);
            EquipBlue.SetActive(false);
            EquipCyan.SetActive(false);
            EquipGreen.SetActive(false);
            EquipMagenta.SetActive(false);
            EquipBlack.SetActive(false);
            EquipYellow.SetActive(false);
            EquipWhite.SetActive(false);
        }
        if (PlayerColor.color == Color.blue)
        {
            EquipRed.SetActive(false);
            EquipBlue.SetActive(true);
            EquipCyan.SetActive(false);
            EquipGreen.SetActive(false);
            EquipMagenta.SetActive(false);
            EquipBlack.SetActive(false);
            EquipYellow.SetActive(false);
            EquipWhite.SetActive(false);
        }
        if (PlayerColor.color == Color.cyan)
        {
            EquipRed.SetActive(false);
            EquipBlue.SetActive(false);
            EquipCyan.SetActive(true);
            EquipGreen.SetActive(false);
            EquipMagenta.SetActive(false);
            EquipBlack.SetActive(false);
            EquipYellow.SetActive(false);
            EquipWhite.SetActive(false);
        }
        if (PlayerColor.color == Color.green)
        {
            EquipRed.SetActive(false);
            EquipBlue.SetActive(false);
            EquipCyan.SetActive(false);
            EquipGreen.SetActive(true);
            EquipMagenta.SetActive(false);
            EquipBlack.SetActive(false);
            EquipYellow.SetActive(false);
            EquipWhite.SetActive(false);
        }
        if (PlayerColor.color == Color.magenta)
        {
            EquipRed.SetActive(false);
            EquipBlue.SetActive(false);
            EquipCyan.SetActive(false);
            EquipGreen.SetActive(false);
            EquipMagenta.SetActive(true);
            EquipBlack.SetActive(false);
            EquipYellow.SetActive(false);
            EquipWhite.SetActive(false);
        }
        if (PlayerColor.color == Color.black)
        {
            EquipRed.SetActive(false);
            EquipBlue.SetActive(false);
            EquipCyan.SetActive(false);
            EquipGreen.SetActive(false);
            EquipMagenta.SetActive(false);
            EquipBlack.SetActive(true);
            EquipYellow.SetActive(false);
            EquipWhite.SetActive(false);
        }
        if (PlayerColor.color == Color.yellow)
        {
            EquipRed.SetActive(false);
            EquipBlue.SetActive(false);
            EquipCyan.SetActive(false);
            EquipGreen.SetActive(false);
            EquipMagenta.SetActive(false);
            EquipBlack.SetActive(false);
            EquipYellow.SetActive(true);
            EquipWhite.SetActive(false);
        }
        if (PlayerColor.color == Color.white)
        {
            EquipRed.SetActive(false);
            EquipBlue.SetActive(false);
            EquipCyan.SetActive(false);
            EquipGreen.SetActive(false);
            EquipMagenta.SetActive(false);
            EquipBlack.SetActive(false);
            EquipYellow.SetActive(false);
            EquipWhite.SetActive(true);
        }
    }
    public void CheckRed()
    {
        if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            HaveBlue.SetActive(true);
            EquipBlue.SetActive(false);
        }
        if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            HaveMagenta.SetActive(true);
            EquipMagenta.SetActive(false);
        }
        if (PlayerPrefs.GetInt("CYAN") == 1)
        {
            HaveCyan.SetActive(true);
            EquipCyan.SetActive(false);
        }
        if (PlayerPrefs.GetInt("YELLOW") == 1)
        {
            HaveYellow.SetActive(true);
            EquipYellow.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GREEN") == 1)
        {
            HaveGreen.SetActive(true);
            EquipGreen.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLACK") == 1)
        {
            HaveBlack.SetActive(true);
            EquipBlack.SetActive(false);
        }
        if (PlayerPrefs.GetInt("WHITE") == 1)
        {
            HaveWhite.SetActive(true);
            EquipWhite.SetActive(false);
        }
    }
    public void CheckBlue()
    {
        if (PlayerPrefs.GetInt("RED") == 1)
        {
            HaveRed.SetActive(true);
            EquipRed.SetActive(false);
        }
        if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            HaveMagenta.SetActive(true);
            EquipMagenta.SetActive(false);
        }
    
        if (PlayerPrefs.GetInt("CYAN") == 1)
        {
            HaveCyan.SetActive(true);
            EquipCyan.SetActive(false);
        }
        if (PlayerPrefs.GetInt("YELLOW") == 1)
        {
            HaveYellow.SetActive(true);
            EquipYellow.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GREEN") == 1)
        {
            HaveGreen.SetActive(true);
            EquipGreen.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLACK") == 1)
        {
            HaveBlack.SetActive(true);
            EquipBlack.SetActive(false);
        }
        if (PlayerPrefs.GetInt("WHITE") == 1)
        {
            HaveWhite.SetActive(true);
            EquipWhite.SetActive(false);
        }
    }
    public void CheckYellow()
    {
        if (PlayerPrefs.GetInt("RED") == 1)
        {
            HaveRed.SetActive(true);
            EquipRed.SetActive(false);
        }
        if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            HaveMagenta.SetActive(true);
            EquipMagenta.SetActive(false);
        }

        if (PlayerPrefs.GetInt("CYAN") == 1)
        {
            HaveCyan.SetActive(true);
            EquipCyan.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            HaveBlue.SetActive(true);
            EquipBlue.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GREEN") == 1)
        {
            HaveGreen.SetActive(true);
            EquipGreen.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLACK") == 1)
        {
            HaveBlack.SetActive(true);
            EquipBlack.SetActive(false);
        }
        if (PlayerPrefs.GetInt("WHITE") == 1)
        {
            HaveWhite.SetActive(true);
            EquipWhite.SetActive(false);
        }
    }
    public void CheckCyan()
    {
        if (PlayerPrefs.GetInt("RED") == 1)
        {
            HaveRed.SetActive(true);
            EquipRed.SetActive(false);
        }
        if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            HaveMagenta.SetActive(true);
            EquipMagenta.SetActive(false);
        }

        if (PlayerPrefs.GetInt("YELLOW") == 1)
        {
            HaveYellow.SetActive(true);
            EquipYellow.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            HaveBlue.SetActive(true);
            EquipBlue.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GREEN") == 1)
        {
            HaveGreen.SetActive(true);
            EquipGreen.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLACK") == 1)
        {
            HaveBlack.SetActive(true);
            EquipBlack.SetActive(false);
        }
        if (PlayerPrefs.GetInt("WHITE") == 1)
        {
            HaveWhite.SetActive(true);
            EquipWhite.SetActive(false);
        }
    }
    public void CheckMagenta()
    {
        if (PlayerPrefs.GetInt("RED") == 1)
        {
            HaveRed.SetActive(true);
            EquipRed.SetActive(false);
        }
        if (PlayerPrefs.GetInt("CYAN") == 1)
        {
            HaveCyan.SetActive(true);
            EquipCyan.SetActive(false);
        }

        if (PlayerPrefs.GetInt("YELLOW") == 1)
        {
            HaveYellow.SetActive(true);
            EquipYellow.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            HaveBlue.SetActive(true);
            EquipBlue.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GREEN") == 1)
        {
            HaveGreen.SetActive(true);
            EquipGreen.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLACK") == 1)
        {
            HaveBlack.SetActive(true);
            EquipBlack.SetActive(false);
        }
        if (PlayerPrefs.GetInt("WHITE") == 1)
        {
            HaveWhite.SetActive(true);
            EquipWhite.SetActive(false);
        }
    }
    public void CheckGreen()
    {
        if (PlayerPrefs.GetInt("RED") == 1)
        {
            HaveRed.SetActive(true);
            EquipRed.SetActive(false);
        }
        if (PlayerPrefs.GetInt("CYAN") == 1)
        {
            HaveCyan.SetActive(true);
            EquipCyan.SetActive(false);
        }

        if (PlayerPrefs.GetInt("YELLOW") == 1)
        {
            HaveYellow.SetActive(true);
            EquipYellow.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            HaveBlue.SetActive(true);
            EquipBlue.SetActive(false);
        }
        if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            HaveMagenta.SetActive(true);
            EquipMagenta.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLACK") == 1)
        {
            HaveBlack.SetActive(true);
            EquipBlack.SetActive(false);
        }
        if (PlayerPrefs.GetInt("WHITE") == 1)
        {
            HaveWhite.SetActive(true);
            EquipWhite.SetActive(false);
        }
    }
    public void CheckBlack()
    {
        if (PlayerPrefs.GetInt("RED") == 1)
        {
            HaveRed.SetActive(true);
            EquipRed.SetActive(false);
        }
        if (PlayerPrefs.GetInt("CYAN") == 1)
        {
            HaveCyan.SetActive(true);
            EquipCyan.SetActive(false);
        }

        if (PlayerPrefs.GetInt("YELLOW") == 1)
        {
            HaveYellow.SetActive(true);
            EquipYellow.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            HaveBlue.SetActive(true);
            EquipBlue.SetActive(false);
        }
        if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            HaveMagenta.SetActive(true);
            EquipMagenta.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GREEN") == 1)
        {
            HaveGreen.SetActive(true);
            EquipGreen.SetActive(false);
        }
        if (PlayerPrefs.GetInt("WHITE") == 1)
        {
            HaveWhite.SetActive(true);
            EquipWhite.SetActive(false);
        }
    }
    public void CheckWhite()
    {
        if (PlayerPrefs.GetInt("RED") == 1)
        {
            HaveRed.SetActive(true);
            EquipRed.SetActive(false);
        }
        if (PlayerPrefs.GetInt("CYAN") == 1)
        {
            HaveCyan.SetActive(true);
            EquipCyan.SetActive(false);
        }

        if (PlayerPrefs.GetInt("YELLOW") == 1)
        {
            HaveYellow.SetActive(true);
            EquipYellow.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLUE") == 1)
        {
            HaveBlue.SetActive(true);
            EquipBlue.SetActive(false);
        }
        if (PlayerPrefs.GetInt("MAGENTA") == 1)
        {
            HaveMagenta.SetActive(true);
            EquipMagenta.SetActive(false);
        }
        if (PlayerPrefs.GetInt("GREEN") == 1)
        {
            HaveGreen.SetActive(true);
            EquipGreen.SetActive(false);
        }
        if (PlayerPrefs.GetInt("BLACK") == 1)
        {
            HaveBlack.SetActive(true);
            EquipBlack.SetActive(false);
        }
    }
    public void Broke1()
    {
        Broke.SetActive(true);
    }
    public void Broke2()
    {
        Broke.SetActive(false);
    }
}
