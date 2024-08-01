
namespace PublicWebApp
{
    public enum ErrorCodes
    {
        NOT_FOUND = 1,
        COULD_NOT_STORE_DATA =2,
        INVALID_PERSON = 3,
        MISSING_REQUIRED_INFORMATION = 4,
        INVALID_EMAIL = 5,
        CUSTOMER_NOT_FOUND = 6,
    }

    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ErrorCodes ErrorCodes { get; set; }
    }

    public class CustomerResponse : Response
    {
        public CustomerDTO Data;
    }
}
