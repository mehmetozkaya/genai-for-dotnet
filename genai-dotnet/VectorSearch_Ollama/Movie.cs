using Microsoft.Extensions.VectorData;

namespace VectorSearch_Ollama;
public class Movie
{
    [VectorStoreKey]
    public int Key { get; set; }

    [VectorStoreData]
    public string Title { get; set; }

    [VectorStoreData]
    public string Description { get; set; }

    [VectorStoreVector(
        Dimensions: 384,
        DistanceFunction = DistanceFunction.CosineSimilarity)]
    public ReadOnlyMemory<float> Vector { get; set; }
}

public static class MovieData
{
    public static List<Movie> Movies =>
    [
        new Movie
        {
            Key=0,
            Title="Lion King",
            Description="The Lion King is a classic Disney animated film that tells the story of a young lion named Simba who embarks on a journey to reclaim his throne as the king of the Pride Lands after the tragic death of his father."
        },
        new Movie
        {
            Key=1,
            Title="Inception",
            Description="Inception is a science fiction film directed by Christopher Nolan that follows a group of thieves who enter the dreams of their targets to steal information."
        },
        new Movie
        {
            Key=2,
            Title="The Matrix",
            Description="The Matrix is a science fiction film directed by the Wachowskis that follows a computer hacker named Neo who discovers that the world he lives in is a simulated reality created by machines."
        },
        new Movie
        {
            Key=3,
            Title="Shrek",
            Description="Shrek is an animated film that tells the story of an ogre named Shrek who embarks on a quest to rescue Princess Fiona from a dragon and bring her back to the kingdom of Duloc."
        },
        new Movie
        {
            Key=4,
            Title="Interstellar",
            Description="A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival."
        }
    ];
}