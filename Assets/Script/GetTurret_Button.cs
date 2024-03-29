using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTurret_Button : MonoBehaviour
{
    public GameObject gameObject1;

    public void Turret()
    {
        gameObject1.GetComponent<Testing>().GetTurret();
    }
    public void GoldHouse()
    {
        gameObject1.GetComponent<Testing>().GetGoldHouse();
    }
}
