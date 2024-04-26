namespace Application.Features.BookIssues.Constants;

public static class BookIssuesOperationClaims
{
    private const string _section = "BookIssues";

    public const string Admin = $"{_section}.Admin";

    public const string Read = $"{_section}.Read";
    public const string Write = $"{_section}.Write";

    public const string Create = $"{_section}.Create";
    public const string Update = $"{_section}.Update";
    public const string Delete = $"{_section}.Delete";
}