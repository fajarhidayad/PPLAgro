using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class database : MonoBehaviour {

	// Use this for initialization
	void Start () {
		  string conn = "URI=file:" + Application.dataPath + "/Plugins/database.s3db"; //Path to database.
     IDbConnection dbconn;
     dbconn = (IDbConnection) new SqliteConnection(conn);
     dbconn.Open(); //Open connection to the database.
     IDbCommand dbcmd = dbconn.CreateCommand();
     string sqlQuery = "SELECT * " + "FROM Highscore";
     dbcmd.CommandText = sqlQuery;
     IDataReader reader = dbcmd.ExecuteReader();
     while (reader.Read())
     {
         int id = reader.GetInt32(0);
         string Nama = reader.GetString(1);
         int score = reader.GetInt32(2);
        
         Debug.Log( "value= "+id+"  name ="+Nama);
     }
     reader.Close();
     reader = null;
     dbcmd.Dispose();
     dbcmd = null;
     dbconn.Close();
     dbconn = null;
 }
	}

