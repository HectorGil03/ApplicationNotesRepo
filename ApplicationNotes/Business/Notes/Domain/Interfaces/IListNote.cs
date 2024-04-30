namespace Business.Notes.Domain.Interfaces
{
    public interface IListNote<EntityNote, EntityNoteId>
    {
        List<EntityNote> GetAll();

        EntityNote GetById(EntityNoteId entityNoteId);
    }
}
