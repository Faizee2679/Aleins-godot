using Godot;
using System;

public partial class UserInterface : Control
{
	int scoreValue = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<Label>("Label").Hide();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	void score()
	{
		scoreValue += 1;
		GetNode<Label>("Label").Text = "Score : " + scoreValue.ToString();
	}
	void start()
	{
		GetNode<Timer>("Timer").Start();
		GetNode<Label>("Label").Show();
		GetNode<Button>("Button").Hide();
		GetNode<Timer>("EnemyTimer").Start();
	}
}
