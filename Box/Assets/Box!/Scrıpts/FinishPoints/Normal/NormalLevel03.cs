using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalLevel03 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("NL03C1", 0) == 1)
            {
                PlayerPrefs.SetInt("NL03C1F", 1);

            }
            if (PlayerPrefs.GetInt("NL03C2", 0) == 1)
            {
                PlayerPrefs.SetInt("NL03C2F", 1);

            }
            if (PlayerPrefs.GetInt("NL03C3", 0) == 1)
            {
                PlayerPrefs.SetInt("NL03C3F", 1);

            }
            PlayerPrefs.SetInt("NL3", 1);
        }

    }
}
