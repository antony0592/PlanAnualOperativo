using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPolicial.Infraestructure.Data.Repositories
{
    public class ActividadRepository:BaseRepository<PAO_Actividad>,IActividadRepository
    {
    }
}
