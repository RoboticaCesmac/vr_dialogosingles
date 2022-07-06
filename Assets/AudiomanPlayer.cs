using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudiomanPlayer : MonoBehaviour
{
    public Som[] sons;

    public GameObject d, anima, cena, timeline, timeline_errado;
    public GameObject text;
    public String fim;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Som s in sons)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

        }
    }
    
    // Update is called once per frame
    public void Playsomcerto(string name)
    {
        Som s = Array.Find(sons, Som => Som.name == name);
        s.source.Play();

  

        
       if(name == "Thank you")
        {
            Invoke("timelinea", s.source.clip.length);
        }
        else if (name == "Good bye" || name == "TKY")
        {
            Invoke("Fim", s.source.clip.length);
        }
        else 
        {
            Invoke("Ft", s.source.clip.length);
        }
        

    }
    public void Playsomerrado(string name)
    {
        Som s = Array.Find(sons, Som => Som.name == name);
        s.source.Play();




        if (name == "Thank you")
        {
            Invoke("timelinea", s.source.clip.length);
        }
        else if (name == "Good bye" || name == "TKY")
        {
            Invoke("Fim", s.source.clip.length);
        }
        else
        
        {
            Invoke("timeline_errad", s.source.clip.length);
        }


    }
    void reiniciar()
    {
        cena.SendMessage("cena", "LanchoneteScene");
    }
    public void Fim()
    {
        cena.SendMessage("cena", fim);
    }
    void opc()
    {
        d.SendMessage("vazio");
    }
    void Ft()
    {
        text.SetActive(true);
        d.SendMessage("ProximaFrase");
    }
  
    void timelinea()
    {
        timeline.SetActive(true);
    }
   
    void timeline_errad()
    {
        timeline_errado.SetActive(true);
    }
}