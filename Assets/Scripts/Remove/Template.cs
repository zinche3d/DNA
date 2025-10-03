using System;
using UnityEngine;
using UnityEngine.UI;

public class Template : MonoBehaviour{

    [EnumButtons, SerializeField] private Resolution _resolution;
    [SerializeField] private Sprite _HD, _Wide, _Long;
    [SerializeField] private Image _image;

    private void OnValidate(){
        switch (_resolution){
            case Resolution.HD:
                _image.overrideSprite = _HD;
                break;
            case Resolution.Wide:
                _image.overrideSprite = _Wide;
                break;
            case Resolution.Long:
                _image.overrideSprite = _Long;
                break;
            default:
                throw new ArgumentOutOfRangeException();
            
        }
    }

}

public enum Resolution{

    HD,
    Wide,
    Long

}