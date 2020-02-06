using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command
{
    public Rigidbody player_rb;
    public float timestamp; // for logging purposes
    public abstract void Execute();
}

class MoveLeft : Command
{
    private float force_rb;

    public MoveLeft(Rigidbody player, float force)
    {
        player_rb = player;
        force_rb = force;
    }

    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        player_rb.AddForce(-force_rb * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}

class MoveRight : Command
{
    private float force_rb;

    public MoveRight(Rigidbody player, float force)
    {
        player_rb = player;
        force_rb = force;
    }

    public override void Execute()
    {
        timestamp = Time.timeSinceLevelLoad;
        player_rb.AddForce(force_rb * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}