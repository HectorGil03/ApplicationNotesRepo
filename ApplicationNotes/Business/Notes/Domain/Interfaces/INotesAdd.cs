using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Notes.Domain.Interfaces
{
    public interface INotesAdd<EntityNote>
    {
        EntityNote add(EntityNote entitynote);
    }
}
