using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalLevel04 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("NL04C1", 0) == 1)
            {
                PlayerPrefs.SetInt("NL04C1F", 1);

            }
            if (PlayerPrefs.GetInt("NL04C2", 0) == 1)
            {
                PlayerPrefs.SetInt("NL04C2F", 1);

            }
            if (PlayerPrefs.GetInt("NL04C3", 0) == 1)
            {
                PlayerPrefs.SetInt("NL04C3F", 1);

            }
            PlayerPrefs.SetInt("NL4", 1);
        }

    }
}
