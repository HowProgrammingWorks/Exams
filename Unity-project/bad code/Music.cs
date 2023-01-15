using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource AudioS;
    // Start is called before the first frame update
    public void OnApplicationFocus(bool focus)
    {
        //MusicI = GameObject.Find("Music(Clone)");
        AudioS.UnPause();
    }

    public void OnApplicationPause(bool focus)
    {
        AudioS.UnPause();
    }

}
