using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    public static int turret;

	public void PurchaseStandardTurret(){
        turret = 1;
        Debug.Log("Standard Turret Purchased"+turret);
        
    }

    public void PurchaseAnotherTurret()
    {
        turret = 2;
        Debug.Log("Another Turret Purchased"+turret);
        
    }

    public static int getTurret() {
        return turret; 
    }
}
