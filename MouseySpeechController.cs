using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseySpeechController : MonoBehaviour
{
    AudioSource mouseyAudioSource;//will contain mousey's audio source component
   [SerializeField]AudioClip introClip;
   [SerializeField] AudioClip areYouReady;
    [SerializeField] AudioClip thatsGreat;
    [SerializeField] AudioClip comeFollowMe;
    [SerializeField] AudioClip pleaseOpenDoor;
    [SerializeField] MouseyAnimation mouseyAnimationObject;
    [SerializeField] AudioClip thankYou;
    [SerializeField] AudioClip tooShort;
    [SerializeField] AudioClip tellStory;
    [SerializeField] AudioClip takeGarden;
 



    void IntroSpeech()
    {
        mouseyAudioSource=GetComponent<AudioSource>();
        mouseyAudioSource.clip = introClip;
        mouseyAudioSource.pitch = 1.5f;
        mouseyAudioSource.Play();
    }
    void AreYouReady()
    {
        mouseyAudioSource.clip = areYouReady;
        mouseyAudioSource.Play();
    }
    void ThatsGreat()
    {
        mouseyAudioSource.clip = thatsGreat;
        mouseyAudioSource.Play();
    }
    void ComeFollowMe()
    {
        mouseyAudioSource.clip = comeFollowMe;
        mouseyAudioSource.Play();
     }
    
    void AskToOpenDoor()
    {
        mouseyAudioSource.clip = pleaseOpenDoor;
        mouseyAudioSource.Play();
    }

    void ThankYou()
    {
        mouseyAudioSource.clip = thankYou;
        mouseyAudioSource.Play();
    }

    void TooShort()
    {
        mouseyAudioSource.clip = tooShort;
        mouseyAudioSource.Play();
    }
    void TellYouStory()
    {
        mouseyAudioSource.clip = tellStory;
        mouseyAudioSource.Play();
    }
    void TakeYouToGarden()
    {
        mouseyAudioSource.clip = takeGarden;
        mouseyAudioSource.Play();
    }


}
