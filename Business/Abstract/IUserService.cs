﻿using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
