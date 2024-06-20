
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class ParticleSystemsObjects : MonoBehaviour
    {
      

        [SerializeField] protected ParticleSystem MoneyParticle;
        [SerializeField] protected ParticleSystem BottleParticle;

        //[SerializeField] protected ParticleSystem WinPlayerParticle;

        //[SerializeField] protected ParticleSystem NextLvlPlayerParticle;


        private void Start()
        {
            ParticleSystemsOffStartRound();
        }

        private void Update()
        {
           
        }


        private void OnTriggerEnter(Collider other)
        {
           
            if (other.gameObject.CompareTag("Money"))
            {
                MoneyParticle.Play();
            }

            if (other.gameObject.CompareTag("Bottle"))
            {
                BottleParticle.Play();
            }
        }

        private void ParticleSystemsOffStartRound()
        { 

            MoneyParticle.Stop();
            BottleParticle.Stop();

           

           
           // WinPlayerParticle.Stop();
           // NextLvlPlayerParticle.Stop();
        }


    }
}
