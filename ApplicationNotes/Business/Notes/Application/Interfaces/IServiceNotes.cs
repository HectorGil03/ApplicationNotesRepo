using Business.Notes.Domain.Interfaces;
namespace Business.Notes.Application.Interfaces
{
    public interface IServiceNotes<EntityNote, EntityNoteId> : INotesAdd<EntityNote>, IModifyNote<EntityNote>, IDeleteNote<EntityNoteId>, IListNote<EntityNoteId, 
        >
    {

    }
}
