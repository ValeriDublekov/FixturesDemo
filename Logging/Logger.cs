using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace FixturesDemo.Logging;

public static class Logger
{
    public static void Log()
    {
        MethodBase? callingMethod = new StackTrace().GetFrame(1).GetMethod();
        Type type = callingMethod.DeclaringType;

        //if (type.GetCustomAttributes(typeof(CompilerGeneratedAttribute), false).Any())
        //{
        //    var originalMethod = type.DeclaringType.GetMethods()
        //        .FirstOrDefault(m => m.GetCustomAttributes(typeof(AsyncStateMachineAttribute), false)
        //            .Any(attr => ((AsyncStateMachineAttribute)attr).StateMachineType == type));

        //    if (originalMethod != null)
        //    {
        //        FileLogger.Log($"{originalMethod.DeclaringType.Name}.{originalMethod.Name}()");
        //        return;
        //    }
        //}

        // Handle overrides
        if (callingMethod is MethodInfo methodInfo)
        {
            while (methodInfo.GetBaseDefinition() != methodInfo)
            {
                methodInfo = methodInfo.GetBaseDefinition();
            }
            callingMethod = methodInfo;
        }

        if (callingMethod.IsConstructor)
        {
            FileLogger.Log($"{type.Name} Constructor");
        }
        else
        {
            var callingMethodName = callingMethod.Name;
            if (callingMethodName.Contains("MoveNext"))
            {
                callingMethodName = ParseAbstract(callingMethod.ReflectedType.Name);
            }
            FileLogger.Log($"{type.DeclaringType?.Name ?? type.Name}.{callingMethodName}()");
        }
    }

    private static readonly Regex AbstractMethodRegex = new (@".*<([^>]+)>.*");

    public static string ParseAbstract(string input)
    {
        var match = AbstractMethodRegex.Match(input);
        return match.Success ? match.Groups[1].Value : input;
    }
}