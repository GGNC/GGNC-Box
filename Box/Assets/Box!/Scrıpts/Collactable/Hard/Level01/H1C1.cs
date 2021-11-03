using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H1C1 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("HL01C1F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("HL01C1", 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("HL01C1", 1);

        }

    }
}
