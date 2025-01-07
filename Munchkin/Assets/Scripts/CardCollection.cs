using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Uma coleção genérica de objetos CardData. Pode ser usada como um baralho ou um pacote de reforço, por exemplo.
/// </summary>
[CreateAssetMenu(menuName = "Card Collection")]
public class CardCollection : ScriptableObject
{
    [field: SerializeField] public List<ScriptableCard> CardsInCollection { get; private set; }


    public void RemoveCardFromCollection(ScriptableCard card)
    {
        if (CardsInCollection.Contains(card))
        {
            CardsInCollection.Remove(card);
        }
        else
        {
            Debug.LogWarning("CardData não está present na coleção - não pode remover");
        }
    }


    public void AddCardToCollection(ScriptableCard card)
    {
        CardsInCollection.Add(card);
    }
}
