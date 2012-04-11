#import "BCFAds.h"

// Converts C style string to NSString

NSString* CreateNSString (const char* string) {
    if (string)
        return [NSString stringWithUTF8String: string];
    else
        return [NSString stringWithUTF8String: ""];
}

void BCFAdsUnityiOSWrapper_registerInstall(const char* appId) {
    [BCFAds registerInstallWithAppID:CreateNSString(appId) withDelegate:nil];
}

void BCFAdsUnityiOSWrapper_showPopup(const char* appId) {
	// This code may be refactored to just show the popup (without
	// registering the device) if the iOS SDK gets fixed in order
	// not to require it.
    [BCFAds showPopupWithAppID:CreateNSString(appId) withDelegate:nil];
}
