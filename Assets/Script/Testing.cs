using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{


    private GameObject res;
    public GameObject gameObject1;
    public GameObject currentCell;

    private GameObject currentObject;
    public int gold;
    public bool updateGold;

    //GoldHouse
    public GameObject gold_House;
    private bool gold_Up = false;

    //Turret1
    public GameObject turret;
    private bool turret_UP = false;
   
    private int x, y , cellX , cellY;
    private float cellsize;  
    public Grid grid;

    


    // Start is called before the first frame update
    void Start()
    {
        res = GameObject.FindWithTag("MainCamera");
        x = 19; y = 8; cellsize = 1f;
        grid = new Grid(x, y, cellsize);
        //TextGrid(x, y, cellsize);
    }

    // Update is called once per frame
    void Update()
    {
        if(gold_Up == false)
        {
            gold = res.GetComponent<Ressource_Manager>().gold;
            Debug.Log("gold Test" + gold);
            gold_Up = true;
        }
 

        MouseSpawn(x, y, cellsize);      
    }

    private void TextGrid(int x, int y, float cellsize )
    {
        for ( int i = 0; i <= x; i++ ) 
        {
            for( int j = 0; j <= y; j++ ) 
            {
                Vector3 cellPosition = new Vector3(i * cellsize, j * cellsize, 0f);
                        //Instantiate(gameObject, cellPosition, Quaternion.identity);
            }
        }
    }

    public void MouseSpawn(int x , int y , float cellsize)
    { 
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cellX = Mathf.FloorToInt(mousePosition.x/cellsize);
        cellY = Mathf.FloorToInt(mousePosition.y/cellsize);        

        if(cellX >= 0 && cellX <= 19 && cellY >= 0 && cellY < 10 ) 
        { 
            Vector3 spawnCurrent = new Vector3(cellX + 0.5f, cellY + 0.5f, 0f);
            //Instantiate(currentCell, spawnCurrent, Quaternion.identity);
            if (Input.GetMouseButtonDown(0)) 
            { 
                Vector3 spawnPos = new Vector3(cellX + 0.5f , cellY + 0.5f, 0f);
                
                if(turret_UP == true && gold >= 100) 
                {
                    Instantiate(turret, spawnPos, Quaternion.identity);
                    gold -= 100;
                    gold_Up = false;
                    res.GetComponent<Ressource_Manager>().UpdateGold(gold);
                }
               
                if(gold_Up == true && gold >= 100)
                {
                    Instantiate(gold_House, spawnPos, Quaternion.identity);
                    gold -= 100;
                    gold_Up = false;
                    res.GetComponent<Ressource_Manager>().UpdateGold(gold);
                }
                
            }
        } 
    }

    public void GetTurret()
    {
        gold_Up = false;
        turret_UP = true;
        
    }

    public void GetGoldHouse()
    {
        turret_UP = false;
        gold_Up = true;
    }
}
