using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class animamenu : MonoBehaviour
{
    public Animator anim;
   
    public void HideDialog(){
        
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }
}
