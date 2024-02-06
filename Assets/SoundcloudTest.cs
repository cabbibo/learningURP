using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Networking;

[ExecuteAlways]
public class SoundcloudTest : MonoBehaviour
{
        public string usersURL = "https://api.soundcloud.com/users/3207?client_id=YOUR_CLIENT_ID";

    void OnEnable(){
        
    
        StartCoroutine(GetRequest(usersURL));
    }


 IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
                    break;
            }
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
