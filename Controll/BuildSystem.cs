using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSystem : MonoBehaviour {

    public BuildingType type;
    private Building build;
    private Vector2 pos;
    private bool buildingProces = false;
    
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (buildingProces)
        {

        }

    }
    
    public void loadButton()
    {

    }

    public void startContruction()
    {

        if (GeneralMethod.checkRes(build.GO.GetComponent<HelperBuilding>().getCost()))
        {
            if (Connection.check(RequestType.Build, build.GO.name))
            {
                Player.buildings.Add(build);
                //spawn cantiere , timer, ecc ecc
            }
        }
        else
        {
            //non hai abbastanza risorse
        }
        buildingProces = false;
    }


}
