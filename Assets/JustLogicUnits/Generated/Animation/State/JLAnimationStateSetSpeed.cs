using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animation/State/Set Speed")]
[UnitFriendlyName("AnimationState.Set Speed")]
[UnitUsage(typeof(System.Single))]
public class JLAnimationStateSetSpeed : JLExpression
{
    [Parameter(ExpressionType = typeof(AnimationState))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        AnimationState opValue = OperandValue.GetResult<AnimationState>(context);
        return opValue.speed = Value.GetResult<System.Single>(context);
    }
}
