using UnityEditor;

namespace MyEditor
{
    public class Build
    {
        public static void BuildAnroid()
        {
            string[] scenes = { "Assets/Scenes/Main.unity" };
            BuildPipeline.BuildPlayer(scenes, "Build/Android/CICDTest.apk", BuildTarget.Android, BuildOptions.None);
        }
    }
}
