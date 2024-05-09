using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetaNivel : MonoBehaviour
{
    [SerializeField]
    private int nivel;

    private void Start()
    {
        Nivel();
    }


    public void Nivel()
    {
        PlayerPrefs.SetInt("Nivel", nivel);

    }


}
