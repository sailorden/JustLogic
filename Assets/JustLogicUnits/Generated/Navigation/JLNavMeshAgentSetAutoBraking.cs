using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Navigation/Agent/Set Auto Braking")]
[UnitFriendlyName("NavMeshAgent.Set Auto Braking")]
[UnitUsage(typeof(System.Boolean))]
public class JLNavMeshAgentSetAutoBraking : JLExpression
{
    [Parameter(ExpressionType = typeof(NavMeshAgent))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Boolean))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        NavMeshAgent opValue = OperandValue.GetResult<NavMeshAgent>(context);
        return opValue.autoBraking = Value.GetResult<System.Boolean>(context);
    }
}
