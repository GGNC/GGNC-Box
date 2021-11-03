using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardLevel02 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("HL02C1", 0) == 1)
            {
                PlayerPrefs.SetInt("HL02C1F", 1);

            }
            if (PlayerPrefs.GetInt("HL02C2", 0) == 1)
            {
                PlayerPrefs.SetInt("HL02C2F", 1);

            }
            if (PlayerPrefs.GetInt("HL02C3", 0) == 1)
            {
                PlayerPrefs.SetInt("HL02C3F", 1);

            }
            PlayerPrefs.SetInt("HL2", 1);
        }

    }
}
