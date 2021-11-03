using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject Free;
    public Text timer;
    public GameObject timer1;
    public float MilisecondToWait = 900000f;
    private Button RewardButton;
    private ulong LastRewardTaken;
    private void Start()
    {
        RewardButton = GetComponent<Button>();
        LastRewardTaken = ulong.Parse(PlayerPrefs.GetString("LastRewardTaken"));
        if (!IsButtonReady())
        {
            RewardButton.interactable = false;
            Free.SetActive(false);
            timer1.SetActive(true);
            GetComponent<ButtonADMOB>().enabled = false;
        }
    }
    private void Update()
    {
        if(!RewardButton.IsInteractable())
        {
            if(IsButtonReady())
            {
                RewardButton.interactable = true;
                Free.SetActive(true);
                timer1.SetActive(false);
                return;
            }

            CountTime();
        }
    }
    public void ButtonClick()
    {
        LastRewardTaken = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("LastRewardTaken", DateTime.Now.Ticks.ToString());
        RewardButton.interactable = false;
        Free.SetActive(false);
        timer1.SetActive(true);
        GetComponent<ButtonADMOB>().enabled = false;

    }
    public bool IsButtonReady()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - LastRewardTaken);
        ulong milisecond = diff / TimeSpan.TicksPerMillisecond;
        float secondsLeft = (MilisecondToWait - milisecond) / 1000f;
        if (secondsLeft < 0)
        {
            GetComponent<ButtonADMOB>().enabled = true;
            return true;
        }

        return false;
    }
    public void CountTime()
    {
        ulong diff = ((ulong)DateTime.Now.Ticks - LastRewardTaken);
        ulong milisecond = diff / TimeSpan.TicksPerMillisecond;
        float secondsLeft = (MilisecondToWait - milisecond) / 1000f;
        string r = "";
        //minutes
        r += ((int)secondsLeft / 60).ToString("00") + "m ";
        //seconds
        r += (secondsLeft % 60).ToString("00") + "s";
        timer.text = r;
    }
}
