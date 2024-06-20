using Assets.Scripts.Player.InputSwipeSystem;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputSwipePanel : MonoBehaviour , IBeginDragHandler , IDragHandler , IEndDragHandler
{
    public event Action<SwipeSystem> SwipeBegun;
    public event Action<SwipeSystem> Swiping;
    public event Action<SwipeSystem> SwipeEnded;

    private Vector2 _startPosition;

    public void OnBeginDrag(PointerEventData eventData)
    {
       _startPosition = eventData.position;
       

        Invoke(SwipeBegun, eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
      Invoke(Swiping , eventData);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Invoke(Swiping, eventData);
    }

    private void Invoke(Action<SwipeSystem> action, PointerEventData eventData) =>
        action?.Invoke(CreateSwipeFrom(_startPosition, eventData));

    private SwipeSystem CreateSwipeFrom(Vector2 startPosition, PointerEventData eventData) =>
        new SwipeSystem(startPosition, eventData.position, eventData.delta);
        
}
