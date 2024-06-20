using UnityEngine;


namespace Assets.Scripts.Player.InputSwipeSystem
{
    public readonly struct SwipeSystem
    {
        public Vector2 StartPosition { get; }

        public Vector2 EndPosition { get; }

        public Vector2 Delta { get; }

        public SwipeSystem(Vector2 startPosition, Vector2 endPosition , Vector2 delta)
        {
            StartPosition = startPosition;
            EndPosition = endPosition;
            Delta = delta;
        }

        public Vector2 NormalizeDelta => Delta.normalized;
        
    }
}
