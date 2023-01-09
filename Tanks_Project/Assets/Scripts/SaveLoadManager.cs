using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoadManager : MonoBehaviour
{
 
    public void SaveData()
    {
        SerializedData mySerializedData = new SerializedData();
        mySerializedData.ser_score = GameData.GameScore;
        mySerializedData.ser_lives = GameData.Lives;

        BinaryFormatter bf = new BinaryFormatter();

        FileStream myfile = File.Create(Application.persistentDataPath + "/TanksData.save");

        bf.Serialize(myfile, mySerializedData);

        myfile.Close();
        Debug.Log("FILE SAVED");

        /*  CODE BELOW USES JSON
        string jsonToSave = JsonUtility.ToJson(mySerializedData);
        Debug.Log(jsonToSave);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/TanksData.json", jsonToSave);
        Debug.Log(Application.persistentDataPath);
        */
    }


    public void LoadData()
    {
        SerializedData mySerializedData = new SerializedData();

        if (File.Exists(Application.persistentDataPath + "/TanksData.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream myfile = File.Open(Application.persistentDataPath + "/TanksData.save", FileMode.Open);
            mySerializedData = (SerializedData)bf.Deserialize(myfile);
            myfile.Close();

            if (mySerializedData != null)
            {
                GameData.GameScore = mySerializedData.ser_score;
                GameData.Lives = mySerializedData.ser_lives;
            }

        }  
            /*  CODE BELOW USES JSON
            if (File.Exists(Application.persistentDataPath + "/TanksData.json"))
            {

                string jsonLoaded = File.ReadAllText(Application.persistentDataPath + "/TanksData.json");
                mySerializedData = JsonUtility.FromJson<SerializedData>(jsonLoaded);
                GameData.GameScore = mySerializedData.ser_score;
                GameData.Lives = mySerializedData.ser_lives;
            }
                */


     }

}
