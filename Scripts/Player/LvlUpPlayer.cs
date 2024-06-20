using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class LvlUpPlayer : MonoBehaviour
    {
        [SerializeField] private SettingsPlayer playerSettings;

        [SerializeField] Animator animator;

        [SerializeField] ParticleSystem lvlUpParticle;


        private void Start()
        {
            lvlUpParticle.Stop();
            animator = GetComponent<Animator>();
        }

        private void Update()
        {
            NewLvlPlayer();
        }

        private void OnTriggerEnter(Collider other)
        {
           if( other.gameObject.CompareTag("Money"))
            {
                playerSettings.MoneyPlayer += 1;
            }
            if (other.gameObject.CompareTag("Bottle"))
            {
                playerSettings.MoneyPlayer -= 1;
            }
        }


        private void NewLvlPlayer()
        {
            switch (playerSettings.MoneyPlayer)
            {
                case 10:                        //You give 10 Money 

                    lvlUpParticle.Play(); // Particle System Player Lvl Up

                    playerSettings.PlayerLvl = 2;     //Player Lvl

                    OffSkinsPlayer();                  //Remove all Skin

                    playerSettings.clothesPlayer[1].SetActive(true);    //Using Next List Skin

                    playerSettings.AudioSourcePlayerSettings.PlayOneShot(playerSettings.LvlUpPlayerNow);    //Music Lvl Up

                    animator.SetInteger("MoneyFirst", playerSettings.MoneyPlayer);

                    break;

                case 20:
                    lvlUpParticle.Play();

                    playerSettings.PlayerLvl = 3;

                    OffSkinsPlayer();

                    playerSettings.AudioSourcePlayerSettings.Play();

                    playerSettings.clothesPlayer[2].SetActive(true);

                    break;

                case 30:
                    lvlUpParticle.Play();

                    playerSettings.PlayerLvl = 4;

                    OffSkinsPlayer();

                    playerSettings.AudioSourcePlayerSettings.Play();

                    playerSettings.clothesPlayer[3].SetActive(true);

                    break;

                case 40:
                    lvlUpParticle.Play();

                    playerSettings.PlayerLvl = 5;

                    OffSkinsPlayer();

                    playerSettings.AudioSourcePlayerSettings.Play();

                    playerSettings.clothesPlayer[4].SetActive(true);

                    break;

                case 50:
                    lvlUpParticle.Play();

                    playerSettings.PlayerLvl = 6;

                    OffSkinsPlayer();

                    playerSettings.AudioSourcePlayerSettings.Play();

                    playerSettings.clothesPlayer[5].SetActive(true);

                    break;

                case 60:
                    lvlUpParticle.Play();

                    playerSettings.PlayerLvl = 7;

                    OffSkinsPlayer();

                    playerSettings.AudioSourcePlayerSettings.Play();

                    playerSettings.clothesPlayer[6].SetActive(true);

                    break;

            

            }
        }


        private void OffSkinsPlayer()
        {
            foreach(var SkinsPlayer in playerSettings.clothesPlayer)
            {
                SkinsPlayer.SetActive(false);
            }
        }

       
    }
}
