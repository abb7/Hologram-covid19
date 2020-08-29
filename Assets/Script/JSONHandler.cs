using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;

public class JSONHandler : MonoBehaviour
{
    public int localStatus = 0;

    private void Start()
    {
        GetStatus();
    }

    public void OnButtonGet()
    {
        GetStatus();
    }

    private void GetStatus()
    {
        RestClient.Post<int>($"https://hologram-covid-19.firebaseio.com/status/JA5cH0XHANIWmPbl06eP/status.json", 5);
        /*RestClient.Get<int>($"https://hologram-covid-19.firebaseio.com/status/JA5cH0XHANIWmPbl06eP/status.json").Then(response =>
        {
            localStatus = response;
            Debug.Log(localStatus);
        });*/
    }

}
