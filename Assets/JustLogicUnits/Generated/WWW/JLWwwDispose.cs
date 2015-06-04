using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("WWW/Dispose")]
[UnitFriendlyName("WWW.Dispose")]
public class JLWwwDispose : JLAction
{
    [Parameter(ExpressionType = typeof(WWW))]
    public JLExpression OperandValue;

    protected override IEnumerator<YieldMode> OnExecute(IExecutionContext context)
    {
        WWW opValue = OperandValue.GetResult<WWW>(context);
        opValue.Dispose();
        return null;
    }
}
