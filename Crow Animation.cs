using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowAnimation : MonoBehaviour
{
    Animator anim;
    AudioSource crowAudioSource;
    [SerializeField]AudioClip crowCaw;
    [SerializeField] MouseyAnimation2 mouseyAnim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        crowAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LandOnTomato()
    {
        anim.SetBool("Land on Tomato", true);
    }
    void CrowCaw()
    {
        crowAudioSource.clip =crowCaw;
        crowAudioSource.Play();
    }

    void CallMouseyWalkTowardsFood()
    {
        mouseyAnim.CrowCawing();
    }
    void TurnMouseyTowardsTap()
    {
        mouseyAnim.TurnTowardsTap();
    }

    void TurnMouseyTowardsTree()
    {
        mouseyAnim.TurnTowardsTree();
    }
    void TurnABitToMousey()
    {
        mouseyAnim.TurnaBit();
    }
}
