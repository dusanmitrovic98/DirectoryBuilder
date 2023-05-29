using UnityEngine;
using UnityEditor;
using System.IO;

public class DirectoryTreeCreatorWindow : EditorWindow
{
    private string baseFolder = "Assets/"; // Specify the base folder here

    private string[] folderPaths = new string[]
    {
        "Editor",
        "Materials",
        "Models",
        "Prefabs",
        "Scripts",
        "Textures",
        "Audio",
        "Animations",
        "Fonts",
        "Shaders",
        "Documentation",
        "DemoScenes"
    }; // Array of folder paths

    [MenuItem("Window/Directory Tree Creator")]
    public static void ShowWindow()
    {
        GetWindow<DirectoryTreeCreatorWindow>("Directory Tree Creator");
    }

    private void OnGUI()
    {
        GUILayout.Label("Directory Tree Creator", EditorStyles.boldLabel);

        GUILayout.Space(10f);

        baseFolder = EditorGUILayout.TextField("Base Folder Path:", baseFolder);

