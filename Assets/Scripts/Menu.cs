using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
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
}
