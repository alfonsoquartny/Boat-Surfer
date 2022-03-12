using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class anan : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool isPressRight;


    public void OnPointerDown(PointerEventData eventData)
    {
        isPressRight = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        isPressRight = false;
    }

}
