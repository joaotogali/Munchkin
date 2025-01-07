using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

/// <summary>
/// Will update the UI-visuals of each card, depending on it's data
/// </summary>
public class CardUI : MonoBehaviour
{
    #region Fields and Properties

    private Carta _card;

    [Header("Prefab Elements")]
    [SerializeField] private Image _cardImage;

    #endregion

    #region Methods

    private void Awake()
    {
        _card = GetComponent<Carta>();
        SetCardUI();
    }

    private void OnValidate()
    {
        Awake();
    }

    public void SetCardUI()
    {
        if (_card != null && _card.CardData != null)
        {
            SetCardImage();
        }
    }

    private void SetCardImage()
    {
        _cardImage.sprite = _card.CardData.Image;
    }





    #endregion
}
