using Godot;
using System;
using CardsBackend;

public partial class Card : Control
{
	private Label _nameLabel;
	private Label _costLabel;
	private Label _powerLabel;
	private RichTextLabel _descriptionLabel;
	private Label _healthLabel;
	private CardStaticData _data;
	
	public override void _Ready()
	{
		_nameLabel = GetNode<Label>("Name");
		_costLabel = GetNode<Label>("Cost");
		_powerLabel = GetNode<Label>("Power");
		_descriptionLabel = GetNode<RichTextLabel>("Description");
		_healthLabel = GetNode<Label>("Health");
	}

	public void Init(CardStaticData cardData)
	{
		_data = cardData;

		_nameLabel.Text = cardData.Name;
		_costLabel.Text = cardData.Cost.ToString();
		_powerLabel.Text = cardData.Power.ToString();
		_costLabel.Text = cardData.Cost.ToString();
		_descriptionLabel.Text = cardData.Description;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
