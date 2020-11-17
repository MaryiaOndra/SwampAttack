using UnityEngine;

public class UZI : Weapon
{
    public override void Shoot(Transform shotPoint)
    {
        Instantiate(Bullet, shotPoint.position, Quaternion.identity);
    }
}
