using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabManager : MonoBehaviour
{
    public Sprite[] tabuleiroCinza = new Sprite[5];
    public Sprite[] pecasSprite = new Sprite[20];
    
    public Image[] pecas = new Image[4];
    public Image tabuleiro;

    private void Start()
    {
        GeraTabuleiro();
              
        if (PlayerPrefs.GetInt("Nivel") == 0)
        {
            Facil();
        }else if (PlayerPrefs.GetInt("Nivel") == 1)
        {
            Debug.Log("medio");
            Medio();
        }else if (PlayerPrefs.GetInt("Nivel") == 2)
        {
            Dificil();
        }

    }

    private void GeraTabuleiro()
    {
        PlayerPrefs.SetInt("Tab", Random.Range(0, 5));
        
    }

    public void Facil()
    {
        if (PlayerPrefs.GetInt("Tab") == 0)
        {
            tabuleiro.sprite = tabuleiroCinza[0];

            for (int i = 0; i < 4; i++)
            {
                pecas[i].sprite = pecasSprite[i];
            }
        }
        else if (PlayerPrefs.GetInt("Tab") == 1)
        {
            tabuleiro.sprite = tabuleiroCinza[1];

            for (int i = 0; i < 4; i++)
            {
                pecas[i].sprite = pecasSprite[i+4];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 2)
        {
            tabuleiro.sprite = tabuleiroCinza[2];

            for (int i = 0; i < 4; i++)
            {
                pecas[i].sprite = pecasSprite[i + 8];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 3)
        {
            tabuleiro.sprite = tabuleiroCinza[3];

            for (int i = 0; i < 4; i++)
            {
                pecas[i].sprite = pecasSprite[i + 12];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 4)
        {
            tabuleiro.sprite = tabuleiroCinza[4];

            for (int i = 0; i < 4; i++)
            {
                pecas[i].sprite = pecasSprite[i + 16];
            }
        }
    }
    
    public void Medio()
    {
        if (PlayerPrefs.GetInt("Tab") == 0)
        {
            tabuleiro.sprite = tabuleiroCinza[0];

            for (int i = 0; i < 9; i++)
            {
                pecas[i].sprite = pecasSprite[i];
            }
        }
        else if (PlayerPrefs.GetInt("Tab") == 1)
        {
            tabuleiro.sprite = tabuleiroCinza[1];

            for (int i = 0; i < 9; i++)
            {
                pecas[i].sprite = pecasSprite[i + 9];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 2)
        {
            tabuleiro.sprite = tabuleiroCinza[2];

            for (int i = 0; i < 9; i++)
            {
                pecas[i].sprite = pecasSprite[i + 18];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 3)
        {
            tabuleiro.sprite = tabuleiroCinza[3];

            for (int i = 0; i < 9; i++)
            {
                pecas[i].sprite = pecasSprite[i + 27];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 4)
        {
            tabuleiro.sprite = tabuleiroCinza[4];

            for (int i = 0; i < 9; i++)
            {
                pecas[i].sprite = pecasSprite[i + 36];
            }
        }
    }

    public void Dificil()
    {
        if (PlayerPrefs.GetInt("Tab") == 0)
        {
            tabuleiro.sprite = tabuleiroCinza[0];

            for (int i = 0; i < 16; i++)
            {
                pecas[i].sprite = pecasSprite[i];
            }
        }
        else if (PlayerPrefs.GetInt("Tab") == 1)
        {
            tabuleiro.sprite = tabuleiroCinza[1];

            for (int i = 0; i < 16; i++)
            {
                pecas[i].sprite = pecasSprite[i + 16];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 2)
        {
            tabuleiro.sprite = tabuleiroCinza[2];

            for (int i = 0; i < 16; i++)
            {
                pecas[i].sprite = pecasSprite[i + 32];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 3)
        {
            tabuleiro.sprite = tabuleiroCinza[3];

            for (int i = 0; i < 16; i++)
            {
                pecas[i].sprite = pecasSprite[i + 48];
            }

        }
        else if (PlayerPrefs.GetInt("Tab") == 4)
        {
            tabuleiro.sprite = tabuleiroCinza[4];

            for (int i = 0; i < 16; i++)
            {
                pecas[i].sprite = pecasSprite[i + 64];
            }
        }
    }
}
