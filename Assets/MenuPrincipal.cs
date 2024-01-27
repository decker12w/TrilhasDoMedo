using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private string nomeLevel;
    [SerializeField] private GameObject menu;
    public void Jogar()
    {
        SceneManager.LoadScene(nomeLevel);
    }

    public void ComoJogarEntrar()
    {
        menu.SetActive(true);
    }

    public void ComoJogarSair()
    {
        menu.SetActive(false);
    } 

    public void SairDoJogo()
    {
        Debug.Log("Saiu");
        Application.Quit();
    }
}
