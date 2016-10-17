﻿using System.Threading.Tasks;
using Model.ViewModel;

namespace Service.Interfaces
{
    public interface IUserService
    {
        Task<bool> Login(LoginViewModel model);
    }
}
