using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animation/State/Set Layer")]
[UnitFriendlyName("AnimationState.Set Layer")]
[UnitUsage(typeof(System.Int32))]
public class JLAnimationStateSetLayer : JLExpression
{
    [Parameter(ExpressionType = typeof(AnimationState))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Int32))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        AnimationState opValue = OperandValue.GetResult<AnimationState>(context);
        return opValue.layer = Value.GetResult<System.Int32>(context);
    }
}
