using UnityEngine;
using UnityEngine.InputSystem;


public abstract class Weapon : MonoBehaviour
{
    //public WeaponData Data;
    public GameObject BulletPrefab;
    protected Rigidbody _bulletRB;
    protected Camera _camera;

    public virtual void Fire()
    {
        if (CharacterManager.Instance.Player.Weapon == this)
        {
            _bulletRB = Instantiate(BulletPrefab, _camera.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            _bulletRB.AddForce(Aim(), ForceMode.Impulse);
        }
    }
    public abstract Vector3 Aim();

    protected virtual void Awake()
    {
        _camera = Camera.main;
    }
}
