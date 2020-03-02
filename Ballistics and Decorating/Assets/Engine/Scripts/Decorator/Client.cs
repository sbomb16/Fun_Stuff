using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour {

    Vector3 nextPos = Vector3.zero;
    IRifle currentRifle;
    IPistol currentPistol;

    //public KeyCode[] keys;

    //private void Start()
    //{
    //    keys = new KeyCode[6];
    //    keys[0] = KeyCode.B;
    //    keys[1] = KeyCode.S;
    //    keys[2] = KeyCode.T;
    //    keys[3] = KeyCode.C;
    //    keys[4] = KeyCode.L;
    //    keys[5] = KeyCode.A;
    //}

    // Update is called once per frame
    public void GetGun (string gunType) {

        //Event e = Event.current;
        //foreach (KeyCode k in keys){
        //    if (Input.GetKeyDown(k))
        //    {
        //        switch (k)
        //        {

        //        }
        //    }
        //}

        switch (gunType)
        {
            case "BaseRifle":

                IRifle rifle = new BasicRifle(nextPos);
                //rifle = new WithLongBarrel(rifle);

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentRifle = rifle;
                    Debug.Log("Basic Accuracy: " + rifle.GetAccuracy() + "/nBasic Ammo Count: " + rifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);                
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentRifle = rifle;
                    Debug.Log("Basic Accuracy: " + rifle.GetAccuracy() + "/nBasic Ammo Count: " + rifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentRifle = rifle;
                    Debug.Log("Basic Accuracy: " + rifle.GetAccuracy() + "/nBasic Ammo Count: " + rifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "LargeRifle":

                IRifle sRifle = new BasicRifle(nextPos);
                sRifle = new WithMagazine(new WithLongBarrel(sRifle));

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentRifle = sRifle;
                    Debug.Log("Large Rifle Accuracy: " + sRifle.GetAccuracy() + "/nAmmo Count: " + sRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentRifle = sRifle;
                    Debug.Log("Large Rifle Accuracy: " + sRifle.GetAccuracy() + "/nAmmo Count: " + sRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentRifle = sRifle;
                    Debug.Log("Large Rifle Accuracy: " + sRifle.GetAccuracy() + "/nAmmo Count: " + sRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "SubMachineGun":

                IRifle dRifle = new BasicRifle(nextPos);
                dRifle = new WithMagazine(new WithLaser(new WithShortBarrel(dRifle)));

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentRifle = dRifle;
                    Debug.Log("SubMachineGun Accuracy: " + dRifle.GetAccuracy() + "/nAmmo Count: " + dRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentRifle = dRifle;
                    Debug.Log("SubMachineGun Accuracy: " + dRifle.GetAccuracy() + "/nAmmo Count: " + dRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentRifle = dRifle;
                    Debug.Log("SubMachineGun Accuracy: " + dRifle.GetAccuracy() + "/nAmmo Count: " + dRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "Sniper":

                IRifle tRifle = new BasicRifle(nextPos);
                tRifle = new WithMagazine(new WithStabilizer(new WithBrake(new WithScope(new WithLongBarrel(tRifle)))));

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentRifle = tRifle;
                    Debug.Log("With Scope, Brake and Stabilizer: " + tRifle.GetAccuracy() + "/nAmmo Count: " + tRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentRifle = tRifle;
                    Debug.Log("With Scope, Brake and Stabilizer: " + tRifle.GetAccuracy() + "/nAmmo Count: " + tRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentRifle = tRifle;
                    Debug.Log("With Scope, Brake and Stabilizer: " + tRifle.GetAccuracy() + "/nAmmo Count: " + tRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "LightMachineGun":

                IRifle cRifle = new BasicRifle(nextPos);
                cRifle = new WithDrum(new WithBrake(new WithLongBarrel(cRifle)));

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentRifle = cRifle;
                    Debug.Log("With Brake: " + cRifle.GetAccuracy() + "/nAmmo Count: " + cRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentRifle = cRifle;
                    Debug.Log("With Brake: " + cRifle.GetAccuracy() + "/nAmmo Count: " + cRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentRifle = cRifle;
                    Debug.Log("With Brake: " + cRifle.GetAccuracy() + "/nAmmo Count: " + cRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "BasePistol":

                IPistol lPistol = new BasicPistol(nextPos);

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentPistol = lPistol;
                    Debug.Log("Base Pistol: " + lPistol.GetAccuracy() + "/nBasic Ammo: " + lPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentPistol = lPistol;
                    Debug.Log("Base Pistol: " + lPistol.GetAccuracy() + "/nBasic Ammo: " + lPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentPistol = lPistol;
                    Debug.Log("Base Pistol: " + lPistol.GetAccuracy() + "/nBasic Ammo: " + lPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "FuddGun":

                IPistol aPistol = new BasicPistol(nextPos);
                aPistol = new PistolFunny(aPistol);

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentPistol = aPistol;
                    Debug.Log("Fudd Gun Accuracy: " + aPistol.GetAccuracy() + "/nBasic Ammo: " + aPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentPistol = aPistol;
                    Debug.Log("Fudd Gun Accuracy: " + aPistol.GetAccuracy() + "/nBasic Ammo: " + aPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentPistol = aPistol;
                    Debug.Log("Fudd Gun Accuracy: " + aPistol.GetAccuracy() + "/nBasic Ammo: " + aPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "LargePistol":

                IPistol bPistol = new BasicPistol(nextPos);
                bPistol = new PistolAveMag(bPistol);

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentPistol = bPistol;
                    Debug.Log("Large Pistol Accuracy: " + bPistol.GetAccuracy() + "/nAmmo Count: " + bPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentPistol = bPistol;
                    Debug.Log("Large Pistol Accuracy: " + bPistol.GetAccuracy() + "/nAmmo Count: " + bPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentPistol = bPistol;
                    Debug.Log("Large Pistol Accuracy: " + bPistol.GetAccuracy() + "/nAmmo Count: " + bPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "RangePistol":

                IPistol dPistol = new BasicPistol(nextPos);
                dPistol = new PistolAveMag(new PistolSight(dPistol));

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentPistol = dPistol;
                    Debug.Log("Range Pistol Accuracy: " + dPistol.GetAccuracy() + "/nAmmo Count: " + dPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentPistol = dPistol;
                    Debug.Log("Range Pistol Accuracy: " + dPistol.GetAccuracy() + "/nAmmo Count: " + dPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentPistol = dPistol;
                    Debug.Log("Range Pistol Accuracy: " + dPistol.GetAccuracy() + "/nAmmo Count: " + dPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "EncumberedPistol":

                IPistol kPistol = new BasicPistol(nextPos);
                kPistol = new PistolLargeMag(kPistol);

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentPistol = kPistol;
                    Debug.Log("Encumbered Pistol Accuracy: " + kPistol.GetAccuracy() + "/nAmmo Count: " + kPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentPistol = kPistol;
                    Debug.Log("Encumbered Pistol Accuracy: " + kPistol.GetAccuracy() + "/nAmmo Count: " + kPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentPistol = kPistol;
                    Debug.Log("Encumbered Pistol Accuracy: " + kPistol.GetAccuracy() + "/nAmmo Count: " + kPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            case "TargetPistol":

                IPistol tPistol = new BasicPistol(nextPos);
                tPistol = new PistolLargeMag(new PistolLaser(new PistolSight(tPistol)));

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentPistol = tPistol;
                    Debug.Log("Target Pistol Accuracy: " + tPistol.GetAccuracy() + "/nAmmo Count: " + tPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentPistol = tPistol;
                    Debug.Log("Target Pistol Accuracy: " + tPistol.GetAccuracy() + "/nAmmo Count: " + tPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }
                else
                {
                    currentPistol = tPistol;
                    Debug.Log("Target Pistol Accuracy: " + tPistol.GetAccuracy() + "/nAmmo Count: " + tPistol.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;

            default:

                IRifle bRifle = new BasicRifle(nextPos);

                if (currentRifle != null)
                {
                    GameObject.Destroy(currentRifle.GetGameObject());
                    currentRifle = bRifle;
                    Debug.Log("Basic Accuracy: " + bRifle.GetAccuracy() + "/nBasic Ammo Count: " + bRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);                
                }
                else if(currentPistol != null)
                {
                    GameObject.Destroy(currentPistol.GetGameObject());
                    currentRifle = bRifle;
                    Debug.Log("Basic Accuracy: " + bRifle.GetAccuracy() + "/nBasic Ammo Count: " + bRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);   
                }
                else
                {
                    currentRifle = bRifle;
                    Debug.Log("Basic Accuracy: " + bRifle.GetAccuracy() + "/nBasic Ammo Count: " + bRifle.GetAmmoCount());
                    //nextPos += new Vector3(1, 0, 0);
                }

                break;
        }               
	}
}
