using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVWriter : MonoBehaviour
{
    // string filename = "";
    //
    // [System.Serializable]
    // public class Player {
    // }
    // public Player player;
    // Time zoneTime;
    //
    // // Start is called before the first frame update
    // void Start()
    // {
    //   filename = Application.dataPath + "/test.csv";
    //   OpenCSV();
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //   UpdateCSV();
    // }
    //
    // void OpenCSV(){
    //   TextWriter tw = new StreamWriter(filename, false);
    //   tw.WriteLine("Name, Y-rotation, X-position, Z-position, Collected Items, Time, Time in Zone");
    //   tw.Close();
    // }
    //
    // void UpdateCSV(GameObject player){
    //   TextWriter tw = new StreamWriter(filename, true);
    //   tw.WriteLine("player" , "," , player.transform.localRotation.eulerAngles.y , "," , player.transform.position.x);
    //   //  "," , player.transform.position.z , ","  , "3" , Time.timeAsDouble.ToString , "," ,
    //   // zoneTime.ToString);
    //
    //
    //   // player.transform.position
    // }


}
