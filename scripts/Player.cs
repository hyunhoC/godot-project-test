using Godot;

namespace NewGame;

public partial class Player : CharacterBody2D
{
	[Export] public float Speed { get; set; } = 80f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		Velocity = direction * Speed;
		MoveAndSlide();
	}
}
