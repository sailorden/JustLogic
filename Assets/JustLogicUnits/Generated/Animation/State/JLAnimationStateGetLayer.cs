using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animation/State/Get Layer")]
[UnitFriendlyName("AnimationState.Get Layer")]
[UnitUsage(typeof(System.Int32), HideExpressionInActionsList = true)]
public class JLAnimationStateGetLayer : JLExpression
{
    [Parameter(ExpressionType = typeof(AnimationState))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        AnimationState opValue = OperandValue.GetResult<AnimationState>(context);
        return opValue.layer;
    }
}
