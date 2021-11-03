using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AddsScript : MonoBehaviour
{
    private BannerView Adds;
    public string bannerID = "ca-app-pub-3940256099942544/6300978111";
    public AdPosition position;
  
    void Start()
    {
        MobileAds.Initialize(GetAdds => { });
        bannerAdds();
    }

    public void bannerAdds()
    {
        Adds = new BannerView(bannerID, AdSize.SmartBanner, position);
        AdRequest Newadd = new AdRequest.Builder().Build();
        Adds.LoadAd(Newadd);
    }
}
