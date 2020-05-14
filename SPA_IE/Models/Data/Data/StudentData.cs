using SPA_IE.Models.Data.DTO;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;

namespace SPA_IE.Models.Data.Data
{
    public class StudentData
    {
        public List<SelectStudent_Result> ListAllSP()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SPSelectStudent().ToList();
            }
        }

        public List<SelectRequestStudent_Result> ListAllRequestSP()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SelectRequestStudent().ToList();
            }
        }

        public int Add(StudentDTO student)
        {
            int resultToReturn;
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateStudent(student.IdStudent, student.IdentificationCard, student.IdUserProfile, student.isASIP, student.isActive, student.CreateBy, DateTime.Now, student.Username, student.Password, student.UserPhoto, student.Interests, student.Email, student.IsAdmin, student.IsEnable, student.IdProvince, student.IdCanton, student.IdDistrict, "Insert");
            }
            return resultToReturn;
        }

        public int Update(StudentDTO student)
        {
            int resultToReturn;
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateStudent(student.IdStudent, student.IdentificationCard, student.IdUserProfile, student.isASIP, student.isActive, student.CreateBy, DateTime.Now, student.Username, student.Password, student.UserPhoto, student.Interests, student.Email, student.IsAdmin, student.IsEnable, student.IdProvince, student.IdCanton, student.IdDistrict, "Update");
            }
            return resultToReturn;
        }

        public SelectStudentById_Result GetByIdStudentSP(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var course = context.SPSelectStudentById(id).Single();
                return course;
            }
        }

        public int Delete(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.SPDeleteStudent(id);

                return resultToReturn;
            }
        }

        public StudentDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var studentToReturn = (from student in context.Student
                                       join userProfile in context.UserProfile on student.IdUserProfile equals userProfile.IdUserProfile
                                       join province in context.Province on userProfile.IdProvince equals province.IdProvince
                                       join canton in context.Canton on userProfile.IdCanton equals canton.IdCanton
                                       join district in context.District on userProfile.IdDistrict equals district.IdDistrict
                                       select new StudentDTO
                                       {
                                           IdStudent = student.IdStudent,
                                           IdentificationCard= student.IdentificationCard,
                                           IdUserProfile= userProfile.IdUserProfile,
                                           isASIP= student.IsASIP,
                                           isActive=   student.IsActive,
                                           CreateBy= student.CreateBy,
                                           CreationDate= student.CreationDate,
                                           Username= userProfile.Username,
                                           Password= userProfile.Password,
                                           UserPhoto= userProfile.UserPhoto,
                                           Interests= userProfile.Interests,
                                           Email= userProfile.Email,
                                           IsAdmin= userProfile.IsAdmin,
                                           IsEnable= userProfile.IsEnable,
                                           IdProvince= userProfile.IdProvince,
                                           NameProvince=province.Name,
                                           IdCanton= userProfile.IdCanton,
                                           NameCanton= canton.Name,
                                           IdDistrict=userProfile.IdDistrict,
                                           NameDistrict= district.Name,

                                        }).Where(x => x.IdStudent == id && x.IsEnable==true && x.isActive== true).Single();
                return studentToReturn;
            }
        }


        /*
        public List<StudentDTO> ListAllStudents()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var students = (from student in context.Student
                                join userProfile in context.UserProfile on student.idUserProfile equals userProfile.idUserProfile
                                join province in context.Province on userProfile.idProvince equals province.idProvince
                                join canton in context.Canton on userProfile.idCanton equals canton.idCanton
                                join district in context.District on userProfile.idDistrict equals district.idDistrict
                                select new StudentDTO
                                {
                                    IdStudent = student.idStudent,
                                    IdentificationCard = student.identificationCard,
                                    username = userProfile.username,
                                    creationDate=(DateTime)userProfile.creationDate,
                                   
                                }).ToList();
                return students;
            }
        }

        public StudentDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var studentToReturn = (from student in context.Student
                                       join userProfile in context.UserProfile on student.idUserProfile equals userProfile.idUserProfile
                                       join province in context.Province on userProfile.idProvince equals province.idProvince
                                       join canton in context.Canton on userProfile.idCanton equals canton.idCanton
                                       join district in context.District on userProfile.idDistrict equals district.idDistrict
                                       select new StudentDTO
                                       {
                                           IdStudent = student.idStudent,
                                           IdentificationCard = student.identificationCard,
                                           idUserProfile = userProfile.idUserProfile,
                                           username= userProfile.username,
                                           password = userProfile.password,
                                           interests = userProfile.interests,
                                           email = userProfile.email,
                                           nameProvince = province.name,
                                           idCanton = canton.idCanton,
                                           nameCanton = canton.name,
                                           nameDistrict = district.name,



                                       }).Where(x => x.IdStudent == id).Single();
                return studentToReturn;
            }
        }

        public void Update(StudentDTO studentDTO)
        {
           
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {

                var userProfile = context.UserProfile.First<UserProfile>(user => user.idUserProfile.Equals(studentDTO.idUserProfile));
                userProfile.username = studentDTO.username;
                userProfile.password = studentDTO.password;
                userProfile.userPhoto = "photo";
                userProfile.interests = studentDTO.interests;
                userProfile.email = studentDTO.email;
                userProfile.isAdmin = false;
                userProfile.isEnable = true;
                userProfile.idCanton = studentDTO.idCanton;
                userProfile.idProvince = studentDTO.idProvince;
                userProfile.idDistrict = studentDTO.idDistrict;
                userProfile.creationDate = DateTime.Now;
                userProfile.createBy = null;
                context.SaveChanges();
                var student = context.Student.First<Student>(stud => stud.idStudent.Equals(studentDTO.IdStudent));
                student.idUserProfile = userProfile.idUserProfile;
                student.identificationCard = studentDTO.IdentificationCard;

                context.SaveChanges();
            }
        }

        public void Add(StudentDTO studentDTO)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                UserProfile userProfile = new UserProfile();
                userProfile.username = studentDTO.username;
                userProfile.password = "pass";
                userProfile.userPhoto = null;
                userProfile.interests = null;
                userProfile.email = studentDTO.email;
                userProfile.isAdmin = studentDTO.isAdmin;
                userProfile.isEnable = true;
                userProfile.idCanton = studentDTO.idCanton;
                userProfile.idDistrict = studentDTO.idProvince;
                userProfile.idProvince = studentDTO.idDistrict;
                userProfile.creationDate = DateTime.Now;
                userProfile.createBy = null;
                context.UserProfile.Add(userProfile);
                context.SaveChanges();
                Student student = new Student();
                student.idUserProfile = userProfile.idUserProfile;
                student.identificationCard = studentDTO.IdentificationCard;
                context.Student.Add(student);
                context.SaveChanges();
            }
        }

        public int Delete(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.deleteStudentSP(id);
                return resultToReturn;
            }
        }*/
    }
}