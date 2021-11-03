using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N4C1 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("NL04C1F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("NL04C1", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("NL04C1", 1);

        }

    }
}
