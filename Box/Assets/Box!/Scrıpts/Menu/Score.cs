using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    public Text ScoreText1;
    public Text HighScoreText;
    public Text HighScoreText1;
    public GameObject SpawnPoint;
    public float SCR;

    private void Start()
    {
        
        HighScoreText.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        HighScoreText1.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        
}

    void Update()
    {
        ScoreText1.text = player.position.z.ToString("0");
        ScoreText.text = player.position.z.ToString("0");
        HighScoreText1.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
        SCR = player.transform.position.z;
        if (PlayerPrefs.GetFloat("HighScore") < SCR)
        { 
            PlayerPrefs.SetFloat("HighScore", SCR);
            HighScoreText.text = SCR.ToString("0");

        }
        if ( player.position.z>50)
        {
            SpawnPoint.SetActive(false);
        }
        if (player.position.x < -3.99 || player.position.x > 3.99)
        {
            player.GetComponent<Rigidbody>().useGravity = true;
        }
   
    }
}
