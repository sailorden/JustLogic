using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Animator/Get Layer Weight")]
[UnitFriendlyName("Animator.Get Layer Weight")]
[UnitUsage(typeof(System.Single), HideExpressionInActionsList = true)]
public class JLAnimatorGetLayerWeight : JLExpression
{
    [Parameter(ExpressionType = typeof(Animator))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Int32))]
    public JLExpression LayerIndex;

    public override object GetAnyResult(IExecutionContext context)
    {
        Animator opValue = OperandValue.GetResult<Animator>(context);
        return opValue.GetLayerWeight(LayerIndex.GetResult<System.Int32>(context));
    }
}
