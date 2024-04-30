namespace Business.Notes.Domain.Interfaces
{
    public interface INotesAdd<EntityNote>
    {
        EntityNote add(EntityNote entitynote);
    }
}
