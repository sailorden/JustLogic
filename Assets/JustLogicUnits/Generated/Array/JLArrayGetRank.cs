using JustLogic.Core;
using System.Collections.Generic;
using System;

[UnitMenu("Array/Get Rank")]
[UnitFriendlyName("Array.Get Rank")]
[UnitUsage(typeof(Int32), HideExpressionInActionsList = true)]
public class JLArrayGetRank : JLExpression
{
    [Parameter(ExpressionType = typeof(Array))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        Array opValue = OperandValue.GetResult<Array>(context);
        return opValue.Rank;
    }
}
