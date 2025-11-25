using Godot;

public partial class TestLevelButton : Button
{
    [Export]
    PackedScene TestLevel;

    // TODO: might want to use a reusable function (in a singleton or something) once more levels exist
    public override void _Pressed()
    {
        GD.Print("We switchin' to Test-Level yet?");
        SceneTree tree = GetTree();
        Node currentScene = tree.CurrentScene;
        Node newScene = TestLevel.Instantiate();
        Window root = tree.Root;
        root.AddChild(newScene);
        root.RemoveChild(currentScene);
        tree.CurrentScene = newScene;
    }
}
