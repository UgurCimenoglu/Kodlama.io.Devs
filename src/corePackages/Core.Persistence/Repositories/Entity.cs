namespace Core.Persistence.Repositories;

public class Entity
{
    public int Id { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string CreatedBy { get; set; }
    public string? UpdatedBy { get; set; }

    public Entity()
    {
    }
    public Entity(int id) : this()
    {
        Id = id;
    }


    public Entity(int id, DateTime createdDate, DateTime updatedDate, string createdBy, string updatedBy) : this(id: id)
    {

        CreateDate = createdDate;
        UpdatedDate = updatedDate;
        CreatedBy = createdBy;
        UpdatedBy = updatedBy;
    }
}