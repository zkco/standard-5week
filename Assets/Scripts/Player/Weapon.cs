using UnityEngine;


public abstract class Weapon : MonoBehaviour
{
    public WeaponData Data;


    public abstract void Fire();

    public abstract void FireLogic();
}