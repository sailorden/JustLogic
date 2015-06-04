using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Rect/Set Width")]
[UnitFriendlyName("Rect.Set Width")]
[UnitUsage(typeof(Rect))]
public class JLRectSetWidth : JLExpression
{
    [Parameter(ExpressionType = typeof(Rect))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        Rect opValue = OperandValue.GetResult<Rect>(context);
        opValue.width = Value.GetResult<System.Single>(context);
        return opValue;
    }
}
