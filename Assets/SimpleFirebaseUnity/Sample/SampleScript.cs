// Last update: 2020-07-28  (by Abdullah Ba Mashmos)

using UnityEngine;

using SimpleFirebaseUnity;
using SimpleFirebaseUnity.MiniJSON;

using System.Collections.Generic;
using System.Collections;
using System;


public class SampleScript : MonoBehaviour
{

    static int debug_idx = 0;
    [SerializeField]private int lastUpdatedStatus;
    public GameObject mouth;
    mouthMovement status;


    // Use this for initialization
    void Start()
    {
        status = mouth.GetComponent<mouthMovement>();
        StartCoroutine(Tests());
    }


    IEnumerator Tests()
    {
        // README
              
        // Inits Firebase using Firebase Secret Key as Auth
        // The current provided implementation not yet including Auth Token Generation
        // If you're using this sample Firebase End, 
        // there's a possibility that your request conflicts with other simple-firebase-c# user's request
        Firebase firebase = Firebase.CreateNew("https://hologram-covid-19.firebaseio.com/", "AIzaSyBjFT_idBtwpI4agq0BwV_QKjAY99MJR78");


        // Get child node from firebase, if false then all the callbacks are not inherited.
        //Firebase temporary = firebase.Child("temporary", true);
        Firebase lastUpdate = firebase.Child("lastUpdate");

        lastUpdate.SetValue(0);

        // Make observer on "last update" time stamp
        FirebaseObserver observer = new FirebaseObserver(lastUpdate, 1f);
        observer.OnChange += (Firebase sender, DataSnapshot snapshot) =>
        {
            Debug.Log("[OBSERVER] Last updated changed to: " + snapshot.Value<long>());
            status.status = (int)snapshot.Value<long>();
            //lastUpdatedStatus = (int)snapshot.Value<long>();

        };
        observer.Start();
        Debug.Log("[OBSERVER] FirebaseObserver on " + lastUpdate.FullKey + " started!");

        yield return null;      

    }
    /*public int GetStatus()
    {
        return lastUpdatedStatus;
    }*/

    }