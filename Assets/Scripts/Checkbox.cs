using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    public string Marque;

    public Sprite Cross;
    public Sprite Circle;


    public void OnPointerClick(PointerEventData eventData)
    {
        GetComponent<Image>().sprite = Cross;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Hover me");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
