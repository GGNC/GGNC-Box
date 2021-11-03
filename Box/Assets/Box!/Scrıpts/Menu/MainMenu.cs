using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject PlayMenu;
    public GameObject Shop;
    public GameObject Level;
    public Transform camer;
    


    public void play ()
    {
        Menu.SetActive(false);
        PlayMenu.SetActive(true);
    }
    public void options()
    {
    
    }
    public void quit ()
    {
        Application.Quit();
    }
    public void Infinity()
    {
        SceneManager.LoadScene("InfinityMode");
    }
   public void Levels()
    {
        PlayMenu.SetActive(false);
        Level.SetActive(true);


    }
    public void Shops()
    {
        Menu.SetActive(false);
        Shop.SetActive(true);
        camer.transform.position = new Vector3(0, -1.1f, -4.2f);
    }
    public void Backtomenu()
    {
        PlayMenu.SetActive(false);
        Menu.SetActive(true);
    }
    public void BacktoMode()
    {
        PlayMenu.SetActive(true);
        Level.SetActive(false);
    }
    public void BackToMenu()
    {
        Shop.SetActive(false);
        Menu.SetActive(true);
        camer.transform.position = new Vector3(0, -0.75f, -4.2f);
    }

}
