using Photon.Pun;
using UnityEngine;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPrefab;
    public Transform spawnPoint;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        if (PhotonNetwork.IsConnected)
        {
            // Instantiate Player Prefab at the spawn position
           PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position, spawnPoint.rotation);
            Debug.LogError("Player should be spawned.");
        }
        else
        {
            Debug.LogError("Photon Network Not Connected!");
        }
    }
}
