using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MouseyAnimation3 : MonoBehaviour
{
    [SerializeField] GameObject emptyStartButton;
    [SerializeField] Button startButton;
    [SerializeField] GameObject backgroundAudio;
    AudioSource backgroundAudioSource;
    Animator anim;
    [SerializeField]GameObject crow;
    CrowAnimation2 crowAnimationObject2;
    [SerializeField]Animator crowAnim;
    [SerializeField] AudioClip crowCaw;
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] GameObject feedbackScene;

    AudioSource crowAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        Button strt = startButton.GetComponent<Button>();
        backgroundAudioSource = backgroundAudio.GetComponent<AudioSource>();
        strt.onClick.AddListener(TaskOnClick);
        anim = GetComponent<Animator>();
        crowAnim = crow.GetComponent<Animator>();
        crowAudioSource = crow.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick()
    {
        Destroy(emptyStartButton);
        backgroundAudioSource.Stop();
        anim.SetBool("User clicked on Start", true);
        anim.Play("ThumbsUp-Welcome Back");
    }

    public void TakeActionOnUserSpeech3(string actionInput)
    {
        switch (actionInput)
        {
            case "No":
                anim.SetBool("User said no",true);
                new WaitForSeconds(5);
                txt.enabled = false;
                break;
            case "Thinking":
                anim.SetBool("User asked thinking", true);
                anim.Play("Talking-Not Drinking");
                new WaitForSeconds(5);
                txt.enabled = false;
                break;
            case "Yes he did":
                anim.SetBool("User said yes", true);
                crowAnim.SetBool("User said yes", true);
                new WaitForSeconds(5);
                txt.enabled = false;
                break;
            case "Why doing so":
                anim.SetBool("User asked why doing so", true);
                anim.Play("Left Half Turn");
                crowAnim.SetBool("User asked why doing so", true);
                crowAnim.SetBool("User said yes", true);
                new WaitForSeconds(5);
                txt.enabled = false;
                break;
        }
    }
    void CrowStartFly()
    {
        crowAnim.Play("Fly To the Stones");
    }
    void CrowCaw()
    {
        crowAudioSource.clip = crowCaw;
        crowAudioSource.Play();
    }

    void CrowPickStone()
    {
        crowAnim.SetBool("Pick Up Stone", true);
    }
    public void NervousMousey()
    {
        anim.Play("Nervously Look Around");
    }
    void ExplanationEnds()
    {
        crowAnim.SetBool("Mousey Explanation Ends",true);
    }
    void CallTextIDont()
    {
        txt.text = "Speak- \"No, I don't!\"";
        txt.enabled = true;
    }

    void CallTextWhatThinking()
    {
        txt.text = "Ask- \"What are you thinking?\"";
        txt.enabled = true;
    }

    void CallTextYesHeDid()
    {
        txt.text = "Speak- \"Yes, he did!\"";
        txt.enabled = true;
    }

    void CallTextWhyDoing()
    {
        txt.text = "Ask- \"Why is he doing so?\"";
        txt.enabled = true;
    }
    void FeedbackScene()
    {
        feedbackScene.SetActive(true);
    }
    public void OnClickFeedbackScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
