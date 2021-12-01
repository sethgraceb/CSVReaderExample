using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CSVReader : MonoBehaviour
{
    public GameObject cubeTest;
    public TextAsset csvFile;


    // Update is called once per frame
    void Update()
    {
        readCSV();
    }

    void readCSV()
    {
        string[] file = csvFile.text.Split('\n');
        for(int i = 1; i < file.Length; i++)
        {
            string[] fields = file[i].Split(',');

            if (Input.GetButtonDown("q"))
            cubeTest.transform.Rotate(float.Parse(fields[1]), float.Parse(fields[2]), float.Parse(fields[3]));
            
            //cubeTest.transform.Translate(float.Parse(fields[1]));
            //var pos = new Vector3(float.Parse(fields[0]), float.Parse(fields[1]), float.Parse(fields[2]));
            //print(pos);
            //cubeTest.transform.position = pos;

            //transform.Translate(1, 1, 1);
        }
    }
}
