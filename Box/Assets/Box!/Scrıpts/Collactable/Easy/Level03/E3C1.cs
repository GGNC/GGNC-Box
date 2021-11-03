using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E3C1 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("EL03C1F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("EL03C1", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("EL03C1", 1);

        }

    }
}
