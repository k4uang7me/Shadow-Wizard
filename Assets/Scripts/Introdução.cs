using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Introdução : MonoBehaviour
{

    string[] texto = nem string[3];
    GameObject[] texto;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutime(Rotina());
       textos[1] = "em uma caverna muito distante do povo avia acontecimentos estranhos";
       textos[2] = "n vjjjjjjjjjjjigw bnegviwuengfvuiwe";
       textos[3] = "gnveuweuwegwguwie9";
       textos[4] = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
       textos[5] = "shshshshhsskkkkkkkkkkkkkkkkskskskksksrsrrsrsrsrs";

        texto = GameObject.find("texto");
        texto.getcomponent<texto>().text =  textos[1];

    }
    int cont = 0;

    public IEnumeraitor Rotina()
    {
    GameObject img = GameObject.find("img"+cont);
    img.GetComponent<rewImage>().enable = true;
    texto>GetComponent<text>().text = testos[cont];
    cont++;
        if(cont < 3) {
        yield returm new WaitForSeconds(5);
        StartCoroutime(Rotina());
        } 
        else
        {
            SceneManager.LoadScene("iniciar");
        } 
    }
}
