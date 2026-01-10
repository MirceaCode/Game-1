using Godot;
using System;

public partial class Ocean : Node2D
{
	[Export] private Sprite2D _planeSprite;
	[Export] private Sprite2D _heliSprite;

	public override void _Ready()
	{
		GD.Print("Success!");
	}

	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("ui_up"))
		{
			_planeSprite.Position = new Vector2(
			_planeSprite.Position.X + 50.0f * (float)delta,
			_planeSprite.Position.Y
		);
			_heliSprite.Position = new Vector2(
			_heliSprite.Position.X + 100.0f * (float)delta,
			_heliSprite.Position.Y
		);

		}

		if (Input.IsActionJustPressed("ui_down"))
		{
			_heliSprite.Position = new Vector2(
			_heliSprite.Position.X, 
			_heliSprite.Position.Y + 50.0f * (float)delta
		);
		}
	}
}
