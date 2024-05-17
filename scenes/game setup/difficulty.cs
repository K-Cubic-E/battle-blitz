using Godot;
using System;

public partial class difficulty : Sprite2D
{
	string[] difficulties = {"res://assets//sprites//easydifficulty.png", "res://assets//sprites//mediumdifficulty.png", "res://assets//sprites//harddifficulty.png"};
	public int dclty = 1;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		this.Texture = (Texture2D)GD.Load(difficulties[dclty]);
	}
}
