# Damage Effect Controller

[中文](https://github.com/make-game-modules/damage-effect-controller/blob/main/README.zh-cn.md)

This project provides a Unity script to manage particle effects when a character is injured. When the character is injured, you can call the "TriggerDamageEffect" method to produce effects. When effects are not needed, you can call the "StopDamageEffect" method to stop the effects.

## How to Install

In your Unity project, clone this repository at any location using Git.

## How to Use

1. Attach the `DamageEffectController` script to the character object.
2. Call the `TriggerDamageEffect` method to start the effect when needed.
3. Call the `StopDamageEffect` method to stop the effect when it is no longer needed.

## Parameter Settings

- `damageEffect`: Reference to the particle system component of the damage effect.

## Operating Principle

This script provides two public methods `TriggerDamageEffect` and `StopDamageEffect`, which can start and stop the damage effect, respectively.

## Copyright Information

This project uses the MIT open source license. Everyone is welcome to improve and use the project.

## Others

If you have any questions or suggestions about this project, you are welcome to submit them to us through issue or pull request.
