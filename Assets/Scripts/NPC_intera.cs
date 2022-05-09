using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_intera : MonoBehaviour
{
    public GameObject canvas, d, falanpc, text, ui, eye
        ;
    
    public static bool verifica = false;
    
    void Awake()
    {
       
        canvas.SetActive(false);
        ui.SetActive(false);
        eye.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two) || Input.GetKeyDown(KeyCode.K)) {
            verifica = !verifica;
            canvas.SetActive(verifica);
            falanpc.SetActive(verifica);
            text.SetActive(verifica);
            d.SetActive(verifica);
            ui.SetActive(verifica);
            eye.SetActive(verifica);

        }
   
        
    }
    public void texto()
    {
        verifica = !verifica;
        text.SetActive(verifica);
        d.SetActive(verifica);
    }
    public void botao()
    {
        verifica = !verifica;
        canvas.SetActive(verifica);
        falanpc.SetActive(verifica);
        text.SetActive(verifica);
        d.SetActive(verifica);


    }
}
