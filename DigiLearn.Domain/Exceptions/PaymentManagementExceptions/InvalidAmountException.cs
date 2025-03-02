using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.PaymentManagementExceptions;

internal class InvalidAmountException : PaymentManagementException
{
    public InvalidAmountException() : base("Amount Can Not Be Negative...!")
    {
    }
}
