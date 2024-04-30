using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Notes.Domain.Interfaces
{
    public interface IListNote<EntityNote, EntityNoteId>
    {
        List<EntityNote> GetAll();

        EntityNote GetById(EntityNoteId entityNoteId);
    }
}
