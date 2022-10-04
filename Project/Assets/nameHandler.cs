using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class nameHandler : MonoBehaviour
{
    public GameObject videoPlayerGO;
    public VideoClip vc1;

   void Start()
{
    videoPlayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc1;
    videoPlayerGO.gameObject.GetComponent<VideoPlayer>().Play();
}
}
