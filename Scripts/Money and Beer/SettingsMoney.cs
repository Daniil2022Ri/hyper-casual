using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Money_and_Beer
{
    public class SettingsMoney : MonoBehaviour
    {
        public int ValueOneMoney = 2;

        [SerializeField][Range(0, 100)] protected float SpeedRotationMoney = 20f;

        [SerializeField][Min(0.1f)] protected float ValueUpAndDownMoneyRotation = 0.9f;


        [SerializeField] public AudioSource audioSource;

        [SerializeField] public AudioClip soungClip;

        private void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void SoungPlayPickUP() 
        {
            audioSource.clip = soungClip;
            audioSource.Play();
        }

    }
}
