using Godot;
using System;

public partial class MainScene : Node3D
{
	[Export]
	public PackedScene originalEnemy;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	void createClone()
	{
		var Clone = originalEnemy.Instantiate<Enemy>();
		Clone.Position = new Vector3(0, 2, -3);
		var Player = GetNode<Node3D>("CharacterBody3D");
		Clone.Start(Player.Position);
		AddChild(Clone);
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
