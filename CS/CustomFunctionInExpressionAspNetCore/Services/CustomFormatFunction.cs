using DevExpress.XtraReports.Expressions;
using System;

namespace CustomFunctionInExpressionAspNetCore.Services
{
    public class CustomFormatFunction : ReportCustomFunctionOperatorBase
    {
        public override string FunctionCategory
            => "Custom";
        public override string Description
            => "CustomFormatFunction(string format, object arg0)" +
            "\r\nConverts an arg0 value to a string based on a specified format";
        public override bool IsValidOperandCount(int count)
            => count == 2;
        public override bool IsValidOperandType(int operandIndex, int operandCount, Type type)
            => true;
        public override int MaxOperandCount
            => 2;
        public override int MinOperandCount
            => 2;
        public override object Evaluate(params object[] operands)
        {
            string res = String.Format(operands[0].ToString(), operands[1]);
            return res;
        }
        public override string Name
            => "CustomFormatFunction";
        public override Type ResultType(params Type[] operands)
        {
            return typeof(string);
        }
    }
}
