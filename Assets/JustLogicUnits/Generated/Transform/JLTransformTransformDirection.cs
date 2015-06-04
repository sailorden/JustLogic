using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Transform/Transform Direction")]
[UnitFriendlyName("Transform Direction")]
[UnitUsage(typeof(Vector3), HideExpressionInActionsList = true)]
public class JLTransformTransformDirection : JLExpression
{
    [Parameter(ExpressionType = typeof(Transform))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(Vector3))]
    public JLExpression Direction;

    public override object GetAnyResult(IExecutionContext context)
    {
        Transform opValue = OperandValue.GetResult<Transform>(context);
        return opValue.TransformDirection(Direction.GetResult<Vector3>(context));
    }
}
