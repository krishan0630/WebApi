
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kians.EduxBee.Infrastructure.Interfaces
{
    using Kians.EduxBee.Core;
    using Kians.EduxBee.Core.Entity;
    using Kians.EduxBee.Infrastructure.Interfaces;
    using Kians.EduxBee.Infrastructure.Repository;

    public interface IUnitOfWork : IDisposable
    {
        
        EduxBeeEntities DbContext { get; }
        void Save();
                   GenericRepository<AccountProfile> AccountProfileRepository { get; }
             
                   GenericRepository<AnnouncementClass> AnnouncementClassRepository { get; }
             
                   GenericRepository<AnnouncementFaculty> AnnouncementFacultyRepository { get; }
             
                   GenericRepository<Announcement> AnnouncementRepository { get; }
             
                   GenericRepository<Answer> AnswerRepository { get; }
             
                   GenericRepository<Class> ClassRepository { get; }
             
                   GenericRepository<ClassIntake> ClassIntakeRepository { get; }
             
                   GenericRepository<Config> ConfigRepository { get; }
             
                   GenericRepository<Degree> DegreeRepository { get; }
             
                   GenericRepository<DegreeType> DegreeTypeRepository { get; }
             
                   GenericRepository<EmailQueue> EmailQueueRepository { get; }
             
                   GenericRepository<ExamClassIntake> ExamClassIntakeRepository { get; }
             
                   GenericRepository<ExamFacultyIntake> ExamFacultyIntakeRepository { get; }
             
                   GenericRepository<Exam> ExamRepository { get; }
             
                   GenericRepository<ExamStatusType> ExamStatusTypeRepository { get; }
             
                   GenericRepository<ExamType> ExamTypeRepository { get; }
             
                   GenericRepository<Faculty> FacultyRepository { get; }
             
                   GenericRepository<FacultyIntake> FacultyIntakeRepository { get; }
             
                   GenericRepository<ForgotPassword> ForgotPasswordRepository { get; }
             
                   GenericRepository<Grade> GradeRepository { get; }
             
                   GenericRepository<Institute> InstituteRepository { get; }
             
                   GenericRepository<InstituteType> InstituteTypeRepository { get; }
             
                   GenericRepository<InstituteUser> InstituteUserRepository { get; }
             
                   GenericRepository<IntakeYear> IntakeYearRepository { get; }
             
                   GenericRepository<Invitation> InvitationRepository { get; }
             
                   GenericRepository<Lecturer> LecturerRepository { get; }
             
                   GenericRepository<ProctoringType> ProctoringTypeRepository { get; }
             
                   GenericRepository<Question> QuestionRepository { get; }
             
                   GenericRepository<QuestionType> QuestionTypeRepository { get; }
             
                   GenericRepository<Role> RoleRepository { get; }
             
                   GenericRepository<StatusType> StatusTypeRepository { get; }
             
                   GenericRepository<StudentAnswer> StudentAnswerRepository { get; }
             
                   GenericRepository<StudentExam> StudentExamRepository { get; }
             
                   GenericRepository<Student> StudentRepository { get; }
             
                   GenericRepository<Subject> SubjectRepository { get; }
             
                   GenericRepository<SudentProctoring> SudentProctoringRepository { get; }
             
                   GenericRepository<SystemUser> SystemUserRepository { get; }
             
                   GenericRepository<UserRole> UserRoleRepository { get; }
             
                   GenericRepository<UserStatusType> UserStatusTypeRepository { get; }
             
                   GenericRepository<Payment> PaymentRepository { get; }
             
                   GenericRepository<GradeMark> GradeMarkRepository { get; }
             
                   GenericRepository<GradeMarksType> GradeMarksTypeRepository { get; }
             
                   GenericRepository<Country> CountryRepository { get; }
             
                          
            
    }
}
