using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class multicolor : MonoBehaviour
{
    public TextMeshProUGUI texto_tela;
    public string[] seq; // sequencias das frases
    public int index; // inicio do vetor
    public float tipo_Veloc;
    // Start is called before the first frame update







    IEnumerator type()
    {
        texto_tela.text = "<color=red>Atendente: </color> ";
        string rich = seq[index];
        foreach (char letra in rich.ToCharArray())
        {

            texto_tela.text += letra;

            yield return new WaitForSeconds(tipo_Veloc);
        }
    }



    IEnumerator type1()

    {
        texto_tela.text = "<color=green>Você: </color> ";
        string rich = seq[index];
        foreach (char letra in rich.ToCharArray())
        {

            texto_tela.text += letra;

            yield return new WaitForSeconds(tipo_Veloc);
        }
    }


    public void ProximaFrase(int num)
    {


        if (index < seq.Length - 1)
        {

            index = num;


            texto_tela.text = "";

            StartCoroutine(type1());




        }


    }
    public void ProximaFrase1(int num)
    {


      
             
            index = num;


            texto_tela.text = "";

            StartCoroutine(type());




        
    }
}