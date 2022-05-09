using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scenes : MonoBehaviour
{

    // Start is called before the first frame update
    public string nome_cena;
    public void cena()

    {
        
    SceneManager.LoadScene(nome_cena);
    }
}
