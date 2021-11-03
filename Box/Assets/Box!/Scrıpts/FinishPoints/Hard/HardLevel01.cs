using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardLevel01 : MonoBehaviour
{
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if (PlayerPrefs.GetInt("HL01C1", 0) == 1)
            {
                PlayerPrefs.SetInt("HL01C1F", 1);

            }
            if (PlayerPrefs.GetInt("HL01C2", 0) == 1)
            {
                PlayerPrefs.SetInt("HL01C2F", 1);

            }
            if (PlayerPrefs.GetInt("HL01C3", 0) == 1)
            {
                PlayerPrefs.SetInt("HL01C3F", 1);

            }
            PlayerPrefs.SetInt("HL1", 1);
        }

    }
}
