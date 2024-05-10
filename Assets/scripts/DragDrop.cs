using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler//, IDropHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform m_RectTransform;
    private CanvasGroup _canvasgroup;
    private void Awake()
    {
       m_RectTransform = GetComponent<RectTransform>();
        _canvasgroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Onbegindrag");
        _canvasgroup.blocksRaycasts =false;
        _canvasgroup.alpha = 0.6f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _canvasgroup.blocksRaycasts=true;
        _canvasgroup.alpha = 1f;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    //public void OnDrop(PointerEventData eventData)
    //{
    //    throw new System.NotImplementedException();
    //}

    void Update()
    {
        
    }

}
