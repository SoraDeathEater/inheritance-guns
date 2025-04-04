using UnityEngine;

public class Pullback_Gun : Gun
{
    public override bool AttemptFire()
    {
        if (!base.AttemptFire())
            return false;

        var b = Instantiate(bulletPrefab, gunBarrelEnd.transform.position, gunBarrelEnd.rotation);
        b.GetComponent<Projectile>().Initialize(0, 100, 1, -10, null); // version without special effect

        anim.SetTrigger("shoot");
        elapsed = 0;
        ammo -= 1;

        return true;
    }
}
