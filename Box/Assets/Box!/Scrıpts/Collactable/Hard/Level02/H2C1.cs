using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2C1 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("HL02C1F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("HL02C1", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("HL02C1", 1);

        }

    }
}
