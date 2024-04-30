namespace Business.Notes.Domain.Interfaces.Repositories
{
    public interface INoteRepository<EntityNote, EntityNoteId> : INotesAdd<EntityNote>, IModifyNote<EntityNote>, IDeleteNote<EntityNoteId>, IListNote<EntityNote, EntityNoteId>
    {

    }
}
