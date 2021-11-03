using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyLevel04 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("EL04C1", 0) == 1)
            {
                PlayerPrefs.SetInt("EL04C1F", 1);

            }
            if (PlayerPrefs.GetInt("EL04C2", 0) == 1)
            {
                PlayerPrefs.SetInt("EL04C2F", 1);

            }
            if (PlayerPrefs.GetInt("EL04C3", 0) == 1)
            {
                PlayerPrefs.SetInt("EL04C3F", 1);

            }
            PlayerPrefs.SetInt("EL4", 1);
        }

    }
}
