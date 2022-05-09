using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    public GameObject triggernpc, text, canvas, falanpc, ui , eye, textptbrNpc;
    private bool interig, verifica =  false , contexto = true;
   private bool clica = false;

    void Awake()
    {

        canvas.SetActive(false);
        ui.SetActive(false);
        eye.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (interig)
        {
            text.SetActive(true);
            eye.SetActive(true);
            ui.SetActive(true);
            if (clica)
            {
             
                verifica = !verifica;
                canvas.SetActive(verifica);
                falanpc.SetActive(verifica);
                ui.SetActive(true);
                textptbrNpc.SetActive(verifica);
                eye.SetActive(true);
               
                interig = false;
              
            }
        }
        else if(clica)
        {
            text.SetActive(false);
            eye.SetActive(true);
            ui.SetActive(true);
        }
        else
        {
            text.SetActive(false);
            eye.SetActive(false);
            ui.SetActive(false);
        }
    }   
    public void clicado()
    {
        clica = true;
    }
    
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "NPC")
        {
            interig = true;
            triggernpc = col.gameObject;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "NPC")
        {
            interig = false;
            triggernpc = null;
        }
    }
}
