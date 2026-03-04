using System;

/// <summary>
/// Represents the rating scale for dogs
/// </summary>
enum Rating
{
    /// <summary>
    /// Represents a good rating
    /// </summary>
    Good,
    /// <summary>
    /// Represents a great rating
    /// </summary>
    Great,
    /// <summary>
    /// Represents an excellent rating
    /// </summary>
    Excellent
}

/// <summary>
/// Represents a dog with its basic information and rating
/// </summary>
struct Dog
{
    /// <summary>
    /// The name of the dog
    /// </summary>
    public string name;
    /// <summary>
    /// The age of the dog in years
    /// </summary>
    public float age;
    /// <summary>
    /// The owner of the dog
    /// </summary>
    public string owner;
    /// <summary>
    /// The rating of the dog
    /// </summary>
    public Rating rating;
}