using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class ShipYard : MonoBehaviour, HelperBuilding {

    Ray ray;
    RaycastHit hit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            switch (hit.collider.gameObject.name)
            {
                case "Upgrade":
                    break;
                case "Destroy":
                    break;
                case "Info":
                    break;
                case "BuildShip":
                    break;
            }
        }

    }

    public void openMenu()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    //MENU FUNCTION--------------MENU FUNCTION--------------MENU FUNCTION--------------MENU FUNCTION--------------MENU FUNCTION--------------

    public void upgrade()
    {

    }
    public void destroy()
    {

    }
    public void info()
    {

    }
    public void buildShip()
    {

    }

    //BUILDIGN COST-----------------BUILDIGN COST-----------------BUILDIGN COST-----------------BUILDIGN COST-----------------BUILDIGN COST-----------------

    public List<Resource> getCost()
    {
        return ShipYardCost;
    }

    public static readonly List<Resource> ShipYardCost = new List<Resource>() {
            new Resource(ResType.Wood, 10),
            new Resource(ResType.Iron, 5),
            new Resource(ResType.Gold, 10)

    };
}
