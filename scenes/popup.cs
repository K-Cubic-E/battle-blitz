using Godot;
using System;

public partial class popup : Node2D
{
	public void setup(string title, string body) {
		this.GetChild(0).GetChild<Label>(1).Text = title;
		this.GetChild(0).GetChild<RichTextLabel>(2).Text = body;
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsMouseButtonPressed(MouseButton.Left)) {
			this.QueueFree();
		}
	}
}
