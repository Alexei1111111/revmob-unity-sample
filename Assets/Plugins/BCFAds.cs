using UnityEngine;
using System;
using System.Runtime.InteropServices;

namespace BCFAds
{
	public class SDK
	{

		#if UNITY_IPHONE
		[DllImport("__Internal")]
		private static extern void BCFAdsUnityiOSWrapper_registerInstall (string appId);
		[DllImport("__Internal")]
		private static extern void BCFAdsUnityiOSWrapper_showPopup (string appId);
		#endif

		public static void RegisterInstall (String appId)
		{
			#if UNITY_IPHONE
			BCFAdsUnityiOSWrapper_registerInstall (appId);
			#elif UNITY_ANDROID
			BCFAdsUnityAndroidWrapper.CallAndroidMethod("registerInstall", appId);
			#endif
		}

		public static void ShowPopup (String appId)
		{
			#if UNITY_IPHONE
			BCFAdsUnityiOSWrapper_showPopup (appId);
			#elif UNITY_ANDROID
			BCFAdsUnityAndroidWrapper.CallAndroidMethod("showPopup", appId);
			#endif
		}		
		
	}
}

