using UnityEngine;
using UnityEngine.EventSystems;
public class Carta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private RectTransform carta;
    private int id;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        id = carta.GetSiblingIndex();
        carta.SetAsLastSibling();
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        carta.SetSiblingIndex(id);
    }
}
