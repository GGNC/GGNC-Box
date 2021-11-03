using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1C2 : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("EL01C2F", 0) == 1)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            PlayerPrefs.SetInt("EL01C2", 0);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("EL01C2", 1);

        }

    }
}
