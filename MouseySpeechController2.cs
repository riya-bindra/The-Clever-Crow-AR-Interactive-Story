using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseySpeechController2 : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource mouseyAudioSource;
    [SerializeField] AudioClip welcomeBack;
    [SerializeField] AudioClip lookThere;
    [SerializeField] AudioClip flyingAround;
    [SerializeField] AudioClip seemsHungry;
    [SerializeField] AudioClip crowCawing;
    [SerializeField] AudioClip observeHim;
    [SerializeField] AudioClip sliceOfBread;
    [SerializeField] AudioClip youAreRight;
    [SerializeField] GameObject crow;
    [SerializeField]CrowAnimation crowAnimationObject;
    [SerializeField] AudioClip notHungry;
    [SerializeField] AudioClip iHaveGot;
    [SerializeField] AudioClip thirsty;
    [SerializeField] AudioClip youSee;

    void Start()
    {
        mouseyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void WelcomeBack()
    {
        mouseyAudioSource.pitch = 1.5f;
        mouseyAudioSource.clip = welcomeBack;
        mouseyAudioSource.Play();
    }
    void LookThere()
    {
        mouseyAudioSource.clip = lookThere;
        mouseyAudioSource.Play();
    }
    void FlyingSinceMorning()
    {
        mouseyAudioSource.clip = flyingAround;
        mouseyAudioSource.Play();
    }
    void SeemsHungry()
    {
        mouseyAudioSource.clip = seemsHungry;
        mouseyAudioSource.Play();
        crowAnimationObject.LandOnTomato();
    }
    void CrowCawing()
    {
        mouseyAudioSource.clip = crowCawing;
        mouseyAudioSource.Play();
    }
    void ObserveHim()
    {
        mouseyAudioSource.clip = observeHim;
        mouseyAudioSource.Play();
    }
    void SliceofBread()
    {
        mouseyAudioSource.clip = sliceOfBread;
        mouseyAudioSource.Play();
    }
    void YouAreRight()
    {
        mouseyAudioSource.clip = youAreRight;
        mouseyAudioSource.Play();
    }
    void NotHungry()
    {
        mouseyAudioSource.clip = notHungry;
        mouseyAudioSource.Play();
        
    }
    void IHaveGot()
    {
        mouseyAudioSource.clip = iHaveGot;
        mouseyAudioSource.Play();
    }
    void Thirsty()
    {
        mouseyAudioSource.clip = thirsty;
        mouseyAudioSource.Play();
    }
    void YouSee()
    {
        mouseyAudioSource.clip = youSee;
        mouseyAudioSource.Play();
    }

}
