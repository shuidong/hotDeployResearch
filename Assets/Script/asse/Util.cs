using UnityEngine;
using System.Collections;

public class Util
{
    public static string getGreenString(string info)
    {
        return "<color=green>" + info + "</color>";
    }

    public static void function1()
    {
        Debug.Log(getGreenString("@debug: f1 called."));
    }
}
