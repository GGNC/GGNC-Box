using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyLevel02 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("EL02C1", 0) == 1)
            {
                PlayerPrefs.SetInt("EL02C1F", 1);

            }
            if (PlayerPrefs.GetInt("EL02C2", 0) == 1)
            {
                PlayerPrefs.SetInt("EL02C2F", 1);

            }
            if (PlayerPrefs.GetInt("EL02C3", 0) == 1)
            {
                PlayerPrefs.SetInt("EL02C3F", 1);

            }
            PlayerPrefs.SetInt("EL2", 1);
        }

    }
}
