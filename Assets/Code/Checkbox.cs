using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public GameController Game;
    public int ID;
    bool canClick;


    void Start()
    {
        Game = FindObjectOfType<GameController>();
        canClick = true;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!canClick) return;
        if (Game.currentTurn == GameController.Turns.Victory || Game.currentTurn == GameController.Turns.Defeat) return;
        canClick = false;

        //Si c'est le joueur 1 qui joue, je prends le sprite One
        //Si c'est le joueur 2 qui joue, je prends le sprite Two

        if(Game.currentTurn == GameController.Turns.PlayerOne)
        {
            GetComponent<Image>().sprite = Game.spriteOne;
        }

        else if (Game.currentTurn == GameController.Turns.PlayerTwo)
        {
            GetComponent<Image>().sprite = Game.spriteTwo;
        }
        Game.changeTurn(ID);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}
