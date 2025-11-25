using Godot;

public partial class MainMenuButton : Button
{
    [Export]
    PackedScene MainScene;

    // TODO: might want to use a reusable function (in a singleton or something) once more levels exist
    public override void _Pressed()
    {
        GD.Print("We switchin' to Main-Menu yet?");
        SceneTree tree = GetTree();
        GD.Print("Tree loaded");
        Node currentScene = tree.CurrentScene;
        GD.Print("current scene stored");
        Node newScene = MainScene.Instantiate();
        GD.Print("new scene instantiated");
        Window root = tree.Root;
        GD.Print("root received");
        root.AddChild(newScene);
        GD.Print("new scene loaded");
        root.RemoveChild(currentScene);
        GD.Print("old scene yeeted");
        tree.CurrentScene = newScene;
        GD.Print("new scene made current");
    }
}
