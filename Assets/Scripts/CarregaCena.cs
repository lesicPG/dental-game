using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregaCena : MonoBehaviour
{
    public static CarregaCena Instance;

    private void Start()
    {
        Instance = this;
    }

    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);

    }
    public void Sair()
    {
      Application.Quit();
    }

    


}
