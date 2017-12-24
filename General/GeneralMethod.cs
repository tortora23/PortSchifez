using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class GeneralMethod  {

	static public Type getTypeOf(string type)
    {
        switch (type)
        {
            // type of buildings------------type of buildings------------type of buildings------------type of buildings------------

            case "House":
                return typeof(House);
                break;
            case "ShipYard":
                return typeof(ShipYard);
                break;
            case "Camp":
                return typeof(Camp);
                break;
            case "Market":
                return typeof(Market);
                break;
            case "Storage":
                return typeof(Storage);
                break;
            default:
                return null;
                break;
                   
        }
    }

    public static bool checkRes(List<Resource> cost)
    {
        uint res;

        foreach (Resource a in cost)
        {
            res = Player.resources.Find(x => x.type == a.type).quantita;
            if (a.quantita > res)
                return false;
        }

        return true;

    }
}
