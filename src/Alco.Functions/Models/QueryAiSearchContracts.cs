using System.Text.Json.Serialization;

namespace Alco.Functions.Models;

public sealed class QueryAiSearchRequest
{
    /// <summary>The natural language search query to find relevant document chunks.</summary>
    [JsonPropertyName("query")]
    public string Query { get; init; } = string.Empty;

    /// <summary>The case ID to scope the search to a specific case's documents.</summary>
    [JsonPropertyName("caseId")]
    public string CaseId { get; init; } = string.Empty;

    /// <summary>Maximum number of results to return. Defaults to 5, maximum 50.</summary>
    [JsonPropertyName("top")]
    public int? Top { get; init; }
}

public sealed class QueryAiSearchResponse
{
    /// <summary>The case ID used to filter the search.</summary>
    [JsonPropertyName("caseId")]
    public string CaseId { get; init; } = string.Empty;

    /// <summary>Number of results returned.</summary>
    [JsonPropertyName("count")]
    public int Count { get; init; }

    /// <summary>Total number of matching documents in the index.</summary>
    [JsonPropertyName("totalCount")]
    public long? TotalCount { get; init; }

    /// <summary>Matching document chunks with their case metadata.</summary>
    [JsonPropertyName("results")]
    public List<CaseSearchResult> Results { get; init; } = [];
}

public sealed class CaseSearchResult
{
    /// <summary>The text content of the document chunk.</summary>
    [JsonPropertyName("chunk")]
    public string Chunk { get; init; } = string.Empty;

    /// <summary>The document file name.</summary>
    [JsonPropertyName("title")]
    public string Title { get; init; } = string.Empty;

    /// <summary>The case ID this document belongs to.</summary>
    [JsonPropertyName("caseId")]
    public string CaseId { get; init; } = string.Empty;

    /// <summary>The blob storage file name of the source document.</summary>
    [JsonPropertyName("fileName")]
    public string FileName { get; init; } = string.Empty;
}
