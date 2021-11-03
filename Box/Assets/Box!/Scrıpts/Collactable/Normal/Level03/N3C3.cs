using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N3C3 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("NL03C3F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("NL03C3", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("NL03C3", 1);

        }

    }
}
