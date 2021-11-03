using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;


[RequireComponent(typeof(VG_GoogleAdmob))]
public class VG_RequestADS : MonoBehaviour {

	VG_GoogleAdmob admob;

	public bool Interstitial;
	public bool RewardBasedVideo;
	public int money;
	public int reward = 2;
	public int reward1;

	public bool Banner;
	public AdPosition BannerPostion;

	


	void Start () {
		admob = GetComponent<VG_GoogleAdmob>();
		StartCoroutine(RequestAds());
	
	}
	
	public IEnumerator RequestAds(){
		yield return new WaitForSeconds(1f);
		if (RewardBasedVideo){
			admob.RequestRewardBasedVideo();
		}
		if (Interstitial){
			admob.RequestInterstitial();
		}
		if (Banner){
			admob.RequestBanner(BannerPostion);
		}
	}
	public void Reward()
    {
		money = PlayerPrefs.GetInt("LO", 0);
		reward1 = money + reward;
		PlayerPrefs.SetInt("LO", reward1);

    }
}