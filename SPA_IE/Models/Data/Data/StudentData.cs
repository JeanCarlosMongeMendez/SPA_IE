using SPA_IE.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SPA_IE.Models.Data.Data
{
    public class StudentData
    {
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
        }
    }
}