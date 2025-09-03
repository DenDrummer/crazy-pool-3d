using Godot;

public partial class OrbitalCamera : Node3D
{
    [Export]
    Node3D trackedObject;
    [Export]
    Camera3D camera;

    [Export]
    float distanceToObject = 5;
    [Export]
    float rotationSpeed = 0.5f;

    bool rotating = false;
    Vector2 mouseStartPosition = Vector2.Zero;
    Vector3 startRotation = Vector3.Zero;
    Vector3 targetRotation = Vector3.Zero;

    public override void _Ready()
    {
        startRotation = Rotation;
        targetRotation = Rotation;
    }

    public override void _PhysicsProcess(double delta)
    {
        Position = trackedObject.Position;
        camera.Position = new(0, 0, distanceToObject);
    }

    public override void _Process(double delta)
    {
        if (rotating)
        {
            Vector2 mouseDelta = mouseStartPosition - GetViewport().GetMousePosition();
            targetRotation = startRotation + new Vector3(mouseDelta.Y * rotationSpeed, mouseDelta.X * rotationSpeed, 0);
            targetRotation = new(Mathf.Clamp(targetRotation.X, -1.5f, 1.5f), targetRotation.Y, 0);
            Rotation = targetRotation;
        }
    }

    public override void _Input(InputEvent @event)
    {
        if(@event is InputEventMouseButton)
        {
            InputEventMouseButton mouseButtonEvent = @event as InputEventMouseButton;
            if (mouseButtonEvent.ButtonIndex == MouseButton.Right)
            {
                if (mouseButtonEvent.IsPressed())
                {
                    startRotation = Rotation;
                    mouseStartPosition = GetViewport().GetMousePosition();
                    rotating = true;
                    GD.Print("Rotating");
                }
                else if (mouseButtonEvent.IsReleased())
                {
                    rotating = false;
                    GD.Print("Not rotating");
                    GD.Print($"Target: {targetRotation}");
                }
            }
        }
    }
}
