
public class BookRepository(LibraryDBContext context) : IBookRepository
{
    public bool CreateBook(BookCreateDTO bookCreateDTO)
    {
        if(bookCreateDTO.Name=="" && bookCreateDTO.Title=="") throw new BadRequestException("Bad request", 400);
        bool isExisted = context.Books.Any(x=>x.IsDeleted==false &&x.Title==bookCreateDTO.Title && x.Name==bookCreateDTO.Name);
        if(isExisted) throw new AlreadyExistException("Allready exist", 409);
        context.Books.Add(bookCreateDTO.BookCreateToBook());
        context.SaveChanges();
        return true;
    }

    public bool DeleteBook(int id)
    {
        if(id<=0) throw new BadRequestException("Bad request", 400);
        Book? book = context.Books.FirstOrDefault(x=>x.IsDeleted==false && x.Id==id);
        if(book==null) throw new NotFoundException("Not Found", 404);
        context.Books.Remove(book);
        context.SaveChanges();
        return true;
    }

    public BookReadDTO? GetBookById(int id)
    {
        if(id<=0) throw new BadRequestException("Bad request", 400);
        Book? book = context.Books.FirstOrDefault(x=>x.IsDeleted==false && x.Id==id);
        if(book==null) throw new NotFoundException("Not Found", 404);
        return book.BookToBookRead();
    }

    public IEnumerable<BookReadDTO> GetBooks()
    {
        return context.Books.Select(x=>x.BookToBookRead());
    }

    public bool UpdateBook(BookUpdateDTO bookUpdateDTO)
    {
        if(bookUpdateDTO==null) throw new BadRequestException("Bad request", 400);
        Book? book = context.Books.FirstOrDefault(x=>x.IsDeleted==false && x.Id==bookUpdateDTO.Id);
        if(book==null) throw new NotFoundException("Not Found", 404);
        book.UpdateBook(bookUpdateDTO);
        context.SaveChanges();
        return true;
    }
}