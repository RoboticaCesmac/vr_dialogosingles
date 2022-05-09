using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class audiomanager : MonoBehaviour
{
   
    
    public GameObject[] atendentefalar;
    
   // Start is called before the first frame update
   

   

    // Update is called once per frame
    public void playm(int num)
    {

        atendentefalar[num].SetActive(true);   

        
        
    }
}