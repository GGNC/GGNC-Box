using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4C3 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("EL04C3F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("EL04C3", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("EL04C3", 1);

        }

    }
}
