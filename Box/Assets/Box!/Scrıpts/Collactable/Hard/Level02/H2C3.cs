using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2C3 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("HL02C3F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("HL02C3", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("HL02C3", 1);

        }

    }
}
