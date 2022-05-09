using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima_npcLan : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anima;

public void pegando()
    {
        anima.SetBool("Pegando", true);
        anima.SetBool("Parado", false);

    }

    public void parado()
    {
        anima.SetBool("Pegando", false);
        anima.SetBool("Parado", true);

    }

}
