using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalLevel02 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("NL02C1", 0) == 1)
            {
                PlayerPrefs.SetInt("NL02C1F", 1);

            }
            if (PlayerPrefs.GetInt("NL02C2", 0) == 1)
            {
                PlayerPrefs.SetInt("NL02C2F", 1);

            }
            if (PlayerPrefs.GetInt("NL02C3", 0) == 1)
            {
                PlayerPrefs.SetInt("NL02C3F", 1);

            }
            PlayerPrefs.SetInt("NL2", 1);
        }

    }
}
