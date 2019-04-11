using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigvegas : MonoBehaviour
{
    // Start is called before the first frame update

    Animator anim;
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Dance()
    {
        audioData.Play(0);
        anim.SetBool("dance", true);
    }
}
