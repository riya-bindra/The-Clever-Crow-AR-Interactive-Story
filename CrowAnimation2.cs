using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowAnimation2 : MonoBehaviour
{
    [SerializeField] GameObject SKCrowMouth;
    [SerializeField] GameObject[] stones;
    [SerializeField] GameObject water;
    [SerializeField] GameObject mousey;
    [SerializeField] GameObject backgroundAudio;
    [SerializeField] AudioClip fillSound;
    [SerializeField] AudioClip crowCaw;

    Animator mouseyAnim;
    Animator waterAnim;
    Animator anim;
    AudioSource backgroundAudioSource;
    AudioSource crowAudioSource;
    //Animator stone1Anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        waterAnim = water.GetComponent<Animator>();
        mouseyAnim = mousey.GetComponent<Animator>();
        backgroundAudioSource = backgroundAudio.GetComponent<AudioSource>();
        crowAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrowCaw()
    {
        crowAudioSource.clip = crowCaw;
        crowAudioSource.Play();
    }
    void LiftStone1()
    {
        stones[0].transform.SetParent(SKCrowMouth.transform);
    }
    void LiftStone2()
    {
        stones[1].transform.SetParent(SKCrowMouth.transform);
    }
    void LiftStone3()
    {
        stones[2].transform.SetParent(SKCrowMouth.transform);
    }
    void LiftStone4()
    {
        stones[3].transform.SetParent(SKCrowMouth.transform);
    }


    void DropStone1()
    {
        Destroy(stones[0]);
    }
    void DropStone2()
    {
        Destroy(stones[1]);
    }
    void DropStone3()
    {
        Destroy(stones[2]);
        water.transform.position = new Vector3(0, 0.688f, 0);
        water.transform.localScale = new Vector3(0.701f, 0.0079f, 0.701f);
    }
    void DropStone4()
    {
        Destroy(stones[3]);
        waterAnim.Play("Water to the brim");
       // backgroundAudioSource.clip = fillSound;
        backgroundAudioSource.PlayOneShot(fillSound);
    }

    public void MouseyNervous()
    {
        mouseyAnim.Play("Nervously Look Around");
    }
    void WaterDown1()
    {
        waterAnim.Play("Water level down 1");
    }
    void MouseyHardWork()
    {
        mouseyAnim.SetBool("Hard Work",true);
        mouseyAnim.Play("Talk-Expression of Joy");
    }
}
