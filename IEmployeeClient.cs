using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Employee
{
    public interface IEmployeeClient
    {
		[Obsolete]
        Task<EmployeeRequestResult<Guid>> AddPerson(Guid user, PersonProps person);
        Task<EmployeeRequestResult> SavePerson(Guid user, Person person);
        Task<EmployeeRequestResult<Person>> GetPerson(Guid user, Guid personGuid);
        Task<EmployeeRequestResult<PersonsResponse>> GetPersons(Guid user, int? skip = null, int? take = null, IEnumerable<string> fieldsToInclude = null);
        Task<EmployeeRequestResult> DeletePerson(Guid user, Guid personGuid);
        Task<EmployeeRequestResult<PersonsResponse>> SearchPersons(Guid user, IFilter filter, int? skip = null, int? take = null, IEnumerable<string> fieldsToInclude = null);

        Task<EmployeeRequestResult> SavePosition(Guid user, Position position);
        Task<EmployeeRequestResult<Position>> GetPosition(Guid user, Guid person, Guid organization);

        Task<EmployeeRequestResult> SaveRole(Guid user, Role role);
        Task<EmployeeRequestResult> DeleteRole(Guid user, Guid organization, RoleType roleType);
        Task<EmployeeRequestResult> DeleteRoles(Guid user, Guid organization);
        Task<EmployeeRequestResult<RoleResponse>> GetRole(Guid user, Guid organization, RoleType roleType);
        Task<EmployeeRequestResult<IReadOnlyDictionary<RoleType, RoleResponse>>> GetRoles(Guid user, Guid organization);
        Task<EmployeeRequestResult<IReadOnlyDictionary<Guid, IReadOnlyDictionary<RoleType, RoleResponse>>>> GetRoles(Guid user);
        Task<EmployeeRequestResult<IReadOnlyList<Role>>> GetPersonRoles(Guid user, Guid person, int? skip = null, int? take = null);

    }
}
