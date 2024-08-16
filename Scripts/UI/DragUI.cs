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

    

    // ������Ʈ�� ������ ��
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
    }

    // ������Ʈ�� ������ ��
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
    }

    // ���� ���� ��
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        transform.position = beginPosition;       
    }

    // ���� ����
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        dragPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        dragPosition.z = 0;
        transform.position =dragPosition;
        
    }

    // ���Ⱑ ���� ��
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
       
    }
}