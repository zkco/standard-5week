using UnityEngine;

public class Grenade : Weapon
{
    public override Vector3 Aim()
    {
        _bulletRB.useGravity = true;
        _bulletRB.mass = 1f;
        Vector3 aim = _camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2)).direction;
        return aim * 10;
    }
}
