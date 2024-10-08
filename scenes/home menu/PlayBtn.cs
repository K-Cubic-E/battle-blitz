using Godot;
using System;

public partial class PlayBtn : Button
{
	public Vector2 defaultscale;
	public Vector2 defaultpos;

	PackedScene packedscene;
	bool hovered = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		packedscene = (PackedScene)GD.Load("res://scenes//game setup//game setup.tscn");
		this.Pressed += () => {
			this.GetChild<AudioStreamPlayer2D>(2).Play();
			Node2D instance = (Node2D)packedscene.Instantiate();
			this.GetParent().GetParent().AddChild(instance);
			this.GetParent().QueueFree();
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (this.IsHovered()) {
			this.GetChild<Sprite2D>(0).Texture = (Texture2D)GD.Load("res://assets//sprites//playbtnhover.png");
			if (!hovered) {
				this.GetChild<AudioStreamPlayer2D>(1).Play();
				hovered = true;
			}
		}
		else {
			this.GetChild<Sprite2D>(0).Texture = (Texture2D)GD.Load("res://assets//sprites//playbtn.png");
			hovered = false;
		}
	}
}
/*
shoutout to...

excella
dummy
femcil
miratu
shia
bel ange
jynx
my dick
*/
