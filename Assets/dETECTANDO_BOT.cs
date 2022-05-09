using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class dETECTANDO_BOT : MonoBehaviour
{
    public Camera CAM;
    public Image imagevr;
    public float totaltime = 5;
    public UnityEvent GVRClick;
    private RaycastHit hit;
    [SerializeField] LayerMask layer;
    public int distancia_do_raio = 50;
    bool gvrstatus;
    float gvrtimne;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
        Ray raio = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
        Debug.DrawRay(CAM.transform.position, CAM.transform.forward * distancia_do_raio, Color.green);
        if (Physics.Raycast(CAM.transform.position,CAM.transform.forward, out hit, distancia_do_raio, LayerMask.GetMask("Botao")))
        {
            Debug.Log("hit");
            gvrtimne += Time.deltaTime;
            imagevr.fillAmount = gvrtimne / totaltime;
        }
        if (gvrtimne > totaltime)
        {
            Gssvroff();
            GetComponent<Button>().onClick.Invoke();
        }
        else
        {
            Gssvroff();
        }
    }
    public void GvrOn()
    {
        gvrstatus = true;
    }
    public void Gssvroff()
    {
        gvrstatus = false;
        gvrtimne = 0;
        imagevr.fillAmount = 0;
    }
}
