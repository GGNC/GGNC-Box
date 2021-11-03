using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalLevel01 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("NL01C1", 0) == 1)
            {
                PlayerPrefs.SetInt("NL01C1F", 1);

            }
            if (PlayerPrefs.GetInt("NL01C2", 0) == 1)
            {
                PlayerPrefs.SetInt("NL01C2F", 1);

            }
            if (PlayerPrefs.GetInt("NL01C3", 0) == 1)
            {
                PlayerPrefs.SetInt("NL01C3F", 1);

            }
            PlayerPrefs.SetInt("NL1", 1);
        }

    }
}
