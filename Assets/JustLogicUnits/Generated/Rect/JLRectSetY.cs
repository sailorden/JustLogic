using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Rect/Set Y")]
[UnitFriendlyName("Rect.Set Y")]
[UnitUsage(typeof(Rect))]
public class JLRectSetY : JLExpression
{
    [Parameter(ExpressionType = typeof(Rect))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        Rect opValue = OperandValue.GetResult<Rect>(context);
        opValue.y = Value.GetResult<System.Single>(context);
        return opValue;
    }
}
