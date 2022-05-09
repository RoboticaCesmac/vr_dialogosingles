using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class vrgaze : MonoBehaviour
{
    public Image imagevr;
    public float totaltime = 5;
    public UnityEvent GVRClick;
    Animator anima;
    bool gvrstatus;
    float gvrtimne;
    // Start is called before the first frame update
    void Start()
    {
        imagevr.fillAmount = 0;

    }
    // Update is called once per frame
    void Update()
    {
        if (gvrstatus)
        {
            Debug.Log("" + gvrstatus);
            gvrtimne += Time.deltaTime;
            imagevr.fillAmount = 1.0f - (gvrtimne / totaltime);
        }
        if (gvrtimne > totaltime)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Gssvroff();
            GVRClick.Invoke();
        }

    }
    public void GvrOn()

    {

        gvrstatus = true;
    }
    public void Gssvroff()
    {
        gvrstatus = false;
        gvrtimne =0;
        imagevr.fillAmount = 0;
    }
     void Fix()
    {
        GetComponent<Button>().enabled = false;
        GetComponent<Button>().enabled = true;
        GetComponent<Animator>().SetTrigger("Normal");
    }
}