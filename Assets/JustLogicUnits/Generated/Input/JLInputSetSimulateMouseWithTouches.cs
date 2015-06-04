using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Input/Set Simulate Mouse With Touches")]
[UnitFriendlyName("Set Simulate Mouse With Touches")]
[UnitUsage(typeof(System.Boolean))]
public class JLInputSetSimulateMouseWithTouches : JLExpression
{
    [Parameter(ExpressionType = typeof(System.Boolean))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        return Input.simulateMouseWithTouches = Value.GetResult<System.Boolean>(context);
    }
}
