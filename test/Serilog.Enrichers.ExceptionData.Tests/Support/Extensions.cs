using Serilog.Events;

namespace Serilog.Tests.Support
{
    public static class Extensions
    {
        public static object LiteralValue(this LogEventPropertyValue @this) =>
            ((ScalarValue) @this).Value;
    }
}
