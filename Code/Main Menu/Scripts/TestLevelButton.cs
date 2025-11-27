using Godot;
using System.IO;

public partial class TestLevelButton : Button
{
    [Export(PropertyHint.File,"*.tscn")]
    string LevelFile;

    // TODO: might want to use a reusable function (in a singleton or something) once more levels exist
    public override void _Pressed()
    {
        SceneTree tree = GetTree();
        Node currentScene = tree.CurrentScene;
        PackedScene packedScene = ResourceLoader.Load<PackedScene>(LevelFile);
        Node newScene = packedScene.Instantiate();
        Window root = tree.Root;
        root.AddChild(newScene);
        root.RemoveChild(currentScene);
        tree.CurrentScene = newScene;
    }
}
