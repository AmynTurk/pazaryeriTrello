using PazaryeriTrello.Interfaces;
using PazaryeriTrello.Models.Api;
using PazaryeriTrello.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PazaryeriTrello.Services
{
    public class UserAssignmentService : IUserAssignmentService
    {
        private readonly DataContext _dataContext;

        public UserAssignmentService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public GetUsersTasksResponse GetUsersTasks(int UserId)
        {
            GetUsersTasksResponse response = new GetUsersTasksResponse { IsSuccess = true };

            var taskData = from u in _dataContext.Users
                           join ua in _dataContext.UserAssignment
                           on u.Id equals ua.UserId
                           join a in _dataContext.Assignment
                           on ua.AssignmentId equals a.Id
                           where u.Id == UserId && ua.IsActive == true
                           select new UserAssignmentDTO
                           {
                               TaskText = a.Text,
                               Statue = ua.StatueId
                           };

            if (taskData != null && taskData.Count() > 0)
            {
                response.Data = taskData.ToList();
            }
            else
                response.IsSuccess = false;

            return response;
        }
    }
}
