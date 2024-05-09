using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGFundo : MonoBehaviour
{
    [SerializeField]
    private GameObject botaooff, botaoon;

    void Start()
    {

        if (Sound.instance.musicaBG.isPlaying)
        {
            botaooff.SetActive(false);
            botaoon.SetActive(true);

        }
        else
        {
            botaooff.SetActive(true);
            botaoon.SetActive(false);
        }

    }

    public void PauseSound()
    {
        Sound.instance.SonsBGToca(botaooff, botaoon);

    }


}
