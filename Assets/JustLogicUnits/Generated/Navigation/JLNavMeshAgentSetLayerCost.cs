using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Navigation/Agent/Set Layer Cost")]
[UnitFriendlyName("NavMeshAgent.Set Layer Cost")]
public class JLNavMeshAgentSetLayerCost : JLAction
{
    [Parameter(ExpressionType = typeof(NavMeshAgent))]
    public JLExpression OperandValue;

    [Parameter(OverrideType = ParameterAttribute.OverrideTypes.Layer)]
    public System.Int32 Layer;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Cost;

    protected override IEnumerator<YieldMode> OnExecute(IExecutionContext context)
    {
        NavMeshAgent opValue = OperandValue.GetResult<NavMeshAgent>(context);
        opValue.SetLayerCost(Layer, Cost.GetResult<System.Single>(context));
        return null;
    }
}
