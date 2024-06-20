using System;
using System.Collections.Generic;

using UnityEngine;

namespace Assets.Scripts.Money_and_Beer
{
    public class SettingsBottle : MonoBehaviour
    {
        public int ValueOneMoney = -4;

        [SerializeField][Range(0, 100)] protected float SpeedRotationMoney = 20f;


        [SerializeField] AudioSource sourcePickUpBottle;

        [SerializeField] AudioClip soungPickBottle;

   

        public void SoungPlayPickUPBottle()
        {
            sourcePickUpBottle.clip = soungPickBottle;
            sourcePickUpBottle.Play();
        }

    }
}
