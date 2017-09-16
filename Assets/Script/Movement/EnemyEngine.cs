using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyEngine : Construct_car
{
    private void FixedUpdate()
    {
        Drive();
    }

    private void Drive()
    {
		if (CountDown.frenzyTime == true) {
			frontWheel.useMotor = false;
			backWheel.useMotor = false;
		} else {
			frontWheel.useMotor = true;
			backWheel.useMotor = true;
			JointMotor2D enemyMotor = new JointMotor2D { motorSpeed = -speed, maxMotorTorque = 10000 };
			frontWheel.motor = enemyMotor;
			backWheel.motor = enemyMotor;
		}
    }

    public override void Braking()
    {
        if (isBraking)
        {
			frontWheel.useMotor = false;
			backWheel.useMotor = false;
            backWheel.breakTorque = BreakTrorque;
        }
    }
}