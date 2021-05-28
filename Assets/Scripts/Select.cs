using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{


    public GameObject open;
    public GameObject restless_painting;
    public GameObject sad_painting;
    public GameObject play_painting;
    public GameObject calm_painting;

    public bool restless = false;
    public bool sad = false;
    public bool play = false;
    public bool calm = false;

    public AudioSource restless_painting_audio;
    public AudioSource sad_painting_audio;
    public AudioSource play_painting_audio;
    public AudioSource calm_painting_audio;

    public bool update = false;

    // Start is called before the first frame update
    void Start()
    {
        // calm_painting = GameObject.Find("calm_painting").GetComponent<GameObject>();

        restless_painting.SetActive(false);
        sad_painting.SetActive(false);
        play_painting.SetActive(false);
        calm_painting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(update) { 
            if (restless)
            {
                open.SetActive(false);
                restless_painting.SetActive(true);
                sad_painting.SetActive(false);
                play_painting.SetActive(false);
                calm_painting.SetActive(false);

                restless_painting_audio.Play();
                sad_painting_audio.Stop();
                play_painting_audio.Stop();
                calm_painting_audio.Stop();

                update = false;

            }
            if (sad)
            {
                open.SetActive(false);
                restless_painting.SetActive(false);
                sad_painting.SetActive(true);
                play_painting.SetActive(false);
                calm_painting.SetActive(false);

                restless_painting_audio.Stop();
                sad_painting_audio.Play();
                play_painting_audio.Stop();
                calm_painting_audio.Stop();

                update = false;

            }
            if (play)
            {
                open.SetActive(false);
                restless_painting.SetActive(false);
                sad_painting.SetActive(false);
                play_painting.SetActive(true);
                calm_painting.SetActive(false);

                restless_painting_audio.Stop();
                sad_painting_audio.Stop();
                play_painting_audio.Play();
                calm_painting_audio.Stop();

                update = false;
            }
            if (calm)
            {
                open.SetActive(false);
                restless_painting.SetActive(false);
                sad_painting.SetActive(false);
                play_painting.SetActive(false);
                calm_painting.SetActive(true);

                restless_painting_audio.Stop();
                sad_painting_audio.Stop();
                play_painting_audio.Stop();
                calm_painting_audio.Play();
                update = false;
            }
        }
    }

    public void TriggerRestless()
    {
        restless = true;
        sad = false;
        play = false;
        calm = false;
        update = true;
    }

    public void TriggerSad()
    {
        restless = false;
        sad = true;
        play = false;
        calm = false;
        update = true;
    }

    public void TriggerPlay()
    {
        restless = false;
        sad = false;
        play = true;
        calm = false;
        update = true;
    }

    public void TriggerCalm()
    {
        restless = false;
        sad = false;
        play = false;
        calm = true;
        update = true;
    }

}
