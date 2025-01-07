using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Guarda dados de cada carta
/// </summary>

[CreateAssetMenu(menuName = "CardData")]
public class ScriptableCard : ScriptableObject
{
    [field: SerializeField] public string CardName { get; private set; } 
    [field: SerializeField] public Sprite Image { get; private set; }
    [field: SerializeField] public CardEffectType EffectType { get; private set; }

                                                                           
}

public enum CardEffectType
{
    Item,
    Maldicao,
    Equipamento,
    Monstro,
    Raca,
    Classe
}
