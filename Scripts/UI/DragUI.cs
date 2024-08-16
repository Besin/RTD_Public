using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragUI: MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject towerUI;
    private Vector2 beginPosition;
    private Vector3 dragPosition;

    

    // 오브젝트를 눌렀을 시
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
    }

    // 오브젝트를 놓았을 시
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
    }

    // 끌기 시작 시
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        transform.position = beginPosition;       
    }

    // 끄는 도중
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        dragPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        dragPosition.z = 0;
        transform.position =dragPosition;
        
    }

    // 끌기가 끝날 때
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
       
    }
}