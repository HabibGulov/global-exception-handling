public class BookCreateDTO
{
    public string Name { get; set; } = null!;
    public string Title { get; set; } = null!;
}

public class BookReadDTO
{
    public int Id{get; set;}
    public string Name { get; set; } = null!;
    public string Title { get; set; } = null!;
}

public class BookUpdateDTO:BookReadDTO
{

}