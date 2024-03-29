using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ressource_Manager : MonoBehaviour
{

    public int playerLife;
    public int gold;
    public int wood;
    public Text text;
    private bool goldUp;


    // Start is called before the first frame update
    void Start()
    {
       // text.text = "Gold :" + gold.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(goldUp == false)
        {
            text.text = "Gold :" + gold.ToString();
            goldUp = true;
        }

    }

    public void GetGold(int goldref)
    {
        gold += goldref;
        text.text = "Gold :" + gold.ToString();
        Debug.Log("GetGold" + gold);
    }

    public void GetWood(int woodref)
    {
        wood += woodref;
    }

    public void PlayerGetDmg()
    {
        playerLife -= 1;
    }

    public void UpdateGold(int goldupdate)
    {
        gold = goldupdate;
        text.text = gold.ToString();
    }
}
