using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEditor;

public class OpenXRSDKMenu : MonoBehaviour
{
    [MenuItem("OpenXRSDK/Install registry")]
    static void InstallRegistry()
    {
        string projectCurrentDir = Directory.GetCurrentDirectory();
        string workingPath = projectCurrentDir + "\\OpenXRRuntime\\install\\";
        string registryPath = workingPath + "openxr_monado.reg";
        string jsonPath = workingPath + "openxr_monado.json";
        jsonPath = jsonPath.Replace("\\" , "\\\\");

        StringBuilder regText = new StringBuilder("Windows Registry Editor Version 5.00\r\n");
        regText.Append("\r\n");
        regText.Append("[HKEY_LOCAL_MACHINE\\SOFTWARE\\Khronos\\OpenXR\\1]\r\n");
        regText.Append("\"ActiveRuntime\"=\"" + jsonPath + "\"");

        StreamWriter sw = new StreamWriter(registryPath);
        sw.WriteLine(regText.ToString());
        sw.Close();

        ProcessStartInfo start = new ProcessStartInfo();
        start.Arguments = "/S "+ registryPath;
        start.FileName = "regedit.exe";
        start.WindowStyle = ProcessWindowStyle.Hidden;
        start.CreateNoWindow = false;

        Process.Start(start);

        UnityEngine.Debug.Log(registryPath);

    }

    [MenuItem("OpenXRSDK/Run monado-service")]
    static void RunMonadoService()
    {
        string projectCurrentDir = Directory.GetCurrentDirectory();
        string workingPath = projectCurrentDir + "\\OpenXRRuntime\\install\\bin\\";
        string programName = "monado-service.exe";

        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = workingPath + programName;
        start.WindowStyle = ProcessWindowStyle.Hidden;
        start.CreateNoWindow = false;

        Process.Start(start);

        UnityEngine.Debug.Log(workingPath);
    }
}