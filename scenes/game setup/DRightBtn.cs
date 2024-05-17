using Godot;
using System;

public partial class DRightBtn : Button
{
	bool hovered = false;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Pressed += () => {
			this.GetChild<AudioStreamPlayer2D>(2).Stop();
			this.GetChild<AudioStreamPlayer2D>(2).Play();
			this.GetParent().GetChild<difficulty>(3).GetChild<AnimationPlayer>(0).Play("jump");
			if (this.GetParent().GetChild<difficulty>(3).dclty == 2) {
				this.GetParent().GetChild<difficulty>(3).dclty = 0;
			}
			else {
				this.GetParent().GetChild<difficulty>(3).dclty += 1;
			}
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
