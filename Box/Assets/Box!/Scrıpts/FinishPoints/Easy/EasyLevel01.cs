using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyLevel01 : MonoBehaviour
{
 
    
    public void OnCollisionEnter(Collision Finishpoint)
    {
        if (Finishpoint.collider.tag == "Player")
        {
            if(PlayerPrefs.GetInt("EL01C1",0)==1)
            {
                PlayerPrefs.SetInt("EL01C1F", 1);
              
            }
            if (PlayerPrefs.GetInt("EL01C2", 0) == 1)
            {
                PlayerPrefs.SetInt("EL01C2F", 1);
             
            }
            if (PlayerPrefs.GetInt("EL01C3", 0) == 1)
            {
                PlayerPrefs.SetInt("EL01C3F", 1);
           
            }
            PlayerPrefs.SetInt("EL1", 1);
        }
       
    }
   
}


