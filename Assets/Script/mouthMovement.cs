using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouthMovement : MonoBehaviour
{
    [SerializeField] Texture StrightMouth;
    [SerializeField] Texture openMouth;

    float timer = 0;



    public int status;


    void Start()
    {
        transform.GetComponent<Renderer>().material.mainTexture = StrightMouth;
    }

    //Update is called once per frame
    void Update()
    {
        if (status == 1) // isTalking
        {
            if (timer < 0.2)
            {
                transform.GetComponent<Renderer>().material.mainTexture = StrightMouth;
            }
            else if (timer > 0.2 && timer < 0.4)
            {
                transform.GetComponent<Renderer>().material.mainTexture = openMouth;

            }
            else if (timer > 0.4)
            {
                timer = 0;
            }
            timer += Time.deltaTime;
        }
        else
        {
            transform.GetComponent<Renderer>().material.mainTexture = StrightMouth;
        }


    }

}
