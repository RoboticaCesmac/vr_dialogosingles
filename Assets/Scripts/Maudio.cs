using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass : MonoBehaviour
{
    public AudioClip som;
 public static AudioSource meu_audio;
    // Start is called before the first frame update
    funcao fun = new funcao();
    void Start()
    {
        meu_audio = GetComponent<AudioSource>();
        meu_audio.clip = som;
        meu_audio.Play();
        Debug.Log("começar"); 
    }
    void Update()
    {
        if (!meu_audio.isPlaying)
        {
      
           // fun.ProximaFrase();
            Debug.Log("fim");

        }
    }
    // Update is called once per frame
    
}
