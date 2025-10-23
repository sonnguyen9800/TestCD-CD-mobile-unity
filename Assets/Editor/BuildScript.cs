using UnityEditor;
using System.IO;

public static class BuildScript
{
    public static void BuildAndroid()
    {
        string buildPath = "Builds/Android/MyGame.apk";
        if (!Directory.Exists("Builds/Android"))
            Directory.CreateDirectory("Builds/Android");

        BuildPipeline.BuildPlayer(
            new[] { "Assets/Scenes/MainScene.unity" }, // change scenes as needed
            buildPath,
            BuildTarget.Android,
            BuildOptions.None
        );

        UnityEngine.Debug.Log("✅ Build complete: " + buildPath);
    }
}
