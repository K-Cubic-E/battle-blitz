using Godot;
using System;

public partial class CreditsBtn : Button
{
	public Vector2 defaultscale;
	public Vector2 defaultpos;

	PackedScene packedscene;
	bool hovered = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		packedscene = (PackedScene)GD.Load("res://scenes//popup.tscn");
		this.Pressed += () => {
			this.GetChild<AudioStreamPlayer2D>(2).Play();
			popup instance = (popup)packedscene.Instantiate();
			this.GetParent().GetParent().AddChild(instance);
			instance.setup("Credits", "Cubic - Lead Programmer/Artist/Music\nMiratu & ThatOneRandomHuman - Extra Programming\nFemcil - Concept Artist");
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (this.IsHovered()) {
			this.GetChild<Sprite2D>(0).Texture = (Texture2D)GD.Load("res://assets//sprites//creditsbtnhover.png");
			if (!hovered) {
				this.GetChild<AudioStreamPlayer2D>(1).Play();
				hovered = true;
			}
		}
		else {
			this.GetChild<Sprite2D>(0).Texture = (Texture2D)GD.Load("res://assets//sprites//creditsbtn.png");
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
