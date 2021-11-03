using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CforInfinity : MonoBehaviour
{
    public void OnCollisionEnter(Collision Cforinfinty)
    {
       if(Cforinfinty.collider.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
