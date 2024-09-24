using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class Player : NetworkBehaviour
{

    [SerializeField] float _speed;
    Camera _myCam;
    [SerializeField]
    Vector3 _offSetCam;

    private void Awake()
    {
        _myCam = GetComponentInChildren<Camera>();

    }


    void Start()
    {
        // Solo activamos la cámara si el jugador tiene la autoridad del input (es el jugador local).
        if (HasStateAuthority)
        {
            _myCam.gameObject.SetActive(true);  // Activa la cámara local
        }
        else
        {
            _myCam.gameObject.SetActive(false); // Desactiva la cámara de los otros jugadores
        }
    }

    private void Update()
    {
        if(!HasStateAuthority) return;

        
    }



    public override void FixedUpdateNetwork()
    {
        transform.position += transform.right * (Input.GetAxis("Horizontal") * _speed * Runner.DeltaTime);
        transform.position += transform.forward * (Input.GetAxis("Vertical") * _speed * Runner.DeltaTime);
        _myCam.transform.position = transform.position + _offSetCam;

    }
}
