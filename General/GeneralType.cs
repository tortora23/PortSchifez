using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;



//SHIP-----SHIP-----SHIP-----SHIP-----SHIP-----SHIP-----SHIP-----

public class Cargo
{
    int maxSlot;
}

public class Ship
{
public ShipType type;
public GameObject GO;

    public Ship(ShipType type)
    {
        GO = Resources.Load("Ship/" + type.ToString()) as GameObject;
    }
}

public enum ShipType { Corvetta, Cargo, Scout};

//BUILDING-----BUILDING-----BUILDING-----BUILDING-----BUILDING-----BUILDING-----

public class Building : MonoBehaviour
{
    public BuildingType type;
    public GameObject GO;

    public Building(BuildingType type)
    {
        GO = Resources.Load("Buildings/"+ type.ToString()) as GameObject;
    }
}

    


public enum BuildingType { ShipYard, Market, House, Camp, Storage };


//RESOURCES-------RESOURCES-------RESOURCES-------RESOURCES-------RESOURCES-------

public class Resource
{
    public ResType type;
    public uint quantita;

    public Resource(ResType type, uint quantita)
    {
        this.type = type;
        this.quantita = quantita;
    }
}

public enum ResType { Wood, Iron, Rock, Apple, Gold, Silver, Copper };


//CONNECTION--------CONNECTION--------CONNECTION--------CONNECTION--------CONNECTION--------

public enum RequestType { Build, Player, Market, Fleet, Login };

public enum AnswareType { Error, Ok};

public enum DataType {  Ship, Buildign, Upgrade, Destroy,   // Build
                        Load,Save,                          // Player
                        Sell, Buy, Acc,                     // Market
                        Fight, Cover, Cargo,                // Fleet
                        Connect, Disconnect, Register,      // Login
                        Test
                    };

public static class Server
{
    public static string ip = "127.0.0.1";
    public static int port = 666;
}

[Serializable]
public class Msg
{
    public RequestType request;
    public DataType dataType;
    public string data;    
}


