using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ButtonScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public bool isPressLeft;

    void Start()
    {
        
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        isPressLeft = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressLeft = false;
    }

}
