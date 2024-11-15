using UnityEngine;

public class Magic : Weapon
{
    public override void Fire()
    {
        for (int i = 0; i < 10; i++)
        {
            _bulletRB = Instantiate(BulletPrefab, _camera.transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            _bulletRB.AddForce(AimCircle(_bulletRB, i), ForceMode.Impulse);
        }
    }
    public override Vector3 Aim()
    {
        return Vector3.zero;
    }

    public Vector3 AimCircle(Rigidbody rb, int i)
    {
        Vector3 aim = new Vector3(Mathf.Sin((Mathf.PI * i * 2) / 10), 0, Mathf.Cos(-(Mathf.PI * i * 2) / 10));
        _bulletRB.useGravity = false;
        return aim * 10;
    }
}