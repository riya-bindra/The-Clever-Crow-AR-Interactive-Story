using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gate : MonoBehaviour
{
    [SerializeField]Button openButton;
    [SerializeField] GameObject emptyOpen;
    [SerializeField] GameObject mousey;
    Animator mouseyAnimator;
    Animator gateAnimator;

    // Start is called before the first frame update
    void Start()
    {
        Button open = openButton.GetComponent<Button>();
        open.onClick.AddListener(TaskOnOpen);
        gateAnimator = GetComponent<Animator>();
        mouseyAnimator = mousey.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void TaskOnOpen()
    {
        Destroy(emptyOpen);
        gateAnimator.SetBool("Open Door", true);
        mouseyAnimator.SetBool("User clicked on Open Door", true);
    }

}
