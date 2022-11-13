namespace gRPC.Sender.Presentation.Services;

public class CalculatorService : Calculator.CalculatorBase
{
    public override Task<CalculateSumReply> Sum(CalculateSumRequest request, ServerCallContext context)
    {
        var sumResult = request.Number + request.Number2;

        return Task.FromResult(result: new CalculateSumReply()
        {
            Result = sumResult
        });
    }
}