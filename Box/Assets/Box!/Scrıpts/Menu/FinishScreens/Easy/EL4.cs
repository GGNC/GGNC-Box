using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EL4 : MonoBehaviour
{
    public GameObject C1N;
    public GameObject C1F;
    public GameObject C2N;
    public GameObject C2F;
    public GameObject C3N;
    public GameObject C3F;

    public void Start()
    {
        if (PlayerPrefs.GetInt("EL04C1F", 0) == 0)
        {
            C1F.SetActive(true);
        }
        else
        {
            C1N.SetActive(true);
        }
        if (PlayerPrefs.GetInt("EL04C2F", 0) == 0)
        {
            C2F.SetActive(true);
        }
        else
        {
            C2N.SetActive(true);
        }
        if (PlayerPrefs.GetInt("EL04C3F", 0) == 0)
        {
            C3F.SetActive(true);
        }
        else
        {
            C3N.SetActive(true);
        }
    }
}
