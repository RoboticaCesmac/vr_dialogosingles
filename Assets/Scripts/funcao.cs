using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class funcao : MonoBehaviour
{
public TextMeshProUGUI texto_tela;
public string[] seq; // sequencias das frases
public int index; // inicio do vetor
public float tipo_Veloc;
public GameObject[] botao;
    public GameObject d;
    AudioSource s = fala.som;
  
    public GameObject Text;

    private void Start()
    {
        StartCoroutine(type());
        d.SendMessage("playm", index);
    }






    public void ativabotao()
    {
     
        
   
        
            for (int i = 0; i < botao.Length; i++)
            {
                botao[i].SetActive(true);
            }
        
        
    }


IEnumerator type(){
    foreach (char letra in seq[index].ToCharArray())
    {
        texto_tela.text += letra;
        yield return new WaitForSeconds(tipo_Veloc);
    }
    }
    public void vazio() 
    {
        for (int i = 0; i < botao.Length; i++)
        {


            botao[i].SetActive(true);



        }
        texto_tela.text = "";
    }
    public void ProximaFrase(){
      
        for (int i = 0; i < botao.Length; i++)
        {


            botao[i].SetActive(false);
  


        }

        if (index < seq.Length - 1)
    {

            index++;

            d.SendMessage("playm", index);
                texto_tela.text = "";

                StartCoroutine(type());
            
        
          

    }
    else
    {

            index = 0;
          
            texto_tela.text = "";
            StartCoroutine(type());
            
    }
}
public void q5(){
        for (int i = 0; i < botao.Length; i++)
    {
        botao[i].SetActive(false);
    }
            index = 4;
        texto_tela.text = "";
        StartCoroutine(type());


    }
    public void q2(){
        index = 1;
        d.SendMessage("playm", index);
        texto_tela.text = "";

        StartCoroutine(type());

    }
    public void desativabotao()
    {
     
        for (int i = 0; i < botao.Length; i++)
        {
            botao[i].SetActive(false);
        }
        Text.SetActive(false);
        
    }
    public void Terminar()
   {
        index = 0;
        texto_tela.text = "";
        StartCoroutine(type());
        d.SendMessage("playm", index);


    }
}
        