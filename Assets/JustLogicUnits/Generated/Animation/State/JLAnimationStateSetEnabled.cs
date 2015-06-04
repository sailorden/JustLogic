using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animation/State/Set Enabled")]
[UnitFriendlyName("AnimationState.Set Enabled")]
[UnitUsage(typeof(System.Boolean))]
public class JLAnimationStateSetEnabled : JLExpression
{
    [Parameter(ExpressionType = typeof(AnimationState))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Boolean))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        AnimationState opValue = OperandValue.GetResult<AnimationState>(context);
        return opValue.enabled = Value.GetResult<System.Boolean>(context);
    }
}
