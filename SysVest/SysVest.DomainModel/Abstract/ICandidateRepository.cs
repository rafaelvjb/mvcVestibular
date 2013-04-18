using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVest.DomainModel.Entities;

namespace SysVest.DomainModel.Abstract
{
    public interface ICandidateRepository
    {
        IQueryable<Candidate> Candidates { get; }

        void RegistryIscription(Candidate candidate);

        void UpdateInscription(Candidate candidate);

        void Delete(int id);

        Candidate GetCandidateById(int id);

        IList<Candidate> GetAll();

        IList<Candidate> GetCandidatesByExamByCourse(int idExam, int idCourse);

    }
}
