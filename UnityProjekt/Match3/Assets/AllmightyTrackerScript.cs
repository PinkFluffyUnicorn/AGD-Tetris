using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class AllmightyTrackerScript : MonoBehaviour {


    //public Text DebugAusgabe;
    //the pat for match.me on android is "Dieser PC\Galaxy S6\Phone\Android\data\com.Balhorn.Octopus_Adventure\files"


    public static AllmightyTrackerScript allmightyTracker;
    string filePath = "/playerInfo.csv";
	// Use this for initialization
	void Awake () {
        if(allmightyTracker == null)
        {
            writeToFile("openned");
            DontDestroyOnLoad(gameObject);
            allmightyTracker = this;
        }
        else if(allmightyTracker != this)
        {
            Destroy(gameObject);
        }
	}

    void OnApplicationFocus(bool inFocus)
    {
        if (inFocus)
        {
            writeToFile("active");
        }
        else
        {
            writeToFile("inactive");
        }
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnApplicationQuit()
    {
        writeToFile("closed");
    }

    public void writeToFile(string data)
    {
        //BinaryFormatter bf = new BinaryFormatter();
        if (!File.Exists(Application.persistentDataPath + filePath))
            File.Create(Application.persistentDataPath + filePath);
        File.AppendAllText(Application.persistentDataPath + filePath, DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") +": "+ data + ",");
        print("Wrote " + data + " to File " + Application.persistentDataPath + filePath);
        //DebugAusgabe.text = Application.persistentDataPath;
    }
}
