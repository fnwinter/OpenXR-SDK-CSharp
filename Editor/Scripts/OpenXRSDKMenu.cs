using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;
using UnityEditor;

public class OpenXRSDKMenu : MonoBehaviour
{
    [MenuItem("OpenXRSDK/Install registry")]
    static void InstallRegistry()
    {

    }

    [MenuItem("OpenXRSDK/Run monado-service")]
    static void RunMonadoService()
    {
        string projectCurrentDir = Directory.GetCurrentDirectory();
        string workingPath = projectCurrentDir + "\\OpenXRRuntime\\install\\bin\\";
        string programName = "monado-service.exe";

        UnityEngine.Debug.Log(workingPath);
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = workingPath + programName;
        start.WindowStyle = ProcessWindowStyle.Hidden;
        start.CreateNoWindow = false;

        Process.Start(start);
    }
}