﻿using BLL.DTO;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILendingService
    {
        IList<LendObjectDTO> GetUserLendObjects(string userId);

        IList<LendingDTO> GetUserLendings(string userId);

        IList<LendingDTO> GetUserBorrowings(string userId);

        void LendUserObject(string userId, string objectId, string otherUserName);

        void LendUserObjectToContact(string userId, string objectId, string otherUserName, string otherEmail);

        string AddUserLendObject(string userId, LendObjectDTO lobject);

        void RemoveUserLendObject(string userId, string objectId);

        LendObjectDTO GetUserObject(string userId, string objectId);

        void UserObjectReturned(string userId, string objectId);

        void AddImageToLendObject(string userId, string objectId, string fileName);

        void AddPropertyToLendObject(string userId, string objectId, object property);
    }
}
