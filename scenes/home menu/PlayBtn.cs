using Godot;
using System;

public partial class PlayBtn : Button
{
	public Vector2 defaultscale;
	public Vector2 defaultpos;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Pressed += () => {
			GetTree().ChangeSceneToFile("res://scenes//game setup//game setup.tscn");
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (this.IsHovered()) {
			this.GetChild<Sprite2D>(0).Texture = (Texture2D)GD.Load("res://assets//sprites//playbtnhover.png");
		}
		else {
			this.GetChild<Sprite2D>(0).Texture = (Texture2D)GD.Load("res://assets//sprites//playbtn.png");
		}
	}
}
