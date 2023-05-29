using UnityEngine;
using UnityEditor;
using System.IO;

public class DirectoryTreeCreatorWindow : EditorWindow
{
    private string baseFolder = "Assets/"; // Specify the base folder here

    private string[] folderPaths = new string[]
    {
