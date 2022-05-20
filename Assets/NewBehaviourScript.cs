using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class NewBehaviourScript : MonoBehaviour
{
    VideoPlayer vp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onplayVideo(){
        vp = GetComponent<VideoPlayer>();
        vp.url = System.IO.Path.Combine(Application.streamingAssetsPath, "CREA_01(640).mp4");
        vp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
