
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Money_and_Beer
{
    public class Bottle : SettingsBottle
    {
        private void RotationAndMovingMoney()
        {
            transform.Rotate(Vector3.up * SpeedRotationMoney * Time.deltaTime);
          
        }

      

        private void Update()
        {
            RotationAndMovingMoney();
        }

        private void OnTriggerEnter(Collider PlayerCharacter)
        {
            if (PlayerCharacter.gameObject.CompareTag("Player"))
            {
               

                SoungPlayPickUPBottle();

                Destroy(gameObject, 0.5f);
            }
        }

    }
}
