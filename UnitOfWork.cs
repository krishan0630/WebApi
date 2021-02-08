 
 





 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kians.EduxBee.Infrastructure.Repository
{
    using Kians.EduxBee.Core;
    using Kians.EduxBee.Core.Entity;
    using Kians.EduxBee.Infrastructure.Interfaces;
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;

        private EduxBeeEntities context;
      
                       private GenericRepository<AccountProfile> _accountProfileRepository;
             
                       private GenericRepository<AnnouncementClass> _announcementClassRepository;
             
                       private GenericRepository<AnnouncementFaculty> _announcementFacultyRepository;
             
                       private GenericRepository<Announcement> _announcementRepository;
             
                       private GenericRepository<Answer> _answerRepository;
             
                       private GenericRepository<Class> _classRepository;
             
                       private GenericRepository<ClassIntake> _classIntakeRepository;
             
                       private GenericRepository<Config> _configRepository;
             
                       private GenericRepository<Degree> _degreeRepository;
             
                       private GenericRepository<DegreeType> _degreeTypeRepository;
             
                       private GenericRepository<EmailQueue> _emailQueueRepository;
             
                       private GenericRepository<ExamClassIntake> _examClassIntakeRepository;
             
                       private GenericRepository<ExamFacultyIntake> _examFacultyIntakeRepository;
             
                       private GenericRepository<Exam> _examRepository;
             
                       private GenericRepository<ExamStatusType> _examStatusTypeRepository;
             
                       private GenericRepository<ExamType> _examTypeRepository;
             
                       private GenericRepository<Faculty> _facultyRepository;
             
                       private GenericRepository<FacultyIntake> _facultyIntakeRepository;
             
                       private GenericRepository<ForgotPassword> _forgotPasswordRepository;
             
                       private GenericRepository<Grade> _gradeRepository;
             
                       private GenericRepository<Institute> _instituteRepository;
             
                       private GenericRepository<InstituteType> _instituteTypeRepository;
             
                       private GenericRepository<InstituteUser> _instituteUserRepository;
             
                       private GenericRepository<IntakeYear> _intakeYearRepository;
             
                       private GenericRepository<Invitation> _invitationRepository;
             
                       private GenericRepository<Lecturer> _lecturerRepository;
             
                       private GenericRepository<ProctoringType> _proctoringTypeRepository;
             
                       private GenericRepository<Question> _questionRepository;
             
                       private GenericRepository<QuestionType> _questionTypeRepository;
             
                       private GenericRepository<Role> _roleRepository;
             
                       private GenericRepository<StatusType> _statusTypeRepository;
             
                       private GenericRepository<StudentAnswer> _studentAnswerRepository;
             
                       private GenericRepository<StudentExam> _studentExamRepository;
             
                       private GenericRepository<Student> _studentRepository;
             
                       private GenericRepository<Subject> _subjectRepository;
             
                       private GenericRepository<SudentProctoring> _sudentProctoringRepository;
             
                       private GenericRepository<SystemUser> _systemUserRepository;
             
                       private GenericRepository<UserRole> _userRoleRepository;
             
                       private GenericRepository<UserStatusType> _userStatusTypeRepository;
             
                       private GenericRepository<Payment> _paymentRepository;
             
                       private GenericRepository<GradeMark> _gradeMarkRepository;
             
                       private GenericRepository<GradeMarksType> _gradeMarksTypeRepository;
             
                       private GenericRepository<Country> _countryRepository;
             
                          
             public EduxBeeEntities DbContext
             {
                    get
                    {
                        if (context == null)
                        {
                            context = new EduxBeeEntities();
                        }
                        return context;
                    }
             }

	    
                           
               public GenericRepository<AccountProfile> AccountProfileRepository
               {
                    get
                    {
                        if (_accountProfileRepository == null)
                        {
                           _accountProfileRepository = new GenericRepository<AccountProfile>(DbContext);
                        }
                        return _accountProfileRepository;
                    }
                }
             
                           
               public GenericRepository<AnnouncementClass> AnnouncementClassRepository
               {
                    get
                    {
                        if (_announcementClassRepository == null)
                        {
                           _announcementClassRepository = new GenericRepository<AnnouncementClass>(DbContext);
                        }
                        return _announcementClassRepository;
                    }
                }
             
                           
               public GenericRepository<AnnouncementFaculty> AnnouncementFacultyRepository
               {
                    get
                    {
                        if (_announcementFacultyRepository == null)
                        {
                           _announcementFacultyRepository = new GenericRepository<AnnouncementFaculty>(DbContext);
                        }
                        return _announcementFacultyRepository;
                    }
                }
             
                           
               public GenericRepository<Announcement> AnnouncementRepository
               {
                    get
                    {
                        if (_announcementRepository == null)
                        {
                           _announcementRepository = new GenericRepository<Announcement>(DbContext);
                        }
                        return _announcementRepository;
                    }
                }
             
                           
               public GenericRepository<Answer> AnswerRepository
               {
                    get
                    {
                        if (_answerRepository == null)
                        {
                           _answerRepository = new GenericRepository<Answer>(DbContext);
                        }
                        return _answerRepository;
                    }
                }
             
                           
               public GenericRepository<Class> ClassRepository
               {
                    get
                    {
                        if (_classRepository == null)
                        {
                           _classRepository = new GenericRepository<Class>(DbContext);
                        }
                        return _classRepository;
                    }
                }
             
                           
               public GenericRepository<ClassIntake> ClassIntakeRepository
               {
                    get
                    {
                        if (_classIntakeRepository == null)
                        {
                           _classIntakeRepository = new GenericRepository<ClassIntake>(DbContext);
                        }
                        return _classIntakeRepository;
                    }
                }
             
                           
               public GenericRepository<Config> ConfigRepository
               {
                    get
                    {
                        if (_configRepository == null)
                        {
                           _configRepository = new GenericRepository<Config>(DbContext);
                        }
                        return _configRepository;
                    }
                }
             
                           
               public GenericRepository<Degree> DegreeRepository
               {
                    get
                    {
                        if (_degreeRepository == null)
                        {
                           _degreeRepository = new GenericRepository<Degree>(DbContext);
                        }
                        return _degreeRepository;
                    }
                }
             
                           
               public GenericRepository<DegreeType> DegreeTypeRepository
               {
                    get
                    {
                        if (_degreeTypeRepository == null)
                        {
                           _degreeTypeRepository = new GenericRepository<DegreeType>(DbContext);
                        }
                        return _degreeTypeRepository;
                    }
                }
             
                           
               public GenericRepository<EmailQueue> EmailQueueRepository
               {
                    get
                    {
                        if (_emailQueueRepository == null)
                        {
                           _emailQueueRepository = new GenericRepository<EmailQueue>(DbContext);
                        }
                        return _emailQueueRepository;
                    }
                }
             
                           
               public GenericRepository<ExamClassIntake> ExamClassIntakeRepository
               {
                    get
                    {
                        if (_examClassIntakeRepository == null)
                        {
                           _examClassIntakeRepository = new GenericRepository<ExamClassIntake>(DbContext);
                        }
                        return _examClassIntakeRepository;
                    }
                }
             
                           
               public GenericRepository<ExamFacultyIntake> ExamFacultyIntakeRepository
               {
                    get
                    {
                        if (_examFacultyIntakeRepository == null)
                        {
                           _examFacultyIntakeRepository = new GenericRepository<ExamFacultyIntake>(DbContext);
                        }
                        return _examFacultyIntakeRepository;
                    }
                }
             
                           
               public GenericRepository<Exam> ExamRepository
               {
                    get
                    {
                        if (_examRepository == null)
                        {
                           _examRepository = new GenericRepository<Exam>(DbContext);
                        }
                        return _examRepository;
                    }
                }
             
                           
               public GenericRepository<ExamStatusType> ExamStatusTypeRepository
               {
                    get
                    {
                        if (_examStatusTypeRepository == null)
                        {
                           _examStatusTypeRepository = new GenericRepository<ExamStatusType>(DbContext);
                        }
                        return _examStatusTypeRepository;
                    }
                }
             
                           
               public GenericRepository<ExamType> ExamTypeRepository
               {
                    get
                    {
                        if (_examTypeRepository == null)
                        {
                           _examTypeRepository = new GenericRepository<ExamType>(DbContext);
                        }
                        return _examTypeRepository;
                    }
                }
             
                           
               public GenericRepository<Faculty> FacultyRepository
               {
                    get
                    {
                        if (_facultyRepository == null)
                        {
                           _facultyRepository = new GenericRepository<Faculty>(DbContext);
                        }
                        return _facultyRepository;
                    }
                }
             
                           
               public GenericRepository<FacultyIntake> FacultyIntakeRepository
               {
                    get
                    {
                        if (_facultyIntakeRepository == null)
                        {
                           _facultyIntakeRepository = new GenericRepository<FacultyIntake>(DbContext);
                        }
                        return _facultyIntakeRepository;
                    }
                }
             
                           
               public GenericRepository<ForgotPassword> ForgotPasswordRepository
               {
                    get
                    {
                        if (_forgotPasswordRepository == null)
                        {
                           _forgotPasswordRepository = new GenericRepository<ForgotPassword>(DbContext);
                        }
                        return _forgotPasswordRepository;
                    }
                }
             
                           
               public GenericRepository<Grade> GradeRepository
               {
                    get
                    {
                        if (_gradeRepository == null)
                        {
                           _gradeRepository = new GenericRepository<Grade>(DbContext);
                        }
                        return _gradeRepository;
                    }
                }
             
                           
               public GenericRepository<Institute> InstituteRepository
               {
                    get
                    {
                        if (_instituteRepository == null)
                        {
                           _instituteRepository = new GenericRepository<Institute>(DbContext);
                        }
                        return _instituteRepository;
                    }
                }
             
                           
               public GenericRepository<InstituteType> InstituteTypeRepository
               {
                    get
                    {
                        if (_instituteTypeRepository == null)
                        {
                           _instituteTypeRepository = new GenericRepository<InstituteType>(DbContext);
                        }
                        return _instituteTypeRepository;
                    }
                }
             
                           
               public GenericRepository<InstituteUser> InstituteUserRepository
               {
                    get
                    {
                        if (_instituteUserRepository == null)
                        {
                           _instituteUserRepository = new GenericRepository<InstituteUser>(DbContext);
                        }
                        return _instituteUserRepository;
                    }
                }
             
                           
               public GenericRepository<IntakeYear> IntakeYearRepository
               {
                    get
                    {
                        if (_intakeYearRepository == null)
                        {
                           _intakeYearRepository = new GenericRepository<IntakeYear>(DbContext);
                        }
                        return _intakeYearRepository;
                    }
                }
             
                           
               public GenericRepository<Invitation> InvitationRepository
               {
                    get
                    {
                        if (_invitationRepository == null)
                        {
                           _invitationRepository = new GenericRepository<Invitation>(DbContext);
                        }
                        return _invitationRepository;
                    }
                }
             
                           
               public GenericRepository<Lecturer> LecturerRepository
               {
                    get
                    {
                        if (_lecturerRepository == null)
                        {
                           _lecturerRepository = new GenericRepository<Lecturer>(DbContext);
                        }
                        return _lecturerRepository;
                    }
                }
             
                           
               public GenericRepository<ProctoringType> ProctoringTypeRepository
               {
                    get
                    {
                        if (_proctoringTypeRepository == null)
                        {
                           _proctoringTypeRepository = new GenericRepository<ProctoringType>(DbContext);
                        }
                        return _proctoringTypeRepository;
                    }
                }
             
                           
               public GenericRepository<Question> QuestionRepository
               {
                    get
                    {
                        if (_questionRepository == null)
                        {
                           _questionRepository = new GenericRepository<Question>(DbContext);
                        }
                        return _questionRepository;
                    }
                }
             
                           
               public GenericRepository<QuestionType> QuestionTypeRepository
               {
                    get
                    {
                        if (_questionTypeRepository == null)
                        {
                           _questionTypeRepository = new GenericRepository<QuestionType>(DbContext);
                        }
                        return _questionTypeRepository;
                    }
                }
             
                           
               public GenericRepository<Role> RoleRepository
               {
                    get
                    {
                        if (_roleRepository == null)
                        {
                           _roleRepository = new GenericRepository<Role>(DbContext);
                        }
                        return _roleRepository;
                    }
                }
             
                           
               public GenericRepository<StatusType> StatusTypeRepository
               {
                    get
                    {
                        if (_statusTypeRepository == null)
                        {
                           _statusTypeRepository = new GenericRepository<StatusType>(DbContext);
                        }
                        return _statusTypeRepository;
                    }
                }
             
                           
               public GenericRepository<StudentAnswer> StudentAnswerRepository
               {
                    get
                    {
                        if (_studentAnswerRepository == null)
                        {
                           _studentAnswerRepository = new GenericRepository<StudentAnswer>(DbContext);
                        }
                        return _studentAnswerRepository;
                    }
                }
             
                           
               public GenericRepository<StudentExam> StudentExamRepository
               {
                    get
                    {
                        if (_studentExamRepository == null)
                        {
                           _studentExamRepository = new GenericRepository<StudentExam>(DbContext);
                        }
                        return _studentExamRepository;
                    }
                }
             
                           
               public GenericRepository<Student> StudentRepository
               {
                    get
                    {
                        if (_studentRepository == null)
                        {
                           _studentRepository = new GenericRepository<Student>(DbContext);
                        }
                        return _studentRepository;
                    }
                }
             
                           
               public GenericRepository<Subject> SubjectRepository
               {
                    get
                    {
                        if (_subjectRepository == null)
                        {
                           _subjectRepository = new GenericRepository<Subject>(DbContext);
                        }
                        return _subjectRepository;
                    }
                }
             
                           
               public GenericRepository<SudentProctoring> SudentProctoringRepository
               {
                    get
                    {
                        if (_sudentProctoringRepository == null)
                        {
                           _sudentProctoringRepository = new GenericRepository<SudentProctoring>(DbContext);
                        }
                        return _sudentProctoringRepository;
                    }
                }
             
                           
               public GenericRepository<SystemUser> SystemUserRepository
               {
                    get
                    {
                        if (_systemUserRepository == null)
                        {
                           _systemUserRepository = new GenericRepository<SystemUser>(DbContext);
                        }
                        return _systemUserRepository;
                    }
                }
             
                           
               public GenericRepository<UserRole> UserRoleRepository
               {
                    get
                    {
                        if (_userRoleRepository == null)
                        {
                           _userRoleRepository = new GenericRepository<UserRole>(DbContext);
                        }
                        return _userRoleRepository;
                    }
                }
             
                           
               public GenericRepository<UserStatusType> UserStatusTypeRepository
               {
                    get
                    {
                        if (_userStatusTypeRepository == null)
                        {
                           _userStatusTypeRepository = new GenericRepository<UserStatusType>(DbContext);
                        }
                        return _userStatusTypeRepository;
                    }
                }
             
                           
               public GenericRepository<Payment> PaymentRepository
               {
                    get
                    {
                        if (_paymentRepository == null)
                        {
                           _paymentRepository = new GenericRepository<Payment>(DbContext);
                        }
                        return _paymentRepository;
                    }
                }
             
                           
               public GenericRepository<GradeMark> GradeMarkRepository
               {
                    get
                    {
                        if (_gradeMarkRepository == null)
                        {
                           _gradeMarkRepository = new GenericRepository<GradeMark>(DbContext);
                        }
                        return _gradeMarkRepository;
                    }
                }
             
                           
               public GenericRepository<GradeMarksType> GradeMarksTypeRepository
               {
                    get
                    {
                        if (_gradeMarksTypeRepository == null)
                        {
                           _gradeMarksTypeRepository = new GenericRepository<GradeMarksType>(DbContext);
                        }
                        return _gradeMarksTypeRepository;
                    }
                }
             
                           
               public GenericRepository<Country> CountryRepository
               {
                    get
                    {
                        if (_countryRepository == null)
                        {
                           _countryRepository = new GenericRepository<Country>(DbContext);
                        }
                        return _countryRepository;
                    }
                }
             
                  
        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
