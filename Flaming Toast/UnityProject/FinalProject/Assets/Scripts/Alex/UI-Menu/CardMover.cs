using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMover : MonoBehaviour
{
	public float cardSpeed;
	private bool isMoving;
	private Vector3 targetVectorPosition;

   // [HideInInspector]
	public CardSwitcher.CardPosition currentPosition;
  //  [HideInInspector]
	public CardSwitcher.CardPosition targetPosition;

    private CardSwitcher cardSwitcherRef;


	void Awake ()
	{
		//Every new cards starting position
		currentPosition = CardSwitcher.CardPosition.START;

        if (cardSwitcherRef == null)
            cardSwitcherRef = GetComponentInParent<CardSwitcher>();

        targetVectorPosition = new Vector3(10,10,10);
        targetVectorPosition = cardSwitcherRef.GetCardPositionVector(targetPosition);//returns null..

    }
	
	
	void Update ()
	{

		if(isMoving)
		{
			//move towards targetPosition
			transform.position = Vector3.MoveTowards(transform.position, targetVectorPosition, cardSpeed * Time.deltaTime);

             //once at that position or near
            if ((transform.position - targetVectorPosition).magnitude < 0.015f)
			{
                //snap
                transform.position = targetVectorPosition;

				//update currentPosition to targetPosition
				currentPosition = targetPosition;

                //if curr pos is end
                //destroy the object

                if (currentPosition == CardSwitcher.CardPosition.END)
                {
                    Destroy(this.gameObject);
                    GetComponentInParent<UI_EventCards>().DeleteCard();
                }

                switch (targetPosition)
                {
                    case CardSwitcher.CardPosition.START:
                        //cardSwitcherRef.cardInfo.card[(int)CardSwitcher.CardNumber.START].Card_UI.gameObject.transform.localScale = cardSwitcherRef.smallScale;
                        break;
                    case CardSwitcher.CardPosition.FIRST:
                        /*cardSwitcherRef.cardInfo.card[0].Card_UI.gameObject.transform.localScale*/
                        transform.localScale = cardSwitcherRef.fullScale;
                        break;
                    case CardSwitcher.CardPosition.SECOND:
                        /*cardSwitcherRef.cardInfo.card[1].Card_UI.gameObject.transform.localScale*/
                        transform.localScale = cardSwitcherRef.smallScale;
                        break;
                    case CardSwitcher.CardPosition.THIRD:
                        /* cardSwitcherRef.cardInfo.card[2].Card_UI.gameObject.transform.localScale */
                        transform.localScale = cardSwitcherRef.smallScale;
                        break;
                    case CardSwitcher.CardPosition.END:
                        //cardSwitcherRef.cardInfo.card[(int)CardSwitcher.CardPosition.END].Card_UI.gameObject.transform.localScale = cardSwitcherRef.smallScale;
                        break;
                    default:
                        break;
                }

				isMoving = false;
			}


		}

	//Each card will handle its own movement and know where it is
		//*move each card to the next slot in the transform array(card positions)
		//*-card_0 move towards end position
		//*-card_1 move towards first position
		//*-card_2 move towards second position
		//*-new card move towards third position
		
	}

	public void StartMoving()
	{
 
        //set up the cardmover's internal values to start moving
        isMoving = true;

 


        if (currentPosition == CardSwitcher.CardPosition.FIRST)
        {
            targetPosition = CardSwitcher.CardPosition.END;
        }


        if (currentPosition == CardSwitcher.CardPosition.SECOND)
        {
            targetPosition = CardSwitcher.CardPosition.FIRST;
        }

        if (currentPosition == CardSwitcher.CardPosition.THIRD)
        {
            targetPosition = CardSwitcher.CardPosition.SECOND;
        }


        if (currentPosition == CardSwitcher.CardPosition.START)
        {
            targetPosition = CardSwitcher.CardPosition.THIRD;
        }

        //Grab the vector of the new position
        if (cardSwitcherRef == null)
        {
            cardSwitcherRef = GetComponentInParent<CardSwitcher>();
        }
        if (cardSwitcherRef != null)
        {
            targetVectorPosition = cardSwitcherRef.GetCardPositionVector(targetPosition);
        }


	}

    public void SetCardSwitcher(CardSwitcher cSwitcher)
    {
        cardSwitcherRef = cSwitcher;
    }




}
