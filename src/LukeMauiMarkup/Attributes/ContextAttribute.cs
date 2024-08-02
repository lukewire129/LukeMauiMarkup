using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukeMauiMarkup.Attributes;

[AttributeUsage (AttributeTargets.Class | AttributeTargets.Method)]
public class ContextAttribute : Attribute
{
    public Type TargetType { get; }

    public ContextAttribute(Type targetType)
    {
        TargetType = targetType;
    }
}
