using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class N1C1 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("NL01C1F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("NL01C1", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("NL01C1", 1);

        }

    }
}
