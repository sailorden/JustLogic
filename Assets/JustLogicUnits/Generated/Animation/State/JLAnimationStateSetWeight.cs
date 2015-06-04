using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animation/State/Set Weight")]
[UnitFriendlyName("AnimationState.Set Weight")]
[UnitUsage(typeof(System.Single))]
public class JLAnimationStateSetWeight : JLExpression
{
    [Parameter(ExpressionType = typeof(AnimationState))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        AnimationState opValue = OperandValue.GetResult<AnimationState>(context);
        return opValue.weight = Value.GetResult<System.Single>(context);
    }
}
