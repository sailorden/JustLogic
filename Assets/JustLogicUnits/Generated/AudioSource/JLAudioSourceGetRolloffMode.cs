using JustLogic.Core;
using System.Collections.Generic;
using UnityEngine;

[UnitMenu("Audio/Get Rolloff Mode")]
[UnitFriendlyName("Audio.Get Rolloff Mode")]
[UnitUsage(typeof(AudioRolloffMode), HideExpressionInActionsList = true)]
public class JLAudioSourceGetRolloffMode : JLExpression
{
    [Parameter(ExpressionType = typeof(AudioSource))]
    public JLExpression OperandValue;

    public override object GetAnyResult(IExecutionContext context)
    {
        AudioSource opValue = OperandValue.GetResult<AudioSource>(context);
        return opValue.rolloffMode;
    }
}
