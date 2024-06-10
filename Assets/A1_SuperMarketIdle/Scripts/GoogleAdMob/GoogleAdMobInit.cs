using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GoogleMobileAds.Api;
using System;
using UnityEngine.Events;
using GoogleMobileAds.Common;

namespace MyGoogleAdMob
{
    public class GoogleAdMobInit : MonoBehaviour
    {
        [HideInInspector] public UnityEvent OnInitialized = new UnityEvent();
        public bool isInitialized = false;

        public static GoogleAdMobInit Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            MobileAds.SetiOSAppPauseOnBackground(true);

            RequestConfiguration requestConfiguration = new RequestConfiguration.Builder().SetSameAppKeyEnabled(true).build();
            MobileAds.SetRequestConfiguration(requestConfiguration);

            MobileAdsEventExecutor.Initialize();
            MobileAds.Initialize(HandleInitCompleteAction);
        }

        private void HandleInitCompleteAction(InitializationStatus initStatus)
        {
            Debug.Log("Mobile Ads On Complete");
            isInitialized = true;
            OnInitialized?.Invoke();
        }
    }
}
