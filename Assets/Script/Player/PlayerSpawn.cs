using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class PlayerSpawn : SimulationBehaviour, IPlayerJoined
{
    [SerializeField]
    GameObject _playerPrefab;

    //Se ejecuta por jugador conectado
    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer)
        Runner.Spawn(_playerPrefab);
    }
}
