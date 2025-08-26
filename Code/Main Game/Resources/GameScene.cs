using Godot;

public partial class GameScene : Resource
{
    [Export]
    public PackedScene scene;
    [Export]
    public string Name = "";
    [Export]
    public string[] tags = [];

    public GameScene() { }

    public GameScene(string name)
    {
        Name = name;
    }
}