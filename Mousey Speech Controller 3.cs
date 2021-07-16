using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseySpeechController3 : MonoBehaviour
{
    [SerializeField] AudioClip welcomeBack;
    [SerializeField] AudioClip whyDancing;
    [SerializeField] AudioClip foundWater;
    [SerializeField] AudioClip notDrinking;
    [SerializeField] AudioClip notThirsty;
    [SerializeField] AudioClip veryLittle;
    [SerializeField] AudioClip whatNearPebbles;
    [SerializeField] AudioClip justDropPebble;
    [SerializeField] AudioClip[] cheerUp;
    [SerializeField] AudioClip couldNotReachWater;
    [SerializeField] AudioClip levelWillRise;
    [SerializeField] AudioClip comeOn;
    [SerializeField] AudioClip expressionOfJoy;
    [SerializeField] AudioClip willWay;
    [SerializeField] AudioClip crowHardWork;
    [SerializeField] AudioClip letsClap;
    static int cheerCount = 0;
    AudioSource mouseyAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        mouseyAudioSource=GetComponent<AudioSource>();
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
    void WhyDancing()
    {
        mouseyAudioSource.clip = whyDancing;
        mouseyAudioSource.Play();
    }
    void FoundWater()
    {
        mouseyAudioSource.clip = foundWater;
        mouseyAudioSource.Play();
    }
    void NotDrinking()
    {
        mouseyAudioSource.clip = notDrinking;
        mouseyAudioSource.Play();
    }
    void NotThirsty()
    {
        mouseyAudioSource.clip = notThirsty;
        mouseyAudioSource.Play();
    }
    void VeryLittleWater()
    {
        mouseyAudioSource.clip = veryLittle;
        mouseyAudioSource.Play();
    }

    void WhatNearPebbles()
    {
        mouseyAudioSource.clip = whatNearPebbles;
        mouseyAudioSource.Play();
    }
    void JustDropPebble()
    {
        mouseyAudioSource.clip = justDropPebble;
        mouseyAudioSource.Play();
    }
    void CheerUp()
    {
        mouseyAudioSource.clip = cheerUp[cheerCount];
        mouseyAudioSource.Play();
        cheerCount += 1;
    }
    void CouldNotReach()
    {
        mouseyAudioSource.clip = couldNotReachWater;
        mouseyAudioSource.Play();
    }
    void LevelWillRise()
    {
        mouseyAudioSource.clip = levelWillRise;
        mouseyAudioSource.Play();
    }
    void ComeOn()
    {
        mouseyAudioSource.clip = comeOn;
        mouseyAudioSource.Play();
    }
    void ExpressionJoy()
    {
        mouseyAudioSource.clip = expressionOfJoy;
        mouseyAudioSource.Play();
    }
    void WillWay()
    {
        mouseyAudioSource.clip = willWay;
        mouseyAudioSource.Play();
    }
    void CrowHardWork()
    {
        mouseyAudioSource.clip =crowHardWork;
        mouseyAudioSource.Play();
    }
    void LetsClap()
    {
        mouseyAudioSource.clip = letsClap;
        mouseyAudioSource.Play();
    }
}
