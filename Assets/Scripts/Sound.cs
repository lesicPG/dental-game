using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public static Sound instance;
    [SerializeField]
    private GameObject botaooff, botaoon;

    //musicas
    public AudioClip[] clips;
    public AudioSource musicaBG;

    //sonsFX
    public AudioClip[] clipsFX;
    public AudioSource sonsFX;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        musicaBG.clip = clips[0];
        musicaBG.volume = 1f;
        musicaBG.Play();
        botaooff.SetActive(false);
        botaoon.SetActive(true);


    }

    public void SonsBGToca(GameObject botaooff, GameObject botaoon)
    {
        if (musicaBG.isPlaying)
        {
            musicaBG.Pause();
            botaooff.SetActive(true);
            botaoon.SetActive(false);

        }
        else if (!musicaBG.isPlaying)
        {
            musicaBG.UnPause();
            botaooff.SetActive(false);
            botaoon.SetActive(true);
        }

    }

    public void BGToca(int i)
    {
        musicaBG.clip = clips[i];
        musicaBG.Play();
    }

    public void SonsFXToca(int i)
    {
        sonsFX.clip = clipsFX[i];
        sonsFX.Play();
    }




}
