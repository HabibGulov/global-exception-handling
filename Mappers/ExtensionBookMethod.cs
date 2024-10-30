public static class ExtensionBookMethod
{
    public static Book BookCreateToBook(this BookCreateDTO bookCreateDTO)
    {
        return new Book()
        {
            Name = bookCreateDTO.Name,
            Title = bookCreateDTO.Title
        };
    }

    public static BookReadDTO BookToBookRead(this Book book)
    {
        return new BookReadDTO()
        {
            Id = book.Id,
            Name = book.Name,
            Title = book.Title
        };
    }

    public static Book DeleteBook(this Book book)
    {
        book.DeletedAt = DateTime.UtcNow;
        book.IsDeleted = true;
        book.UpdatedAt = DateTime.UtcNow;
        book.Version += 1;
        return book;
    }

    public static Book UpdateBook(this Book book, BookUpdateDTO bookUpdateDTO)
    {
        book.Title = bookUpdateDTO.Title;
        book.Name = bookUpdateDTO.Name;
        book.Version += 1;
        book.UpdatedAt = DateTime.UtcNow;
        return book;
    }
}