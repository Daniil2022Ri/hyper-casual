using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class SettingsPlayer : MonoBehaviour
    {
        [Header("Settings Player")]

        [SerializeField] public  CharacterController playerController;

        [SerializeField][Range(0, 10)] public float MovingPlayer;

        [SerializeField][Range(0, 10)] public float StraveMovingPlayer;

        [SerializeField][Min(0)] public int MoneyPlayer;

        [SerializeField][Range(1,8)] public int PlayerLvl;


        [Header("Player Win and Lose")]
        public bool PlayerIsWine = false;
        public bool PlayerIsLose = false;


        [Header("Audio Win and Lvl UP")]
        public AudioSource AudioSourcePlayerSettings;

        public AudioClip LvlUpPlayerNow;

        public AudioClip PlayerWinner;


        [Header("Variative Skin Player Prefab!")]
        [SerializeField]public List<GameObject> clothesPlayer; // very bad variant



        private void Start()
        {
            AudioSourcePlayerSettings.clip = LvlUpPlayerNow;
            RemoveClothesPlayerRound();
        }

        public void RemoveClothesPlayerRound()
        {
            foreach (var Variance in clothesPlayer)
            {
                Variance.SetActive(false);
            }
            clothesPlayer[0].SetActive(true);
        }

       

    }
}
