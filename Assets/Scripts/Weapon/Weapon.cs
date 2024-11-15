using UnityEngine;
using UnityEngine.InputSystem;


public abstract class Weapon : MonoBehaviour
{
    //public WeaponData Data;
    public GameObject BulletPrefab;
    protected Rigidbody _bulletRB;
    protected Camera _camera;

    protected virtual void Awake()
    {
        _camera = Camera.main;
    }

    public virtual void Fire()
    {
        _bulletRB = Instantiate(BulletPrefab, _camera.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
        _bulletRB.AddForce(Aim(), ForceMode.Impulse);
    }
    public abstract Vector3 Aim();
}
