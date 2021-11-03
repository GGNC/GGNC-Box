using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E4C2 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("EL04C2F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("EL04C2", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("EL04C2", 1);

        }

    }
}
