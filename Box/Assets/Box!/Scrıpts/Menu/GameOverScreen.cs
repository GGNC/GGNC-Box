using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Transform player;
    public int way = 190;
    public float comp;
    public float way1;
    public Text SCR;
    public Slider Comp;
    public void Update()
    {
        comp = player.transform.position.z;
        way1 = (100 * comp) / way;
        SCR.text = "%"+way1.ToString("0");
        Comp.value = way1*0.01f;
    }
}
