using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{

    public enum Content
    {
        None = 0,
        PlayerOne = 1,
        PlayerTwo = 2,
    };

    public Content currentContent;
    GameController myGame;
    public Sprite Check;

    // Start is called before the first frame update
    void Start()
    {
        myGame = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoverMe()
    {
        Debug.Log("I'm Here", this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter Me", this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit Me", this);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click Me", this);
        GetComponent<Image>().sprite = Check;
        currentContent = Content.PlayerOne;
    }
}
