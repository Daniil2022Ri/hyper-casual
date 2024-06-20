
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class RotationMovingPlayer : MonoBehaviour
    {
        private Vector3 _positionLeft = new Vector3(0, -90, 0);
        private Vector3 _positionRight = new Vector3(0, 90, 0);
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("ZoneRotationLeft"))
            {
                _playerRotationLeftMoving();
            }
            if (other.gameObject.CompareTag("ZoneRotationRight"))
            {
                _playerRotationRightMoving();
            }
        }


        private void _playerRotationLeftMoving()
        {
            transform.Rotate(_positionLeft);
        }
        private void _playerRotationRightMoving()
        {
            transform.Rotate(_positionRight);
        }



    }
}
