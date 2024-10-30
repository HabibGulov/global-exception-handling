public interface IBookRepository
{
    IEnumerable<BookReadDTO> GetBooks();
    BookReadDTO? GetBookById(int id);
    bool CreateBook(BookCreateDTO bookCreateDTO);
    bool UpdateBook(BookUpdateDTO bookUpdateDTO);
    bool DeleteBook(int id);
}