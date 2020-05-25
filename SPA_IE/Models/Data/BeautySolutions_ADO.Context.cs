﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPA_IE.Models.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IF4101_BeatySolutions_ISem_2020Entities1 : DbContext
    {
        public IF4101_BeatySolutions_ISem_2020Entities1()
            : base("name=IF4101_BeatySolutions_ISem_2020Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Canton> Canton { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Consultation> Consultation { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
    
        public virtual int DeleteCourse(Nullable<int> idCourse)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCourse", idCourseParameter);
        }
    
        public virtual int DeleteProfessor(Nullable<int> idUserProfile)
        {
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteProfessor", idUserProfileParameter);
        }
    
        public virtual int DeleteStudent(Nullable<int> idUserProfile)
        {
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStudent", idUserProfileParameter);
        }
    
        public virtual ObjectResult<GetByIdCourse_Result1> GetByIdCourse(Nullable<int> idCourse)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdCourse_Result1>("GetByIdCourse", idCourseParameter);
        }
    
        public virtual int InsertUpdateProfessor(Nullable<int> idProfessor, string degree, Nullable<int> idUserProfile, Nullable<int> createBy, Nullable<System.DateTime> creationDate, string username, string password, string userPhoto, string interest, string email, Nullable<bool> isAdmin, Nullable<bool> isEnable, Nullable<int> idProvince, Nullable<int> idCanton, Nullable<int> idDistrict, string action)
        {
            var idProfessorParameter = idProfessor.HasValue ?
                new ObjectParameter("IdProfessor", idProfessor) :
                new ObjectParameter("IdProfessor", typeof(int));
    
            var degreeParameter = degree != null ?
                new ObjectParameter("Degree", degree) :
                new ObjectParameter("Degree", typeof(string));
    
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            var createByParameter = createBy.HasValue ?
                new ObjectParameter("CreateBy", createBy) :
                new ObjectParameter("CreateBy", typeof(int));
    
            var creationDateParameter = creationDate.HasValue ?
                new ObjectParameter("CreationDate", creationDate) :
                new ObjectParameter("CreationDate", typeof(System.DateTime));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var userPhotoParameter = userPhoto != null ?
                new ObjectParameter("UserPhoto", userPhoto) :
                new ObjectParameter("UserPhoto", typeof(string));
    
            var interestParameter = interest != null ?
                new ObjectParameter("Interest", interest) :
                new ObjectParameter("Interest", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var isAdminParameter = isAdmin.HasValue ?
                new ObjectParameter("IsAdmin", isAdmin) :
                new ObjectParameter("IsAdmin", typeof(bool));
    
            var isEnableParameter = isEnable.HasValue ?
                new ObjectParameter("IsEnable", isEnable) :
                new ObjectParameter("IsEnable", typeof(bool));
    
            var idProvinceParameter = idProvince.HasValue ?
                new ObjectParameter("IdProvince", idProvince) :
                new ObjectParameter("IdProvince", typeof(int));
    
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("IdCanton", idCanton) :
                new ObjectParameter("IdCanton", typeof(int));
    
            var idDistrictParameter = idDistrict.HasValue ?
                new ObjectParameter("IdDistrict", idDistrict) :
                new ObjectParameter("IdDistrict", typeof(int));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateProfessor", idProfessorParameter, degreeParameter, idUserProfileParameter, createByParameter, creationDateParameter, usernameParameter, passwordParameter, userPhotoParameter, interestParameter, emailParameter, isAdminParameter, isEnableParameter, idProvinceParameter, idCantonParameter, idDistrictParameter, actionParameter);
        }
    
        public virtual int InsertUpdateStudent(Nullable<int> idStudent, string identificationCard, Nullable<int> idUserProfile, Nullable<bool> isASIP, Nullable<bool> isActive, Nullable<int> createBy, Nullable<System.DateTime> creationDate, string username, string password, string userPhoto, string interest, string email, Nullable<bool> isAdmin, Nullable<bool> isEnable, Nullable<int> idProvince, Nullable<int> idCanton, Nullable<int> idDistrict, string action)
        {
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("IdStudent", idStudent) :
                new ObjectParameter("IdStudent", typeof(int));
    
            var identificationCardParameter = identificationCard != null ?
                new ObjectParameter("IdentificationCard", identificationCard) :
                new ObjectParameter("IdentificationCard", typeof(string));
    
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            var isASIPParameter = isASIP.HasValue ?
                new ObjectParameter("IsASIP", isASIP) :
                new ObjectParameter("IsASIP", typeof(bool));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createByParameter = createBy.HasValue ?
                new ObjectParameter("CreateBy", createBy) :
                new ObjectParameter("CreateBy", typeof(int));
    
            var creationDateParameter = creationDate.HasValue ?
                new ObjectParameter("CreationDate", creationDate) :
                new ObjectParameter("CreationDate", typeof(System.DateTime));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var userPhotoParameter = userPhoto != null ?
                new ObjectParameter("UserPhoto", userPhoto) :
                new ObjectParameter("UserPhoto", typeof(string));
    
            var interestParameter = interest != null ?
                new ObjectParameter("Interest", interest) :
                new ObjectParameter("Interest", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var isAdminParameter = isAdmin.HasValue ?
                new ObjectParameter("IsAdmin", isAdmin) :
                new ObjectParameter("IsAdmin", typeof(bool));
    
            var isEnableParameter = isEnable.HasValue ?
                new ObjectParameter("IsEnable", isEnable) :
                new ObjectParameter("IsEnable", typeof(bool));
    
            var idProvinceParameter = idProvince.HasValue ?
                new ObjectParameter("IdProvince", idProvince) :
                new ObjectParameter("IdProvince", typeof(int));
    
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("IdCanton", idCanton) :
                new ObjectParameter("IdCanton", typeof(int));
    
            var idDistrictParameter = idDistrict.HasValue ?
                new ObjectParameter("IdDistrict", idDistrict) :
                new ObjectParameter("IdDistrict", typeof(int));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateStudent", idStudentParameter, identificationCardParameter, idUserProfileParameter, isASIPParameter, isActiveParameter, createByParameter, creationDateParameter, usernameParameter, passwordParameter, userPhotoParameter, interestParameter, emailParameter, isAdminParameter, isEnableParameter, idProvinceParameter, idCantonParameter, idDistrictParameter, actionParameter);
        }
    
        public virtual ObjectResult<SelectCourse_Result1> SelectCourse()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectCourse_Result1>("SelectCourse");
        }
    
        public virtual ObjectResult<SelectProfessor_Result> SelectProfessor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectProfessor_Result>("SelectProfessor");
        }
    
        public virtual ObjectResult<SelectProfessorById_Result> SelectProfessorById(Nullable<int> idUserProfile)
        {
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectProfessorById_Result>("SelectProfessorById", idUserProfileParameter);
        }
    
        public virtual ObjectResult<SelectStudent_Result> SelectStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectStudent_Result>("SelectStudent");
        }
    
        public virtual ObjectResult<SelectStudentById_Result> SelectStudentById(Nullable<int> idUserProfile)
        {
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectStudentById_Result>("SelectStudentById", idUserProfileParameter);
        }
    
        public virtual int SPDeleteCourse(Nullable<int> idCourse)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPDeleteCourse", idCourseParameter);
        }
    
        public virtual int InsertUpdateCourse(Nullable<int> idCourse, string name, Nullable<bool> state, string semestrer, string description, string image, string action)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var stateParameter = state.HasValue ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(bool));
    
            var semestrerParameter = semestrer != null ?
                new ObjectParameter("Semestrer", semestrer) :
                new ObjectParameter("Semestrer", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateCourse", idCourseParameter, nameParameter, stateParameter, semestrerParameter, descriptionParameter, imageParameter, actionParameter);
        }
    
        public virtual int SPInsertUpdateCourse(Nullable<int> idCourse, string name, Nullable<bool> state, string semestrer, string description, string image, string action)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var stateParameter = state.HasValue ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(bool));
    
            var semestrerParameter = semestrer != null ?
                new ObjectParameter("Semestrer", semestrer) :
                new ObjectParameter("Semestrer", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("Image", image) :
                new ObjectParameter("Image", typeof(string));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPInsertUpdateCourse", idCourseParameter, nameParameter, stateParameter, semestrerParameter, descriptionParameter, imageParameter, actionParameter);
        }
    
        public virtual int SPDeleteStudent(Nullable<int> idUserProfile)
        {
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPDeleteStudent", idUserProfileParameter);
        }
    
        public virtual int SPInsertUpdateStudent(Nullable<int> idStudent, string identificationCard, Nullable<int> idUserProfile, Nullable<bool> isASIP, Nullable<bool> isActive, Nullable<int> createBy, Nullable<System.DateTime> creationDate, string username, string password, string userPhoto, string interest, string email, Nullable<bool> isAdmin, Nullable<bool> isEnable, Nullable<int> idProvince, Nullable<int> idCanton, Nullable<int> idDistrict, string action)
        {
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("IdStudent", idStudent) :
                new ObjectParameter("IdStudent", typeof(int));
    
            var identificationCardParameter = identificationCard != null ?
                new ObjectParameter("IdentificationCard", identificationCard) :
                new ObjectParameter("IdentificationCard", typeof(string));
    
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            var isASIPParameter = isASIP.HasValue ?
                new ObjectParameter("IsASIP", isASIP) :
                new ObjectParameter("IsASIP", typeof(bool));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var createByParameter = createBy.HasValue ?
                new ObjectParameter("CreateBy", createBy) :
                new ObjectParameter("CreateBy", typeof(int));
    
            var creationDateParameter = creationDate.HasValue ?
                new ObjectParameter("CreationDate", creationDate) :
                new ObjectParameter("CreationDate", typeof(System.DateTime));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var userPhotoParameter = userPhoto != null ?
                new ObjectParameter("UserPhoto", userPhoto) :
                new ObjectParameter("UserPhoto", typeof(string));
    
            var interestParameter = interest != null ?
                new ObjectParameter("Interest", interest) :
                new ObjectParameter("Interest", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var isAdminParameter = isAdmin.HasValue ?
                new ObjectParameter("IsAdmin", isAdmin) :
                new ObjectParameter("IsAdmin", typeof(bool));
    
            var isEnableParameter = isEnable.HasValue ?
                new ObjectParameter("IsEnable", isEnable) :
                new ObjectParameter("IsEnable", typeof(bool));
    
            var idProvinceParameter = idProvince.HasValue ?
                new ObjectParameter("IdProvince", idProvince) :
                new ObjectParameter("IdProvince", typeof(int));
    
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("IdCanton", idCanton) :
                new ObjectParameter("IdCanton", typeof(int));
    
            var idDistrictParameter = idDistrict.HasValue ?
                new ObjectParameter("IdDistrict", idDistrict) :
                new ObjectParameter("IdDistrict", typeof(int));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPInsertUpdateStudent", idStudentParameter, identificationCardParameter, idUserProfileParameter, isASIPParameter, isActiveParameter, createByParameter, creationDateParameter, usernameParameter, passwordParameter, userPhotoParameter, interestParameter, emailParameter, isAdminParameter, isEnableParameter, idProvinceParameter, idCantonParameter, idDistrictParameter, actionParameter);
        }
    
        public virtual ObjectResult<SelectStudent_Result> SPSelectStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectStudent_Result>("SPSelectStudent");
        }
    
        public virtual ObjectResult<SelectStudentById_Result> SPSelectStudentById(Nullable<int> idUserProfile)
        {
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectStudentById_Result>("SPSelectStudentById", idUserProfileParameter);
        }
    
        public virtual ObjectResult<Course> SPSelectCourse()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("SPSelectCourse");
        }
    
        public virtual ObjectResult<Course> SPSelectCourse(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("SPSelectCourse", mergeOption);
        }
    
        public virtual ObjectResult<Course> SPGetByIdCourse(Nullable<int> idCourse)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("SPGetByIdCourse", idCourseParameter);
        }
    
        public virtual ObjectResult<Course> SPGetByIdCourse(Nullable<int> idCourse, MergeOption mergeOption)
        {
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("SPGetByIdCourse", mergeOption, idCourseParameter);
        }
    
        public virtual int SPDeleteProfessor(Nullable<int> idUserProfile)
        {
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPDeleteProfessor", idUserProfileParameter);
        }
    
        public virtual int SPInsertUpdateProfessor(Nullable<int> idProfessor, string degree, Nullable<int> idUserProfile, Nullable<int> createBy, Nullable<System.DateTime> creationDate, string username, string password, string userPhoto, string interest, string email, Nullable<bool> isAdmin, Nullable<bool> isEnable, Nullable<int> idProvince, Nullable<int> idCanton, Nullable<int> idDistrict, string action)
        {
            var idProfessorParameter = idProfessor.HasValue ?
                new ObjectParameter("IdProfessor", idProfessor) :
                new ObjectParameter("IdProfessor", typeof(int));
    
            var degreeParameter = degree != null ?
                new ObjectParameter("Degree", degree) :
                new ObjectParameter("Degree", typeof(string));
    
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            var createByParameter = createBy.HasValue ?
                new ObjectParameter("CreateBy", createBy) :
                new ObjectParameter("CreateBy", typeof(int));
    
            var creationDateParameter = creationDate.HasValue ?
                new ObjectParameter("CreationDate", creationDate) :
                new ObjectParameter("CreationDate", typeof(System.DateTime));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var userPhotoParameter = userPhoto != null ?
                new ObjectParameter("UserPhoto", userPhoto) :
                new ObjectParameter("UserPhoto", typeof(string));
    
            var interestParameter = interest != null ?
                new ObjectParameter("Interest", interest) :
                new ObjectParameter("Interest", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var isAdminParameter = isAdmin.HasValue ?
                new ObjectParameter("IsAdmin", isAdmin) :
                new ObjectParameter("IsAdmin", typeof(bool));
    
            var isEnableParameter = isEnable.HasValue ?
                new ObjectParameter("IsEnable", isEnable) :
                new ObjectParameter("IsEnable", typeof(bool));
    
            var idProvinceParameter = idProvince.HasValue ?
                new ObjectParameter("IdProvince", idProvince) :
                new ObjectParameter("IdProvince", typeof(int));
    
            var idCantonParameter = idCanton.HasValue ?
                new ObjectParameter("IdCanton", idCanton) :
                new ObjectParameter("IdCanton", typeof(int));
    
            var idDistrictParameter = idDistrict.HasValue ?
                new ObjectParameter("IdDistrict", idDistrict) :
                new ObjectParameter("IdDistrict", typeof(int));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SPInsertUpdateProfessor", idProfessorParameter, degreeParameter, idUserProfileParameter, createByParameter, creationDateParameter, usernameParameter, passwordParameter, userPhotoParameter, interestParameter, emailParameter, isAdminParameter, isEnableParameter, idProvinceParameter, idCantonParameter, idDistrictParameter, actionParameter);
        }
    
        public virtual ObjectResult<SelectProfessorById_Result> SPSelectProfessorById(Nullable<int> idUserProfile)
        {
            var idUserProfileParameter = idUserProfile.HasValue ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectProfessorById_Result>("SPSelectProfessorById", idUserProfileParameter);
        }
    
        public virtual ObjectResult<SelectProfessor_Result> SPSelectProfessor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectProfessor_Result>("SPSelectProfessor");
        }
    
        public virtual ObjectResult<SelectRequestStudent_Result> SelectRequestStudent()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectRequestStudent_Result>("SelectRequestStudent");
        }
    
        public virtual int AproveRequest(Nullable<int> idStudent)
        {
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("IdStudent", idStudent) :
                new ObjectParameter("IdStudent", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AproveRequest", idStudentParameter);
        }
    
        public virtual int DeleteConsultation(Nullable<int> idConsultation)
        {
            var idConsultationParameter = idConsultation.HasValue ?
                new ObjectParameter("IdConsultation", idConsultation) :
                new ObjectParameter("IdConsultation", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteConsultation", idConsultationParameter);
        }
    
        public virtual ObjectResult<GetByIdConsultation_Result> GetByIdConsultation(Nullable<int> idConsultation)
        {
            var idConsultationParameter = idConsultation.HasValue ?
                new ObjectParameter("IdConsultation", idConsultation) :
                new ObjectParameter("IdConsultation", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdConsultation_Result>("GetByIdConsultation", idConsultationParameter);
        }
    
        public virtual int InsertUpdateConsultation(Nullable<int> idConsultation, Nullable<int> idCourse, string description, Nullable<int> idTransmitter, Nullable<int> idReceiver, string action)
        {
            var idConsultationParameter = idConsultation.HasValue ?
                new ObjectParameter("IdConsultation", idConsultation) :
                new ObjectParameter("IdConsultation", typeof(int));
    
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var idTransmitterParameter = idTransmitter.HasValue ?
                new ObjectParameter("IdTransmitter", idTransmitter) :
                new ObjectParameter("IdTransmitter", typeof(int));
    
            var idReceiverParameter = idReceiver.HasValue ?
                new ObjectParameter("IdReceiver", idReceiver) :
                new ObjectParameter("IdReceiver", typeof(int));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateConsultation", idConsultationParameter, idCourseParameter, descriptionParameter, idTransmitterParameter, idReceiverParameter, actionParameter);
        }
    
        public virtual ObjectResult<SelectConsultation_Result> SelectConsultation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectConsultation_Result>("SelectConsultation");
        }
    
        public virtual int DeleteComment(Nullable<int> idComment)
        {
            var idCommentParameter = idComment.HasValue ?
                new ObjectParameter("IdComment", idComment) :
                new ObjectParameter("IdComment", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteComment", idCommentParameter);
        }
    
        public virtual ObjectResult<GetByIComment_Result> GetByIComment(Nullable<int> idComment)
        {
            var idCommentParameter = idComment.HasValue ?
                new ObjectParameter("IdComment", idComment) :
                new ObjectParameter("IdComment", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIComment_Result>("GetByIComment", idCommentParameter);
        }
    
        public virtual int InsertUpdateComment(Nullable<int> idComment, string idUserProfile, Nullable<int> idConsultation, string commentary, string action)
        {
            var idCommentParameter = idComment.HasValue ?
                new ObjectParameter("IdComment", idComment) :
                new ObjectParameter("IdComment", typeof(int));
    
            var idUserProfileParameter = idUserProfile != null ?
                new ObjectParameter("IdUserProfile", idUserProfile) :
                new ObjectParameter("IdUserProfile", typeof(string));
    
            var idConsultationParameter = idConsultation.HasValue ?
                new ObjectParameter("IdConsultation", idConsultation) :
                new ObjectParameter("IdConsultation", typeof(int));
    
            var commentaryParameter = commentary != null ?
                new ObjectParameter("Commentary", commentary) :
                new ObjectParameter("Commentary", typeof(string));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateComment", idCommentParameter, idUserProfileParameter, idConsultationParameter, commentaryParameter, actionParameter);
        }
    
        public virtual ObjectResult<SelectComment_Result> SelectComment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectComment_Result>("SelectComment");
        }
    
        public virtual int DeleteAppointment(Nullable<int> idAppointment)
        {
            var idAppointmentParameter = idAppointment.HasValue ?
                new ObjectParameter("IdAppointment", idAppointment) :
                new ObjectParameter("IdAppointment", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteAppointment", idAppointmentParameter);
        }
    
        public virtual ObjectResult<GetByIdAppointment_Result> GetByIdAppointment(Nullable<int> idAppointment)
        {
            var idAppointmentParameter = idAppointment.HasValue ?
                new ObjectParameter("IdAppointment", idAppointment) :
                new ObjectParameter("IdAppointment", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByIdAppointment_Result>("GetByIdAppointment", idAppointmentParameter);
        }
    
        public virtual int InsertUpdateAppointment(Nullable<int> idAppointment, Nullable<int> idProfessor, Nullable<int> idStudent, Nullable<int> idCourse, Nullable<int> idSchedule, Nullable<bool> statusApprovedDisapproved, Nullable<bool> virtualOn_Site, string reasonForAppointment, Nullable<bool> professorResponse, string action)
        {
            var idAppointmentParameter = idAppointment.HasValue ?
                new ObjectParameter("IdAppointment", idAppointment) :
                new ObjectParameter("IdAppointment", typeof(int));
    
            var idProfessorParameter = idProfessor.HasValue ?
                new ObjectParameter("IdProfessor", idProfessor) :
                new ObjectParameter("IdProfessor", typeof(int));
    
            var idStudentParameter = idStudent.HasValue ?
                new ObjectParameter("IdStudent", idStudent) :
                new ObjectParameter("IdStudent", typeof(int));
    
            var idCourseParameter = idCourse.HasValue ?
                new ObjectParameter("IdCourse", idCourse) :
                new ObjectParameter("IdCourse", typeof(int));
    
            var idScheduleParameter = idSchedule.HasValue ?
                new ObjectParameter("IdSchedule", idSchedule) :
                new ObjectParameter("IdSchedule", typeof(int));
    
            var statusApprovedDisapprovedParameter = statusApprovedDisapproved.HasValue ?
                new ObjectParameter("StatusApprovedDisapproved", statusApprovedDisapproved) :
                new ObjectParameter("StatusApprovedDisapproved", typeof(bool));
    
            var virtualOn_SiteParameter = virtualOn_Site.HasValue ?
                new ObjectParameter("VirtualOn_Site", virtualOn_Site) :
                new ObjectParameter("VirtualOn_Site", typeof(bool));
    
            var reasonForAppointmentParameter = reasonForAppointment != null ?
                new ObjectParameter("ReasonForAppointment", reasonForAppointment) :
                new ObjectParameter("ReasonForAppointment", typeof(string));
    
            var professorResponseParameter = professorResponse.HasValue ?
                new ObjectParameter("ProfessorResponse", professorResponse) :
                new ObjectParameter("ProfessorResponse", typeof(bool));
    
            var actionParameter = action != null ?
                new ObjectParameter("Action", action) :
                new ObjectParameter("Action", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertUpdateAppointment", idAppointmentParameter, idProfessorParameter, idStudentParameter, idCourseParameter, idScheduleParameter, statusApprovedDisapprovedParameter, virtualOn_SiteParameter, reasonForAppointmentParameter, professorResponseParameter, actionParameter);
        }
    
        public virtual ObjectResult<SelectAppointment_Result> SelectAppointment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAppointment_Result>("SelectAppointment");
        }
    
        public virtual ObjectResult<SelectConsultation_Result> SPSelectConsultation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectConsultation_Result>("SPSelectConsultation");
        }
    }
}
