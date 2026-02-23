using Godot;
using System;

public partial class Player : CharacterBody3D
{
	
	float gravity = -15;
	float fallingSpeed = 0;

	public override void _PhysicsProcess(double delta)
	{
		var direction = new Vector3(0, 0, 0);
		if(Input.IsActionPressed("Right"))
		{
			direction.X = 1;
		}
		if(Input.IsActionPressed("Left"))
		{
			direction.X = -1;
		}
		if(Input.IsActionPressed("Forward"))
		{
			direction.Z = -1;
		}
		if(Input.IsActionPressed("Back"))
		{
			direction.Z = 1;
		}
		if(IsOnFloor())
		{
			fallingSpeed = 0;
		}
		else
		{
			fallingSpeed += gravity * (float)delta;
		}
		if(Input.IsActionPressed("Jump")&& IsOnFloor())
		{
			fallingSpeed = 20;
		}
		Velocity = new Vector3(direction.X * 5, fallingSpeed, direction.Z * 5);
		MoveAndSlide();
		Rotation = new Vector3(0, Rotation.Y, 0);
		GetNode<Node3D>("player").Basis = Basis.LookingAt(direction);
	}
	
	void Hit()
	{
		GD.Print("Hit detected");
	}
}
