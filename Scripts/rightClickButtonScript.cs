using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class rightClickButtonScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Button button; 

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            button.onClick.Invoke(); 
        }
    }
}