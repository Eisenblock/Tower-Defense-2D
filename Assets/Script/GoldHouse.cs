using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldHouse : MonoBehaviour
{

    private GameObject ressource;
    public int income;
    public int time;
    private float i;

    // Start is called before the first frame update
    void Start()
    {
        ressource = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        i += Time.deltaTime;
        GetIncome();
    }

    private void GetIncome()
    {
        if(i >= time)
        {
            ressource.GetComponent<Ressource_Manager>().GetGold(income);
            i = 0;
        }
    }
}
