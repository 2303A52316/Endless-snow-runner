using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class SnowRunnerSetup
{
    [MenuItem("Snow Runner/Create Snow Rush Scene")]
    public static void Create()
    {
        Scene scene=EditorSceneManager.NewScene(NewSceneSetup.EmptyScene,NewSceneMode.Single);
        new GameObject("Snow Rush Game Manager").AddComponent<SnowRunnerGame>();
        if(!AssetDatabase.IsValidFolder("Assets/Scenes"))AssetDatabase.CreateFolder("Assets","Scenes");
        EditorSceneManager.SaveScene(scene,"Assets/Scenes/SnowRunner.unity");
        AssetDatabase.SaveAssets();AssetDatabase.Refresh();
        EditorUtility.DisplayDialog("Snow Rush","Scene created. Open Assets/Scenes/SnowRunner.unity and press Play.","OK");
    }
}
