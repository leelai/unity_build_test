using UnityEditor;

class MyEditorScript
{
    static void PerformBuild()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };
        BuildPipeline.BuildPlayer(scenes, "d:/Test.exe",
             BuildTarget.StandaloneWindows64,
             BuildOptions.None);
    }
}
