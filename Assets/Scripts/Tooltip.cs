using UnityEngine;

public class Tooltip: MonoBehaviour{
    private MyButton _button;
    public void ShowTooltip(MyButton buttoon){
        _button=buttoon;
        gameObject.SetActive(true);
    }
    
    public void HideTooltip(){
        gameObject.SetActive(false);
        _button?.UnHighlight();
        _button=null;
    }

}