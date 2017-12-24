using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Connection {

    public static bool isReady  = false;
    public static bool isLogIn = true;

    // Use this for initialization
    public static void start() {
        
        ConnectionSocket.init();
        ConnectionSocket.test();
        
	}

    //GENERAL METHOD------------GENERAL METHOD------------GENERAL METHOD------------GENERAL METHOD------------GENERAL METHOD------------


    public static bool login(string nick)
    {
        if (true && !isLogIn)
        {
            Player.nick = nick;
            isLogIn = true;
            load();
            return true;
        }

        return false;
    }

    public static void close()
    {

    }

    public static void load()
    {
        Resource    res;
        Ship        ship;
        Building    building;

        // populate lists

  /*      foreach (a)// populate buildings
        {
            building = new Building(( (BuildingType) Enum.Parse(typeof(BuildingType), "" )));
            Player.buildings.Add(building);
        }

        foreach (a)// populate resources
        {
            res = new Resource(((ResType)Enum.Parse(typeof(ResType), "")), quantitá);
            Player.resources.Add(res);
        }
        foreach (a)// populate ships
        {
            ship = new Ship(((ShipType) Enum.Parse(typeof(ShipType), "")));
            Player.ships.Add(ship);
        }*/

    }

    public static void save()
    {

    }

    //SERVER COMMAND ABOUT CREATING-------------SERVER COMMAND ABOUT CREATING-------------SERVER COMMAND ABOUT CREATING-------------

    public static bool check(RequestType type, string req)
    {
        return true;
    }

    //MARKET COMMAND ---------MARKET COMMAND ---------MARKET COMMAND ---------MARKET COMMAND ---------MARKET COMMAND ---------

    public static void setPos()
    {

    }

    public static void accPos()
    {

    }

    //FLEET COMMAND ---------FLEET COMMAND ---------FLEET COMMAND ---------FLEET COMMAND ---------FLEET COMMAND ---------

    public static void sendFleet()
    {

    }

}
