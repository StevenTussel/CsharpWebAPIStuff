﻿using Entities.LinkModels;
using Entities.Model;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IEmployeeService
{
    Task<(LinkResponse linkResponse, MetaData metaData)> GetEmployeesAsync(Guid companyId, LinkParameters linkParameters, bool trackChanges);
    Task<EmployeeDto> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges);  // Updated method name and return type

    Task<EmployeeDto> CreateEmployeeForCompanyAsync(Guid companyId, EmployeeForCreationDto employeeForCreation, bool trackChanges);  // Added "Async"

    Task DeleteEmployeeForCompanyAsync(Guid companyId, Guid id, bool trackChanges);

    Task UpdateEmployeeForCompanyAsync(Guid companyId, Guid id, EmployeeForUpdateDto employeeForUpdate, bool compTrackChanges, bool empTrackChanges);

    Task<(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity)> GetEmployeeForPatchAsync(Guid companyId, Guid id, bool compTrackChanges, bool empTrackChanges);  // Updated method name

    Task SaveChangesForPatchAsync(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity);  // Added "Async"
}
}
