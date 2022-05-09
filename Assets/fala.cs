using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fala : MonoBehaviour
{
    public static AudioSource som;
    public GameObject d;
    // Start is called before the first frame update
    void Start()
    {
        som = gameObject.AddComponent<AudioSource>();
        Invoke("ft", som.clip.length);
    }
    void ft()
    {
        d.SendMessage("ProximaFrase");
    }
    // Update is called once per frame

}
