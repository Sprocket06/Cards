using Godot;
using System;
using CardsBackend;

public partial class main : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("fuck");
		CardManager.LoadCards();
		PackedScene testCard = GD.Load<PackedScene>("res://card.tscn");
		var instance = (Card)testCard.Instantiate();
		AddChild(instance);
		instance.Init(CardManager.StaticData[0]);	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
