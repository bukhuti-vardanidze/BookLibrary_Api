namespace BookLibrary.Requests;

public class RenameShelfRequest
{
    public int ShelfId { get; set; }
    public string NewName { get; set; }
}