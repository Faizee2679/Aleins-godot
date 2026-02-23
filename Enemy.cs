using Godot;
using System;

public partial class Enemy : CharacterBody3D
{
	public override void _PhysicsProcess(double delta)
	{
		MoveAndSlide();
	}
	public void Start(Vector3 playerPos)
	{
		var direction = playerPos - Position;
		playerPos.Y = Position.Y;
		LookAtFromPosition(Position, playerPos, Vector3.Up);
		Velocity = (Vector3.Forward * 5).Rotated(Vector3.Up, Rotation.Y);
	}
	void destroy()
	{
		QueueFree();
	}
}
