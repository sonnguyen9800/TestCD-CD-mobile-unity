using UnityEditor;
using System.IO;
using UnityEngine;

public static class BuildScript
{
    [MenuItem("Tool/Build")]
    public static void BuildAndroid()
    {
        string buildPath = "Builds/Android/MyGame.apk";
        if (!Directory.Exists("Builds/Android"))
            Directory.CreateDirectory("Builds/Android");

        BuildPipeline.BuildPlayer(
            new[] { "Assets/Scenes/SampleScene.unity" }, // change scenes as needed
            buildPath,
            BuildTarget.Android,
            BuildOptions.None
        );

        UnityEngine.Debug.Log("✅ Build complete: " + buildPath);
    }
}
