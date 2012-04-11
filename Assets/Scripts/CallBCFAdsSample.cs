using UnityEngine;
using System.Collections;

public class CallBCFAdsSample : MonoBehaviour {

	// Use this for initialization
	void Start () {

		#if UNITY_IPHONE

		BCFAds.SDK.ShowPopup("Your iOS App Id here.");

		#elif UNITY_ANDROID

		BCFAds.SDK.ShowPopup("Your android App Id here");

		#endif
	}

	// Update is called once per frame
	void Update () {

	}
}
