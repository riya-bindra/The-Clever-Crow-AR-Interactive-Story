using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class MouseyAnimation2 : MonoBehaviour
{
    [SerializeField] GameObject emptyStartButton;
    [SerializeField] Button startButton;
    [SerializeField] GameObject backgroundAudio;
    [SerializeField] GameObject bread;
    [SerializeField] TextMeshProUGUI txt; 
    AudioSource backgroundAudioSource;
    Animator anim;
    public GameObject crow;
    CrowAnimation crowAnimationObject;
    Animator crowAnimator;
    [SerializeField] GameObject nextScene;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Button strt = startButton.GetComponent<Button>();
        backgroundAudioSource = backgroundAudio.GetComponent<AudioSource>();
        strt.onClick.AddListener(TaskOnClick);

        crowAnimator = crow.GetComponent<Animator>();

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
    }

    public void TakeActionOnUserSpeech2(string actionInput)
    {
        switch(actionInput)
        {
            case "User ask-matter":
                anim.SetBool("User asked whats the matter", true);
                new WaitForSeconds(5);
                txt.enabled = false;
                break;
            case "Not Hungry":
                anim.SetBool("User spoke not hungry", true);
                new WaitForSeconds(5);
                txt.enabled = false;
                break;
            case "Whats it":
                anim.SetBool("User asked what is it", true);
                new WaitForSeconds(5);
                txt.enabled = false;
                break;
        }
    }
    public void CrowCawing()
    {
        anim.SetBool("Crow is Cawing", true);
    }
    public void TurnaBit()
    {
        anim.SetBool("Turn", true);
    }

    void SitOnTree()
    {
        crowAnimator.SetBool("Sit On Tree", true);
    }
    public void TurnTowardsTap()
    {
        anim.SetBool("Turn Towards Tap", true);
    }
    void CallTextWhyWhatHappened()
    {
        txt.text = "Ask- \"Why? What happened?\"";
        txt.enabled = true;
    }
    void CallTextNotHungry()
    {
        txt.text = "Speak- \"The crow is not hungry!\"";
        txt.enabled = true;
    }
    void CallTextWhatIsIt()
    {
        txt.text="Ask- \"What is it?\"";
        txt.enabled = true;
    }

    void SetCrowToCaww()
    {
        crowAnimator.SetBool("Look Around Caw", true);
    }

    public void TurnTowardsTree()
    {
        anim.SetBool("Turn Towards Tree", true);
    }
    void NextScene2()
    {
        nextScene.SetActive(true);
    }
    public void OnClickNextScene2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
