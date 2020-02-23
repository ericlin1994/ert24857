using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class txtIO : MonoBehaviour
{
	
    void Start ()
    {
        //WriteToFile();
    }
    void Awake(){
    	
    }
    
   
    public void WriteToFile0(string time,string s)
    {	
		//StartCoroutine(IEWriteToFile(name,time,s));
    	StreamWriter sw = new StreamWriter( "Logfile.txt" ,true);
    	//StreamWriter sw = new StreamWriter( "C:/"+name+".txt" ,true);
        sw.WriteLine(time+": "+s);
        sw.Close();
		WriteToFile1 (s);
    }
    public  void WriteToFile1(string s)
    {	
		//StartCoroutine(IEWriteToFile(name,time,s));
    	StreamWriter sw = new StreamWriter( "Logfile1.txt" ,true);
        sw.Write(s);
        sw.Close();
    }

   
     void Update (){

    }
}