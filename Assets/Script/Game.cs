using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    private string qrLinkUrl;
    public string WEB_URL = "";
    public string status;


    // Start is called before the first frame update
    


    /*IEnumerator DownloadStatus(string MediaUrl)
    {

        UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isHttpError)
        {
            Debug.Log(request.error);

        }
        else
        {
            //here where the status value would be recived

        }

    }*/


}
