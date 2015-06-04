using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Audio/Set Volume")]
[UnitFriendlyName("Audio.Set Volume")]
[UnitUsage(typeof(System.Single))]
public class JLAudioSourceSetVolume : JLExpression
{
    [Parameter(ExpressionType = typeof(AudioSource))]
    public JLExpression OperandValue;

    [Parameter(ExpressionType = typeof(System.Single))]
    public JLExpression Value;

    public override object GetAnyResult(IExecutionContext context)
    {
        AudioSource opValue = OperandValue.GetResult<AudioSource>(context);
        return opValue.volume = Value.GetResult<System.Single>(context);
    }
}
