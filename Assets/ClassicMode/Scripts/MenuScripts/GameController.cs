using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameController : MonoBehaviour {
    public static GameController control;

	public int originalHighScore;
    public int selectionHighScore;

    void Awake()
    {

        Screen.orientation = ScreenOrientation.Portrait;
        Application.targetFrameRate = 60;
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if(control != this)
        {
            Destroy(this);
        }

        if (File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

			originalHighScore = data.originalHighScore;
            selectionHighScore = data.selectionHighScore;
        }
        else
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

            PlayerData data = new PlayerData();

			data.originalHighScore = originalHighScore;
            data.selectionHighScore = selectionHighScore;

            bf.Serialize(file, data);
            file.Close();
        }
    }

    public void save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");

        PlayerData data = new PlayerData();

		data.originalHighScore = originalHighScore;
        data.selectionHighScore = selectionHighScore;

        bf.Serialize(file, data);
        file.Close();
    }

}


[Serializable]
class PlayerData
{
    public int originalHighScore;
    public int selectionHighScore;
}