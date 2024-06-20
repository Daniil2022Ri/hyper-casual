using Assets.Scripts.Player;
using UnityEngine;

public class SpawPlayer : MonoBehaviour
{
    [SerializeField] private SettingsPlayer SettingsPlayer;



    private void Start()
    {
        Instantiate(SettingsPlayer , transform.position, transform.rotation);
    }


}
