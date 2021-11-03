using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSellect : MonoBehaviour
{
    public GameObject easy;
    public GameObject normal;
    public GameObject hard;
    public GameObject EL1;
    public GameObject EL2;
    public GameObject EL3;
    public GameObject EL4;
    public GameObject NL1;
    public GameObject NL2;
    public GameObject NL3;
    public GameObject NL4;
    public GameObject HL1;
    public GameObject HL2;

    public void Start()
    {
        if(PlayerPrefs.GetInt("EL1",0)==1)
        {
            EL1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("EL2", 0) == 1)
        {
            EL2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("EL3", 0) == 1)
        {
            EL3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("EL4", 0) == 1)
        {
            EL4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("NL1", 0) == 1)
        {
            NL1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("NL2", 0) == 1)
        {
            NL2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("NL3", 0) == 1)
        {
            NL3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("NL4", 0) == 1)
        {
            NL4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("HL1", 0) == 1)
        {
            HL1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("HL2", 0) == 1)
        {
            HL2.SetActive(true);
        }
    }
    public void Easy()
    {
        easy.SetActive(true);
        normal.SetActive(false);
        hard.SetActive(false);

    }
    public void Normal()
    {
        easy.SetActive(false);
        normal.SetActive(true);
        hard.SetActive(false);

    }
    public void Hard()
    {
        easy.SetActive(false);
        normal.SetActive(false);
        hard.SetActive(true);

    }
    public void EasyLevel01()
    {
        SceneManager.LoadScene("EasyLevel01"); 
    }
    public void EasyLevel02()
    {
        SceneManager.LoadScene("EasyLevel02");
    }
    public void EasyLevel03()
    {
        SceneManager.LoadScene("EasyLevel03");
    }
    public void EasyLevel04()
    {
        SceneManager.LoadScene("EasyLevel04");
    }
    public void NormalLevel01()
    {
        SceneManager.LoadScene("NormalLevel01");
    }
    public void NormalLevel02()
    {
        SceneManager.LoadScene("NormalLevel02");
    }
    public void NormalLevel03()
    {
        SceneManager.LoadScene("NormalLevel03");
    }
    public void NormalLevel04()
    {
        SceneManager.LoadScene("NormalLevel04");
    }
    public void HardLevel01()
    {
        SceneManager.LoadScene("HardLevel01");
    }
    public void HardLevel02()
    {
        SceneManager.LoadScene("HardLevel02");
    }
 
}
