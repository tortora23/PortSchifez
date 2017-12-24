using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using UnityEngine;

public static class ConnectionSocket {
    
    static byte[] bData;
    static int buffLenght = 1028;
    static TcpClient client;
    static NetworkStream stream;
    static BinaryFormatter formatter;

    //INIZIALIZE CONNECTION-------------INIZIALIZE CONNECTION-------------INIZIALIZE CONNECTION-------------INIZIALIZE CONNECTION-------------

    static public void init()               
    {
        client = new TcpClient(Server.ip, Server.port);
        stream = client.GetStream();
        
        formatter = new BinaryFormatter();
        bData = new byte[buffLenght];

      /*  Thread t = new Thread(receive);
        t.Start();*/
    }

    //TEST ABOUT REQUEST AND RESPONS-----------------TEST ABOUT REQUEST AND RESPONS-----------------TEST ABOUT REQUEST AND RESPONS-----------------

    static public bool test()               
    {
        Msg msg = new Msg { dataType = DataType.Test };

        foreach (RequestType a in Enum.GetValues(typeof(RequestType)))
        {
            msg.request = a;
            send(msg);

        }

        return true;
    }


    static public void send(Msg msg)
    {
        if (stream.CanWrite)
        {
            using (var ms = new MemoryStream())
            {
              //  using (var ds = new DeflateStream(ms, CompressionMode.Compress, true))
              //  {
                    formatter.Serialize(ms, msg);
             //   }
                ms.Position = 0;
                bData = ms.GetBuffer();

                if (msgCheck(msg, bData))
                    stream.Write(bData, 0, bData.Length);
                else
                    Debug.Log("Errore nella serializzazione");
            }
        }
    }

    static public void receive()
    {
        while (true)
        {
            if (stream.CanRead)
            {
                stream.Read(bData, 0, (int)client.ReceiveBufferSize);
                parse();
            }
        }
    }

    static public void parse()
    {
    }

    static private bool msgCheck(Msg msg, byte[] data)
    {
        Msg test;
        using (var ms = new MemoryStream(bData))
        {
            //  using (var ds = new DeflateStream(ms, CompressionMode.Decompress, true))
            //  {
            test = (Msg)formatter.Deserialize(ms);
            //   }
        }

        if (msg.Equals(test))
            return true;
        else
            return false;
    }

}

