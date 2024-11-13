using UnityEngine;

public class Gun : Weapon
{
    public override Vector3 Aim()
    {
        _bulletRB.useGravity = false;
        //바라보는 방향
        Vector3 aim = _camera.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2)).direction;

        return aim * 10f;
    }
}
