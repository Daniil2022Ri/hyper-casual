using Assets.Scripts.Player.InputSwipeSystem;
using System;
using UnityEditor;
using UnityEngine;


namespace Assets.Scripts.Player
{
    public class MultiPlatformVariativeMovingPlayer : MonoBehaviour
    {
        [SerializeField] private SettingsPlayer settingsPlayer;
        [SerializeField] private InputSwipePanel _swipePanel;
        [SerializeField] private SwipeSystem swipeSystem;

        




        private void Update()
        {
            if(settingsPlayer.PlayerIsWine == false && settingsPlayer.PlayerIsLose == false)
            MovingPlayerForward();
            MovingSKeyBoard(settingsPlayer.StraveMovingPlayer);
            MovingSwipePhone(settingsPlayer.StraveMovingPlayer, swipeSystem);
        }





        public void MovingPlayerForward()
        {
            Vector3 movement = transform.forward * settingsPlayer.MovingPlayer * Time.deltaTime;



            settingsPlayer.playerController.Move(movement);
        }

        public void MovingSKeyBoard(float moveSpeed)
        {
            float InputHorizont = Input.GetAxis("Horizontal");

            Vector3 movement = transform.right * InputHorizont * moveSpeed * Time.deltaTime;

            settingsPlayer.playerController.Move(movement);
        }


       
        
        public void MovingSwipePhone(float moveSpeed , SwipeSystem inputSwipe)
        {
            float xAxis = inputSwipe.Delta.x;
            settingsPlayer.playerController.Move(Vector3.right * xAxis * moveSpeed * Time.deltaTime);
        }

    }
}
