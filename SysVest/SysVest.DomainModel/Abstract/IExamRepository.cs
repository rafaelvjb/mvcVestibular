using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVest.DomainModel.Entities;

namespace SysVest.DomainModel.Abstract
{
    public interface IExamRepository
    {
        IQueryable<Exam> Exams { get; }

        void Insert(Exam exam);

        void Update(Exam exam);

        void Delete(int id);

        Exam GetExamById(int id);

        IList<Candidate> GetCandidatesByExamId(int id);

        IList<Exam> GetAll();
    }
}
