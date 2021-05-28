using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource flute_1;
    public AudioSource violin_1;
    public AudioSource organ_1;
    public AudioSource drum_1;
    public AudioSource trumpet_1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TriggerFlute_1()
    {
        if (!flute_1.isPlaying)
        {
            flute_1.Play();
        } else
        {
            flute_1.Stop();
        }
    }

    public void TriggerViolin()
    {
        if (!violin_1.isPlaying)
        {
            violin_1.Play();
        }
        else
        {
            violin_1.Stop();
        }
    }

    public void TriggerOrgan()
    {
        if (!organ_1.isPlaying)
        {
            organ_1.Play();
        }
        else
        {
            organ_1.Stop();
        }
    }

    public void TriggerDrum()
    {
        if (!drum_1.isPlaying)
        {
            drum_1.Play();
        }
        else
        {
            drum_1.Stop();
        }
    }

    public void TriggerTrumpet()
    {
        if (!trumpet_1.isPlaying)
        {
            trumpet_1.Play();
        }
        else
        {
            trumpet_1.Stop();
        }
    }

}