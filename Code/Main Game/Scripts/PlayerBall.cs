using Godot;
using System;

public partial class PlayerBall : RigidBody3D
{
    [ExportGroup("Scene Objects")]
    [Export]
    Camera3D Camera;
    [Export]
    Label3D ShotsLabel;

    [ExportGroup("Values")]
    [Export]
    float PoolCueForce = 5f;
    [Export]
    float speedLimit = 0.1f;
    [Export]
    float rotationLimit = 0.2f;

    byte shots = 0;
    bool moving = true;
    bool rotating = true;

    public override void _Input(InputEvent @event)
    {
        if (!moving && !rotating &&
            @event is InputEventMouseButton mouseButtonEvent &&
            mouseButtonEvent.Pressed &&
            mouseButtonEvent.ButtonIndex == MouseButton.Left)
        {
            GD.Print("Ball clicked");
            Vector3 direction = (GlobalPosition - Camera.GlobalPosition).Normalized();
            ApplyCentralImpulse(direction * PoolCueForce);

            shots++;
            ShotsLabel.Text = shots.ToString();
        }
    }

    public override void _Process(double delta)
    {
        ShotsLabel.GlobalPosition = GlobalPosition + new Vector3(0, 0.75f, 0);
        ShotsLabel.GlobalRotation = new(0, Camera.GlobalRotation.Y, 0);

        float r, g, b;

        r = moving ? 1 : 0.7f;
        g = moving || rotating ? 0.7f : 1;
        b = rotating ? 1 : 0.7f;
        ShotsLabel.Modulate = new(r, g, b);
    }

    public override void _PhysicsProcess(double delta)
    {
        moving = LinearVelocity.Length() > speedLimit;
        rotating = AngularVelocity.Length() > rotationLimit;
    }
}
