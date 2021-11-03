using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rewarded : MonoBehaviour
{
    public string RewardedAddId = "ca-app-pub-3940256099942544/5224354917";
    public RewardedAd RewardedAdds;
    public int reward ;
    public int money ;
    public void Start()
    {
        MobileAds.Initialize(GetAdds => { });
        this.RewardedAdds = new RewardedAd(RewardedAddId);
        AdRequest RewerdedAdd = new AdRequest.Builder().Build();
        this.RewardedAdds.LoadAd(RewerdedAdd);
        
    }
    public void UserChoseToWatchAd()
    {
        if (this.RewardedAdds.IsLoaded())
        {
            this.RewardedAdds.Show();
        }
    }
    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
       
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
       
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        reward = 4;
        money = PlayerPrefs.GetInt("LO", 0) + reward;
        PlayerPrefs.SetInt("LO", money);
    }

}
