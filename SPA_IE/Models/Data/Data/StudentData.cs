using SPA_IE.Models.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class StudentData
    {
        public List<StudentDTO> ListAllStudents()
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {

                var students = (from student in context.Student
                                select new StudentDTO
                                {
                                    IdStudent = student.idStudent,
                                    IdentificationCard = student.identificationCard,
                                }).ToList();


                return students;


            }
        }


        public StudentDTO GetById(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {


                var studentToReturn = (from student in context.Student
                                       select new StudentDTO
                                       {
                                           IdStudent = student.idStudent,
                                           IdentificationCard = student.identificationCard,
                                       }).Where(x => x.IdStudent == id).Single();


                return studentToReturn;


            }
        }

        public int Update(StudentDTO studentDTO)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                resultToReturn = context.InsertUpdateStudentSP(studentDTO.IdStudent, studentDTO.IdentificationCard, "Update");
            }

            return resultToReturn;
        }

        public int Add(StudentDTO studentDTO)
        {
            int resultToReturn;

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                resultToReturn = context.InsertUpdateStudentSP(studentDTO.IdStudent, studentDTO.IdentificationCard, "Insert");
            }

            return resultToReturn;

        }

        public int Delete(int id)
        {

            using (var context = new IF4101_BeatySolutions_ISem_2020Entities())
            {
                var resultToReturn = context.deleteStudentSP(id);

                return resultToReturn;
            }

        }
    }
}