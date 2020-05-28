using SPA_IE.Models.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_IE.Models.Data.Data
{
    public class CommentData
    {

        public List<SelectComment_Result> ListAllSP()
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                return context.SelectComment().ToList();
                }
            }
            catch
            {
                throw;
            }
        }


        public int Add(CommentDTO comment)
        {
            int resultToReturn;
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateComment(comment.IdComment, comment.IdUserProfile,comment.IdConsultation, comment.Commentary,"Insert");
            }
            }
            catch
            {
                throw;
            }
            return resultToReturn;
        }

        public int Update(CommentDTO comment)
        {
            int resultToReturn;
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                resultToReturn = context.SPInsertUpdateComment(comment.IdComment, comment.IdUserProfile, comment.IdConsultation, comment.Commentary, "Update");
                }
            }
            catch
            {
                throw;
            }
            return resultToReturn;
        }

        public GetByIComment_Result GetByICommentSP(int id)
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var comment = context.SPGetByIComment(id).Single();
                return comment;
            }
            }
            catch
            {
                throw;
            }
        }

        public int Delete(int id)
        {
            using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var resultToReturn = context.SPDeleteComment(id);

                return resultToReturn;
            }
        }

        public CommentDTO GetById(int id)
        {
            try
            {
                using (var context = new IF4101_BeatySolutions_ISem_2020Entities1())
            {
                var commentToReturn = (from comment in context.Comment
                                            join userProfile in context.UserProfile on comment.IdUserProfile equals userProfile.IdUserProfile
                                            join consultation in context.Consultation on comment.IdConsultation  equals consultation.IdConsultation
                                            select new CommentDTO
                                            {
                                                IdComment = comment.IdComment,
                                                IdUserProfile = consultation.IdCourse,
                                                Username = userProfile.Username,
                                                IdConsultation = comment.IdConsultation,
                                                Commentary = comment.Commentary,

                                            }).Where(x => x.IdComment == id).Single();
                return commentToReturn;
                }
            }
            catch
            {
                throw;
            }
        }
    }
    }


