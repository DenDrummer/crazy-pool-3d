using Godot;

public partial class GameScene : Resource
{
    [Export]
    public PackedScene scene;
    [Export]
    public string Name = "";
    [Export]
    public string[] tags = [];
    [Export(PropertyHint.Range, "1,255")]
    public byte par = 3;

    public GameScene() { }

    public GameScene(string name)
    {
        Name = name;
    }

    public GameScene(PackedScene scene, string name, string[] tags, byte par = 3)
    {
        this.scene = scene;
        Name = name ?? "";
        this.tags = tags ?? [];
        this.par = par;
    }

    public GameScene(Node node, string name, string[] tags, byte par = 3)
    {
        scene = new();
        scene.Pack(node);
        Name = name ?? "";
        this.tags = tags ?? [];
        this.par = par;
    }
}