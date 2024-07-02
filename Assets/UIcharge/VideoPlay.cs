using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
namespace ns
{
    ///<summary>
    ///
    ///<summary>
    public class VideoPlay : MonoBehaviour
    {
        public VideoClip videoClip;
        private VideoPlayer player;
        public GameObject gameobject;
        public GameObject picture;
        void Start ()
        {
            player = GetComponent<VideoPlayer>();
            player.clip = videoClip;
            player.Play();
            picture .SetActive(false);
        }
        private void Update ()
        {
            player.loopPointReached += OnVideoEnd;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameobject.SetActive(false);
                picture.SetActive(true);
            }
        }
        private void OnVideoEnd(VideoPlayer vp)
        {
            gameobject.SetActive(false);
            picture.SetActive(true);
        }
        
    }
}

