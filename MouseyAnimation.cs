using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MouseyAnimation : MonoBehaviour
{
    AudioSource beforeStart; //This will contain the audio clip that plays before the user presses Start button.
    [SerializeField] Button startButton;
    Animator anim; //anim will store Mousey's animator 
    public GameObject emptyButton; // This will contain empty gameobject which contains the start button
    AnimatorStateInfo animState;
    public GameObject fence;
    public TextMeshProUGUI txt;
    [SerializeField] GameObject nextScene;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        beforeStart = GetComponent<AudioSource>();
        emptyButton = GameObject.Find("Empty-StartButton");
        anim.SetBool("Before Start", true);
        anim.Play("Base Layer.Hip Hop Dancing",0,0f);
        Button strt = startButton.GetComponent<Button>();
        strt.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void TaskOnClick()   //This will be called when "Start" Button will be clicked.
    {

        beforeStart.Stop();
        Destroy(emptyButton);
        Invoke("MouseyIntroduction", 1);
    }

    void MouseyIntroduction()
    {
        anim.SetBool("Before Start", false);
        anim.SetBool("Mousey Intro", true);
        anim.Play("Base Layer.Hello Waving", 0, 0f);
        anim.SetBool("Mousey Intro Over", true);
    }


    public void TakeActionOnUserSpeech(string actionInput)
    {
        Debug.Log(actionInput);
        switch(actionInput)
        {
            case "User Ready":
                anim.SetBool("User spoke yes I am ready", true);
                new WaitForSeconds(5);
                txt.enabled = false;
                break;
        }
    }

    void CallText()
    {
        txt.enabled = true;
    }
    void NextScene()
    {
        nextScene.SetActive(true);
    }
    public void OnClickNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
