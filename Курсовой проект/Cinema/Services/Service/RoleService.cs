using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;
using Cinema.Services.Interface;
using System.Data;

namespace Cinema.Services.Service
{
    public class RoleService: ServiceConstructor, IRoleService
    {
        public RoleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }
        public async Task<Role> GetRole(string name)
        {
            IList<Role> roles = await UnitOfWork.Roles.GetAll();
            return roles.First(a => a.Name == name);
        }

        public async Task<Role> CreateRole(Role role)
        {
            return await UnitOfWork.Roles.Create(role);
        }

        public async Task UpdateRole(Role role)
        {
            await UnitOfWork.Roles.Update(role);
        }
    }
}
