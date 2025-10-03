using UnityEngine;
using UnityEngine.EventSystems;

public class MyButton : MonoBehaviour, IPointerClickHandler{

    [SerializeField] private Tooltip _tooltip;
    [SerializeField] private GameObject _selection;

    public void OnPointerClick(PointerEventData eventData){
        Highlight();
        ShowTooltip();
    }

    private void Highlight(){
        _selection.SetActive(true);
    }

    public void UnHighlight(){
        _selection.SetActive(false);
    }
    
    private void ShowTooltip(){
        _tooltip.ShowTooltip(this);
    }

}