using Godot;
using System;

public partial class BackBtn : Button
{
	public Vector2 defaultscale;
	public Vector2 defaultpos;

	PackedScene packedscene;
	bool hovered = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		packedscene = (PackedScene)GD.Load("res://scenes//home menu//home.tscn");
		this.Pressed += () => {
			this.GetChild<AudioStreamPlayer2D>(2).Play();
			Node2D instance = (Node2D)packedscene.Instantiate();
			this.GetParent().GetParent().AddChild(instance);
			this.GetParent().QueueFree();
			try {
				AudioStreamPlayer2D temp = (AudioStreamPlayer2D)instance;
				temp.Stop();
			}
			catch (Exception ex) {}
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (this.IsHovered()) {
			this.GetChild<Sprite2D>(0).Texture = (Texture2D)GD.Load("res://assets//sprites//backbtnhover.png");
			if (!hovered) {
				this.GetChild<AudioStreamPlayer2D>(1).Play();
				hovered = true;
			}
		}
		else {
			this.GetChild<Sprite2D>(0).Texture = (Texture2D)GD.Load("res://assets//sprites//backbtn.png");
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
