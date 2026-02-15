extends Node

@export var receiver: Receiver

# Called when the node enters the scene tree for the first time.
func _ready() -> void:
	print("Hello Friend")
	if receiver:
		receiver.OnCalled()
