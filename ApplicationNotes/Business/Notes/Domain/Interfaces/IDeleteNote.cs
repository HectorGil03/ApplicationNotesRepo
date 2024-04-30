namespace Business.Notes.Domain.Interfaces
{
    public interface IDeleteNote<EntityNote>
    {
        void Delete(EntityNote entityNote);
    }
}
