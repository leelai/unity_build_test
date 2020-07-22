using UnityEditor;
using UnityEngine;

class MyEditorScript
{
    static void PerformBuild()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };
        //BuildPipeline.BuildPlayer(scenes, "Build/Win/Test.exe",
        //     BuildTarget.StandaloneWindows64,
        //     BuildOptions.None);

        //Build
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenes;
        buildPlayerOptions.locationPathName = "./builds/test.apk";
        buildPlayerOptions.target = BuildTarget.Android;
        buildPlayerOptions.options = BuildOptions.None;

        UnityEditor.Build.Reporting.BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        UnityEditor.Build.Reporting.BuildSummary summary = report.summary;

        if (summary.result == UnityEditor.Build.Reporting.BuildResult.Succeeded)
        {
            Debug.Log("<color=green>Build succeeded: " + summary.totalSize + " bytes</color>");
        }

        if (summary.result == UnityEditor.Build.Reporting.BuildResult.Failed)
        {
            Debug.Log("<color=red>Build failed</color>");
        }
    }
}
