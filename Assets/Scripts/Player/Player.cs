using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController Controller;
    public Weapon Weapon;


    private void Awake()
    {
        
        Controller = GetComponent<PlayerController>();
    }
}
