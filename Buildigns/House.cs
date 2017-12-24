using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour {
    Ray ray;
    RaycastHit hit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

     /*   if (GeneralMethod.checkRes()
        {
            if (Connection.check(RequestType.Build, build.GO.name))
            {

            }
        }*/
    }
    public void destroy()
    {

    }
    public void info()
    {

    }
    

}
