using Godot;

public partial class GameScene : Node
{
    [Export]
    public PackedScene scene;
    [Export]
    public string Name = "";
    [Export]
    public string[] tags = [];
    [Export(PropertyHint.Range, "1,255")]
    public byte par = 3;

    void PackGameScene()
    {
        scene.Pack(this);
        
        FileAccess fileAccess = FileAccess.Open($"res://Scenes/levels/{Name}.tscn", FileAccess.ModeFlags.WriteRead);

        fileAccess.StoreVar(scene);

        fileAccess.Close();
    }
}