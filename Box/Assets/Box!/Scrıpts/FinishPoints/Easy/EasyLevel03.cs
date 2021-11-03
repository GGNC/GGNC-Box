using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyLevel03 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("EL03C1", 0) == 1)
            {
                PlayerPrefs.SetInt("EL03C1F", 1);

            }
            if (PlayerPrefs.GetInt("EL03C2", 0) == 1)
            {
                PlayerPrefs.SetInt("EL03C2F", 1);

            }
            if (PlayerPrefs.GetInt("EL03C3", 0) == 1)
            {
                PlayerPrefs.SetInt("EL03C3F", 1);

            }
            PlayerPrefs.SetInt("EL3", 1);
        }

    }
}
