using UnityEngine;

public class Card : MonoBehaviour{

    [SerializeField] private GameObject _heroSelection, _makeHero, _addCard, _disCard;

    public void MakeHero(){
        _heroSelection.SetActive(true);
    }

    public void AddCard(){
        _disCard.SetActive(true);
        _makeHero.SetActive(true);
        _addCard.SetActive(false);
    }
    public void DisCard(){
        _disCard.SetActive(false);
        _makeHero.SetActive(false);
        _addCard.SetActive(true);
        _heroSelection.SetActive(false);
    }

}