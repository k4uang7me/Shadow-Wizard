using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject painelmenuinicial;
    [SerializeField] private GameObject painelopcoes;

    public void PlayGame()
    {
        SceneManager.LoadScene("Cutscene");
    }

        public void Cutscene()
    {
        SceneManager.LoadScene("Cutscene1");
    }

            public void Cutscene1()
    {
        SceneManager.LoadScene("Cutscene2");
    }

            public void Cutscene2()
    {
        SceneManager.LoadScene("iniciar");
    }

    public void iniciar()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Abrirconfg()
    {
        painelmenuinicial.SetActive(false);
        painelopcoes.SetActive(true);
    }

        public void Fecharconfg()
    { 
        painelopcoes.SetActive(false);
        painelmenuinicial.SetActive(true);
        
    }
}
