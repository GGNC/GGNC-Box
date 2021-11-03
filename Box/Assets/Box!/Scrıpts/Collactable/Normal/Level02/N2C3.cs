using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N2C3 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("NL02C3F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("NL02C3", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("NL02C3", 1);

        }

    }
}
