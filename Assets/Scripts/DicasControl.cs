using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DicasControl : MonoBehaviour
{
    public static DicasControl Instance;
    public Text fraseBalao;
    public string[] dicas;
    public Canvas panel;
    public AudioClip[] Lista;
    public AudioSource tocar;
    private float tempo;
    private bool mudo;


    public void Start()
    {
        Instance = this;
        mudo = false;
        tocar = GetComponent<AudioSource>();
        Instance = this;
        PlayerPrefs.SetInt("Vitoria", 0);
    }

    private void Update()
    {
        tempo += Time.deltaTime; // faz uma variavel float receber o tempo de execução de cada update (1 segundo)
                                 //o swtich embaixo está rodando de 6 em 6 segundos

        if (PlayerPrefs.GetInt("Tab") == 0)
        {

            switch ((int)tempo)
            {
                case 1:
                    tocar.clip = Lista[0];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(0);
                    break;
                case 9:
                    tocar.clip = Lista[1];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(1);
                    break;
                case 17:
                    tocar.clip = Lista[2];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(2);
                    break;
                case 25:
                    tocar.clip = Lista[3];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(3);
                    break;
                case 33:
                    tocar.clip = Lista[4];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(4);
                    break;
                case 41:
                    tempo = 1;
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Tab") == 1)
        {

            switch ((int)tempo)
            {
                case 1:
                    tocar.clip = Lista[5];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(5);
                    break;
                case 9:
                    tocar.clip = Lista[6];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(6);
                    break;
                case 17:
                    tocar.clip = Lista[7];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(7);
                    break;
                case 25:
                    tocar.clip = Lista[8];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(8);
                    break;
                case 33:
                    tocar.clip = Lista[9];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(9);
                    break;
                case 41:
                    tempo = 1;
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Tab") == 2)
        {

            switch ((int)tempo)
            {
                case 1:
                    tocar.clip = Lista[10];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(10);
                    break;
                case 9:
                    tocar.clip = Lista[11];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(11);
                    break;
                case 17:
                    tocar.clip = Lista[12];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(12);
                    break;
                case 25:
                    tocar.clip = Lista[13];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(13);
                    break;
                case 33:
                    tocar.clip = Lista[14];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(14);
                    break;
                case 41:
                    tempo = 1;
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Tab") == 3)
        {

            switch ((int)tempo)
            {
                case 1:
                    tocar.clip = Lista[15];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(15);
                    break;
                case 9:
                    tocar.clip = Lista[16];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(16);
                    break;
                case 17:
                    tocar.clip = Lista[17];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(17);
                    break;
                case 25:
                    tocar.clip = Lista[18];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(18);
                    break;
                case 33:
                    tocar.clip = Lista[19];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(19);
                    break;
                case 41:
                    tempo = 1;
                    break;
            }
        }
        if (PlayerPrefs.GetInt("Tab") == 4)
        {

            switch ((int)tempo)
            {
                case 1:
                    tocar.clip = Lista[20];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(20);
                    break;
                case 9:
                    tocar.clip = Lista[21];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(21);
                    break;
                case 17:
                    tocar.clip = Lista[22];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(22);
                    break;
                case 25:
                    tocar.clip = Lista[23];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(23);
                    break;
                case 33:
                    tocar.clip = Lista[24];
                    if (!mudo) { tocar.Play(); }
                    setaFraseBalao(24);
                    break;
                case 41:
                    tempo = 1;
                    break;
            }
        }
    }
    public void setaFraseBalao(int index)
    {
        fraseBalao.text = dicas[index];
        panel.transform.GetChild(1).gameObject.SetActive(true);
    }
    public void desativaBalao()
    {
        panel.transform.GetChild(1).gameObject.SetActive(false);
    }
    public void ativaBalao()
    {
        panel.transform.GetChild(1).gameObject.SetActive(true);

    }


}
