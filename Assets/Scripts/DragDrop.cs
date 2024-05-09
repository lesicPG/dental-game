using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public static DragDrop Instance;
    private RectTransform rectTransform;
    public Canvas canvas;
    [SerializeField] public CanvasGroup canvasgroup;
    public Vector2 posInicial;
    public int id;
    private Transform transteste;
   

    public void Awake()
    {
      rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        Instance = this;
        posInicial = transform.position;
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        // posInicial = eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition;
        
        canvasgroup.alpha = 0.5f;
        canvasgroup.blocksRaycasts = false;

      


    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Sound.instance.SonsFXToca(0);
        canvasgroup.alpha = 1f;
        canvasgroup.blocksRaycasts = true;
    

       
    }

    public void OnDrag(PointerEventData eventData)
    {
       
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    

    public void OnPointerDown(PointerEventData eventData)
    {
        
        Sound.instance.SonsFXToca(0);
       

    }

    public void ResetPosition()
    {
        transform.position = posInicial;
    }
}
