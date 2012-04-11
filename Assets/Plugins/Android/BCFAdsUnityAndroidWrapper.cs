using UnityEngine;
using System;
using System.Runtime.InteropServices;

namespace BCFAds
{
	public class BCFAdsUnityAndroidWrapper
	{

		public static void CallAndroidMethod (String method, String appId)
		{
			#if UNITY_ANDROID
			AndroidJavaObject activity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject> ("currentActivity");
			AndroidJavaClass bcfAds = new AndroidJavaClass ("com.bcfg.adsclient.BCFAds");
			bcfAds.CallStatic (method, activity, appId);
			#endif
		}
		
	}
}

