using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSwitcher : MonoBehaviour
{

    public GameObject[] cardPosition;

    public GameObject cardPrefab;

    [HideInInspector]
    public GameObject tempCard = null;

    [HideInInspector]
    public UI_EventCards cardInfo;

    [HideInInspector]
    public Vector3 fullScale;
    [HideInInspector]
    public Vector3 smallScale;

    [HideInInspector]
    public bool canMove;

    [System.Serializable]
    public enum CardPosition
    {
        START = 0,
        FIRST = 3,
        SECOND = 2,
        THIRD = 1,
        END = 4
    }

    public enum CardNumber
    {
        FIRST = 0,
        SECOND = 1,
        THIRD = 2
    }


    void Awake()
    {
        cardInfo = GetComponent<UI_EventCards>();

        fullScale = new Vector3(1, 1, 1);
        smallScale = new Vector3(0.8f, 0.8f, 0.8f);
    }

    void Start ()
    {
        //First card - Position and Scale
        //cardInfo.card[(int)CardNumber.FIRST].Card_UI.gameObject.transform.position = cardPosition[(int)CardPosition.FIRST].transform.position;
        //cardInfo.card[(int)CardNumber.FIRST].Card_UI.gameObject.transform.localScale = fullScale;
        cardInfo.card[(int)CardNumber.FIRST].Card_UI.GetComponent<CardMover>().currentPosition = CardPosition.FIRST;


        //Second Card - Position and Scale
        //cardInfo.card[(int)CardNumber.SECOND].Card_UI.gameObject.transform.position = cardPosition[(int)CardPosition.SECOND].transform.position;
        //cardInfo.card[(int)CardNumber.SECOND].Card_UI.gameObject.transform.localScale = smallScale;
        cardInfo.card[(int)CardNumber.SECOND].Card_UI.GetComponent<CardMover>().currentPosition = CardPosition.SECOND;


        //Third Card - Position and Scale
        //cardInfo.card[(int)CardNumber.THIRD].Card_UI.gameObject.transform.position = cardPosition[(int)CardPosition.THIRD].transform.position;
        //cardInfo.card[(int)CardNumber.THIRD].Card_UI.gameObject.transform.localScale = smallScale;
        cardInfo.card[(int)CardNumber.THIRD].Card_UI.GetComponent<CardMover>().currentPosition = CardPosition.THIRD;
    }

    void Update()
    {
        if (canMove)
        {
            canMove = false;

            for (int cardIndex = 0; cardIndex < cardInfo.card.Length; cardIndex++)
            {
                //every card to start moving
                cardInfo.card[cardIndex].Card_UI.GetComponent<CardMover>().StartMoving();

            }
          
        }
    }


    public void NewCard()
    {
        
        //* Spawn a new card at the start position - matching the rotation of the first card
        tempCard = Instantiate(cardPrefab, cardPosition[0].transform.position, cardInfo.card[0].Card_UI.gameObject.transform.rotation/* Quaternion.identity*/, this.transform);

        //maybe get the CardMover component off the new card and set up its initial values
        //have to..

        CardMover cardMoverScript = tempCard.GetComponent<CardMover>();

        cardMoverScript.SetCardSwitcher(this);
        cardMoverScript.currentPosition = CardPosition.START;
        //cardMoverScript.targetPosition = CardPosition.START;
       // cardMoverScript.StartMoving();
     
        
    }

      

    public Vector3 GetCardPositionVector(CardPosition a_cardPos)
    {
        return cardPosition[(int)a_cardPos].transform.position;
    }
}
