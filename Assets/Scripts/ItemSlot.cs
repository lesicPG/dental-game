using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public int id;
    public GameObject grandChild;
 
  

    public void OnDrop(PointerEventData eventData)
    {
       

        if (eventData.pointerDrag != null)
        {
           
            if (eventData.pointerDrag.GetComponent<DragDrop>().id == id)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                //pode ser também:
                //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = rectTransform.anchoredPosition;
                //não sei a diferença

                /*Desativa movimento da peça encaixada corretamente*/
                grandChild = GameObject.Find("peca"+id);
                grandChild.GetComponent<DragDrop>().canvasgroup.alpha = 1f;
                Sound.instance.SonsFXToca(0);
                grandChild.GetComponent<DragDrop>().enabled = false;
                /*FIM-Desativa movimento da peça encaixada corretamente*/

                /*Verifica se venceu*/
                int aux = PlayerPrefs.GetInt("Vitoria");
                PlayerPrefs.SetInt("Vitoria", aux + 1);
               
                if (PlayerPrefs.GetInt("Nivel") == 0 && PlayerPrefs.GetInt("Vitoria") == 4)
                {
                    PlayerPrefs.SetInt("Vitoria", 0);
                    CarregaCena.Instance.carregaCena("Congrats");
                }
                if (PlayerPrefs.GetInt("Nivel") == 1 && PlayerPrefs.GetInt("Vitoria") == 9)
                {
                    PlayerPrefs.SetInt("Vitoria", 0);
                    CarregaCena.Instance.carregaCena("Congrats");
                }
                if (PlayerPrefs.GetInt("Nivel") == 2 && PlayerPrefs.GetInt("Vitoria") == 16)
                {
                    PlayerPrefs.SetInt("Vitoria", 0);
                    CarregaCena.Instance.carregaCena("Congrats");
                }

                /*FIM-Verifica se venceu*/
            }
            else
            {
                Debug.Log("Esse é id: "+ id);
                eventData.pointerDrag.GetComponent<DragDrop>().ResetPosition();
            }
            
        }
       
       
    }
}
