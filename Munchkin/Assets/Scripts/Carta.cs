using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
/// <summary>
/// Atualizará os visuais da interface gráfica de cada carta, dependendo de seus dados.
/// </summary>
[RequireComponent(typeof(CardUI))] 

public class Carta : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [field: SerializeField] public ScriptableCard CardData { get; private set; }
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

    public void SetUp(ScriptableCard data)
    {
        CardData = data;
        GetComponent<CardUI>().SetCardUI();
    }
}
