using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Vectors/Operations/Multiply (Vector3)")]
[UnitFriendlyName("Op Multiply")]
[UnitUsage(typeof(Vector3), HideExpressionInActionsList = true)]
public class JLVector3OpMultiply : JLExpression
{
    [Parameter(ExpressionType = typeof(Vector3))]
    public JLExpression A;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression D;

    public override object GetAnyResult(IExecutionContext context)
    {
        return A.GetResult<Vector3>(context) * D.GetResult<System.Single>(context);
    }
}
