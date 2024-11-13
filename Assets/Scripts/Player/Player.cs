using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerController Controller;
    public Weapon Weapon;
    public Transform WeaponTransform;


    private void Awake()
    {
        Controller = GetComponent<PlayerController>();
    }
    private void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2)).direction, Color.red);
    }
}
